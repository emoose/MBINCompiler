import pytest
import os.path as op
import os

from utils import compare_mbins, convert_mbin, failed_files


DATA_PATH = op.join(op.dirname(__file__), 'data')
BASE_PATH = op.join("Build", "Release", "win-x64")
TO_EXML_FAIL = 'Failed conversion to EXML'
TO_MBIN_FAIL = 'Failed conversion to MBIN'


def pytest_generate_tests(metafunc):
    """ Generate a parameterization that contains the list of all the files
    that need to be tested. Ie. every file in the ./data folder.
    """
    _datapath = metafunc.config.getoption('datapath') or DATA_PATH
    # If we want to only rerun the failed tests, return only that list
    if metafunc.config.getoption('rerun') == 'failed':
        fpaths = failed_files(_datapath)
    else:
        # Otherwise, collect the file list as normal
        fpaths = list()
        for root, _, files in os.walk(_datapath):
            for fname in files:
                if op.splitext(fname)[1] == '.MBIN':
                    fpaths.append(op.join(root, fname))
    metafunc.parametrize("fname", fpaths)


@pytest.fixture()
def MBINCompiler(platform):
    if platform == 'linux-x64':
        # need to run with mono on linux
        # Build path also includes platform on the CI
        cmd = ['sudo', 'mono',
               op.join(BASE_PATH, platform, 'MBINCompiler.exe'), '-q']
    else:
        cmd = [op.join(BASE_PATH, 'MBINCompiler.exe'), '-q']
    return cmd


def test_compare(datapath, MBINCompiler, fname):
    """ Run the comparison test on a file.
    This test is parameterised by fpath which will contain the paths of all
    .MBIN files in the ./data directory.
    """
    converted = convert_mbin(fname, MBINCompiler)
    if converted not in (TO_EXML_FAIL, TO_MBIN_FAIL):
        assert compare_mbins(fname, converted)
    else:
        print(f'{fname},{converted}')
        pytest.fail()
