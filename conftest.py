from tests.utils import download_data
import os.path as op
import pytest
from tests.utils import format_err_results


DATA_PATH = op.join(op.dirname(__file__), 'tests', 'data')


def pytest_addoption(parser):
    parser.addoption("--platform", action="store", default="win-x64",
                     help="The platform the tests are run on.",
                     choices=['win-x64', 'ubuntu.16.04-x64'])
    parser.addoption("--datapath", action="store", default=None,
                     help="The relative or absolute path to a folder "
                          "containing .MBIN files to be tested. If not "
                          "provided, the test data will be downloaded from "
                          "the MBINCompiler-test-data repository.")
    parser.addoption("--use_cache", action="store_true",
                     default=False,
                     help="Whether or not to use cached data that was "
                          "downloaded by running the tests with no additional "
                          "arguments.")


def pytest_generate_tests(metafunc):
    # This is called for every test. Only get/set command line arguments
    # if the argument is specified in the list of test "fixturenames".
    if 'platform' in metafunc.fixturenames:
        metafunc.parametrize("platform",
                             [metafunc.config.getoption('platform')])
    if 'datapath' in metafunc.fixturenames:
        metafunc.parametrize("datapath",
                             [metafunc.config.getoption('datapath')])


def pytest_sessionstart(session):
    # Before running any tests collect the required test data
    datapath = session.config.getoption('datapath')
    use_cache = session.config.getoption('use_cache')
    if datapath is not None and use_cache:
        print("Providing both 'datapath' and 'use_cache' command line "
              "arguments doesn't mean anything. 'datapath' will take "
              "precedence.")
    if datapath is not None:
        print(f'datapath provided: {datapath}')
    elif use_cache:
        data_path = op.join(op.dirname(__file__), 'tests', 'data')
        print(f'Using cached test data located at {data_path}')
    else:
        print("Collecting test data")
        download_data()
        print("Test data collected")


@pytest.hookimpl(hookwrapper=True)
def pytest_terminal_summary(terminalreporter):
    yield
    datapath = terminalreporter.config.getoption('datapath') or DATA_PATH
    results = []
    for failed in terminalreporter.stats.get('failed', []):
        if len(failed.sections) != 0:
            fname, err = failed.sections[0][1].split(',')
        # Fix the filename to be relative to the test data directory
        fname = op.relpath(fname, datapath)
        results.append((fname, err.replace('\n', '')))
    results = format_err_results(results)
    print('\n')
    for result in results:
        print(result)
