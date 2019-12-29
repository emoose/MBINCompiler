import pytest
import os.path as op
import os

from utils import compare_mbins, convert_mbin, ignore_list


DATA_PATH = op.join(op.dirname(__file__), 'data')
BASE_PATH = op.join("Build", "Release")


def pytest_generate_tests(metafunc):
    """ Generate a parameterization that contains the list of all the files
    that need to be tested. Ie. every file in the ./data folder.
    """
    fpaths = os.listdir(DATA_PATH)
    fpaths = list(fpath for fpath in fpaths if
                  op.splitext(fpath)[1] == '.MBIN')
    metafunc.parametrize("fname", fpaths)


@pytest.fixture(scope='session')
def ignored_files():
    """ Return a list of files that we want to ignore when testing.
    This will ideally be an empty list, but it's good to be able to exclude
    some files if need be.
    """
    return ignore_list(DATA_PATH)


@pytest.fixture()
def MBINCompiler(platform):
    if platform == 'ubuntu.16.04-x64':
        # need to run with mono on linux
        # Build path also includes platform on the CI
        cmd = ['sudo', 'mono',
               op.join(BASE_PATH, platform, 'MBINCompiler.exe'), '-q']
    else:
        cmd = [op.join(BASE_PATH, 'MBINCompiler.exe'), '-q']
    return cmd


def test_compare(MBINCompiler, ignored_files, fname):
    """ Run the comparison test on a file.
    This test is parameterised by fpath which will contain the paths of all
    .MBIN files in the ./data directory.
    """
    if fname not in ignored_files:
        fpath = op.join(DATA_PATH, fname)
        converted = convert_mbin(fpath, MBINCompiler)
        assert compare_mbins(fpath, converted)
    else:
        pytest.skip()
