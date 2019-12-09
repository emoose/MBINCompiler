import pytest
import os.path as op
import os

import data
from utils import compare_mbins, convert_mbin, ignore_list

print(data.__version__)

"""
TODO:
 - Add a pytest.ini file which allows arguments to be passed to the test.
 - move build back into the standard build folder so that the path can be
 generated based on a relative file path. ie. ../<OS>/Release/MBINCompiler.exe
 - will probably need to still use chmod +x to ensure it is executable.
"""


DATA_PATH = op.join(op.dirname(__file__), 'data')
GLOBALS_PATH = op.join(DATA_PATH, 'globals')

BASE_PATH = op.join("Build", "Release")


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


def test_globals_compare(MBINCompiler):
    """ Run the comparison test on the globals. """
    ignored_globals = ignore_list(GLOBALS_PATH)
    for fname in os.listdir(GLOBALS_PATH):
        # Only test .mbin files we don't want to ignore
        if fname not in ignored_globals and op.splitext(fname)[1] == '.MBIN':
            fpath = op.join(GLOBALS_PATH, fname)
            converted = convert_mbin(fpath, MBINCompiler)
            assert compare_mbins(fpath, converted)
        else:
            print('ignoring %s' % str(fname))
