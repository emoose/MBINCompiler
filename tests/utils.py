from io import BytesIO
import json
import os
import os.path as op
import tempfile
import shutil
import subprocess
import zipfile

import requests


FAILED_FNAME = '_failed.txt'
TO_EXML_FAIL = 'Failed conversion to EXML'
TO_MBIN_FAIL = 'Failed conversion to MBIN'
SIZE_MISMATCH = 'Size mismatch'
INCORRECT_GUID = 'Incorrect GUID'

GIT_API = 'https://api.github.com'
# The data folder should be unpacked into the same folder as this file
DATA_PATH = op.dirname(__file__)


def compare_mbins(left_path, right_path):
    """ Compare byte-wise two MBIN files.

    Parameters
    ----------
    left_path : str
        Absolute path of the original MBIN file.
    right_path : str
        Absolute path to the recompiled MBIN file.

    Returns
    -------
    is_same : bool
        Whether or not the two MBIN files are identical (up to a difference in
        the header due to the addition of an MBINCompiler version)
    """
    size = os.stat(left_path).st_size
    # Do a byte-wise comparison of the files.
    bad_loc = None
    bad_guid = False
    with open(left_path, 'rb') as f_left:
        with open(right_path, 'rb') as f_right:
            left_bytes = f_left.read()
            right_bytes = f_right.read()
            # Skip over the ignored bytes... (0x6 -> 0xF)
            for i in range(0, 0x6):
                if left_bytes[i] != right_bytes[i]:
                    bad_loc = i
                    break
            for i in range(0x10, size):
                try:
                    if left_bytes[i] != right_bytes[i]:
                        if i <= 0x18:
                            bad_guid = True
                        else:
                            bad_loc = i
                            break
                except IndexError:
                    bad_loc = i
                    break
    if bad_loc is not None:
        return fail_comparison(right_path, bad_loc)
    # We will also ensure that the files are the same length to make sure we
    # have compared all of each file.
    if size != os.stat(right_path).st_size:
        return fail_comparison(right_path, SIZE_MISMATCH)
    # At the moment, only consider a GUID mismatch at the end.
    if bad_guid:
        return fail_comparison(right_path, INCORRECT_GUID)
    # If we got this far then the files are good!
    os.remove(right_path)
    return True


def convert_mbin(fpath, MBINCompiler_command):
    """ Convert an MBIN file to EXML and back in a temp directory.

    Parameters
    ----------
    fpath : str
        The absolute filepath to the mbin to be converted.
    MBINCompiler_command : list
        A list containing the commands required to run MBINCompiler on whatever
        platform the test is run on.

    Returns
    -------
    out_path : str
        The final path of the recompiled MBIN file.
    """
    fname = op.splitext(op.basename(fpath))[0]
    with tempfile.TemporaryDirectory() as temp_dir:
        # First convert mbin to exml
        cmd = list(MBINCompiler_command)
        cmd.append('--output-dir=%s' % temp_dir)
        cmd.append(fpath)
        subprocess.run(cmd)
        # Now we want to convert the exml back to mbin
        cmd = list(MBINCompiler_command)
        cmd.append('--output-dir=%s' % temp_dir)
        exml_fname = op.join(temp_dir, '%s.EXML' % fname)
        # If the conversion fails to exml return an error value
        if not op.exists(exml_fname):
            return TO_EXML_FAIL
        cmd.append(exml_fname)
        subprocess.run(cmd)
        # Move the file back to the original directory but renamed
        new_fname = op.join(op.dirname(fpath), '%s-recompiled.MBIN' % fname)
        # If the new files doesn't exist (ie. reconversion failed) return an
        # error value
        recompiled_fname = op.join(temp_dir, '%s.MBIN' % fname)
        if not op.exists(recompiled_fname):
            return TO_MBIN_FAIL
        shutil.move(recompiled_fname, new_fname)
        return new_fname


