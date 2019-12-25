from io import BytesIO
import os
import os.path as op
import tempfile
import shutil
import subprocess
import zipfile

import requests


IGNORE_FNAME = '_ignore.txt'
SIZE_MISMATCH = 'size_mismatch'

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
    # We can do a quick check to make sure the files are the same size,
    # otherwise immediately return False.
    size = os.stat(left_path).st_size
    if size != os.stat(right_path).st_size:
        return fail_comparison(right_path, SIZE_MISMATCH)
    # Do a byte-wise comparison of the files.
    bad_loc = None
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
                if left_bytes[i] != right_bytes[i]:
                    bad_loc = i
                    break
    if bad_loc is not None:
        return fail_comparison(right_path, bad_loc)
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
        cmd.append(op.join(temp_dir, '%s.EXML' % fname))
        subprocess.run(cmd)
        # Move the file back to the original directory but renamed
        new_fname = op.join(op.dirname(fpath), '%s-recompiled.MBIN' % fname)
        shutil.move(op.join(temp_dir, '%s.MBIN' % fname), new_fname)
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
    os.remove(file)
    print(f'An error occured comparing {op.basename(file)}:')
    if loc == SIZE_MISMATCH:
        print('Files are a different size.')
    else:
        print(f'Byte-wise comparison fails at 0x{(loc - 0x60):x} (adjusted)')
    return False


def ignore_list(fpath):
    """ Gets the list of files to be ignored within a given directory.

    Parmaeters
    ----------
    fpath : str
        Absolute path to a directory containing files and an ignore.txt file.

    Returns
    ignored_files : list
        List of filenames within the folder that aren't to be tested.
    """
    ignored_files = []
    with open(op.join(fpath, IGNORE_FNAME)) as f:
        for line in f:
            ignored_files.append(line.strip('\n'))
    return ignored_files
