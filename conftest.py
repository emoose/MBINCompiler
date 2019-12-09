def pytest_addoption(parser):
    parser.addoption("--platform", action="store", default="win-x64")


def pytest_generate_tests(metafunc):
    # This is called for every test. Only get/set command line arguments
    # if the argument is specified in the list of test "fixturenames".
    option_value = metafunc.config.option.platform
    if 'platform' in metafunc.fixturenames and option_value is not None:
        metafunc.parametrize("platform", [option_value])