def download_data():
    """ Download the test data and unpack into the appropriate folder. """
    owner = 'monkeyman192'
    repo = 'MBINCompiler-test-data'
    cmd = '/repos/{0}/{1}/releases/latest'.format(owner, repo)
    r = requests.get(GIT_API + cmd)
    data = r.json()

    assets = data.get('assets', [None])[0]
    if assets is not None:
        # Download the zip
        url = assets['browser_download_url']
        r = requests.get(url)
        data = BytesIO(r.content)
        # Make sure to remove the old test data folder
        if op.exists(op.join(DATA_PATH, 'data')):
            shutil.rmtree(op.join(DATA_PATH, 'data'))
        with zipfile.ZipFile(data) as data_zip:
            data_zip.extractall(DATA_PATH)


def fail_comparison(file, loc):
    """ A simple function to do some cleanup and error reporting when running
    in verbose mode.
    """
    fname_fixed = file.replace('-recompiled', '')
    if loc == SIZE_MISMATCH:
        err = SIZE_MISMATCH
    else:
        if loc == INCORRECT_GUID:
            # The error occurs in the GUID
            with open(file, 'rb') as f:
                f.seek(0x18)
                name = f.read(0x40).decode()
            err = f'GUID of {name} is incorrect'
        else:
            err = f'Difference at 0x{(loc - 0x60):x}'
    os.remove(file)
    print(f'{fname_fixed},{err}')
    return False


def failed_files(fpath):
    """ Gets the list of files that failed on a previous test run.

    Parmaeters
    ----------
    fpath : str
        Absolute path to a directory containing files and a _failed.txt file.

    Returns
    files : list
        List of filenames within the folder that failed the previous test run.
    """
    files = []
    failed_file = op.join(fpath, FAILED_FNAME)
    if op.exists(failed_file):
        with open(failed_file) as f:
            for line in f:
                files.append(line.strip('\n'))
    return files


def format_err_results(results):
    table = []
    fnames = []
    errs = []
    max_fname_len = 0
    max_err_len = 0
    for fname, err in results:
        fnames.append(fname)
        errs.append(err)
        max_fname_len = max(len(fname), max_fname_len)
        max_err_len = max(len(err), max_err_len)
    # Add the table header
    table.append(
        'Filename:'
        + ' ' * (max_fname_len - 9)
        + ' | '
        + 'Reason:' + ' ' * max(0, max_err_len - 7))
    # Add the first row of hyphens
    table.append(
        '-' * max_fname_len
        + ' | '
        + '-' * max(7, max_err_len))
    # Now for each row, add the info
    for i in range(len(fnames)):
        table.append(
            fnames[i] + ' ' * (max_fname_len - len(fnames[i]))
            + ' | '
            + errs[i] + ' ' * max(0, max_err_len - len(errs[i])))
    return table


def generate_report(input_fname, output_fname, datapath):
    """ Generate a .json file which contains info about the test.

    Parameters
    ----------
    input_fname : str
        The path to the input file to be read.
        This file MUST be space separated with rows in the format:
        <file name> <result>
    output_fname: str
        The path to write the json formatted data to.
    """
    version = 'Unknown'
    version_path = op.join(datapath, '.version')
    if op.exists(version_path):
        with open(version_path, 'r') as f:
            version = f.read().strip('\n')  # strip \n just in case...

    if op.exists(input_fname):
        data = {'version': version,
                'passed_count': 0,
                'failed_count': 0,
                'total_count': 0,
                'result': '?/?',
                'passed': [],
                'failed': [],
                'skipped': []}
        with open(input_fname, 'r') as f:
            for line in f:
                try:
                    fname, result = line.replace('\n', '').split(' ')
                    data[result].append(fname)
                    data['total_count'] += 1
                    if result == 'passed':
                        data['passed_count'] += 1
                    elif result == 'failed':
                        data['failed_count'] += 1
                except ValueError:
                    # This may happen on the blank final line
                    pass
            # Now that we have done every line. Determine the result value
            data['result'] = f"{data['passed_count']}/{data['total_count']}"
        with open(output_fname, 'w') as f:
            json.dump(data, f, indent=4)
