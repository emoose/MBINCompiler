#!/bin/bash

if [[ $TRAVIS_TAG ]]; then
    export LIBMBIN_VERSION="$(cat libMBIN/Source/Version.cs | grep -P 'const[[:space:]]+string[[:space:]]+VERSION_STRING' | grep -oP '[0-9]+[.][0-9]+[.][0-9]+[.][0-9]+')"
    echo "LIBMBIN_VERSION: $LIBMBIN_VERSION"
    [[ "$TRAVIS_TAG" =~ ^v([[:digit:]]+)[.]([[:digit:]]+)[.]([[:digit:]]+)(-[^[:digit:]]+([[:digit:]]+)|[.]([[:digit:]])+) ]] && export MATCH_TAG=${BASH_REMATCH[1]}.${BASH_REMATCH[2]}.${BASH_REMATCH[3]}.${BASH_REMATCH[5]}${BASH_REMATCH[6]}
    echo "Tag: $TRAVIS_TAG -> $MATCH_TAG"
    [[ "$MATCH_TAG" == "$LIBMBIN_VERSION" ]] && echo "$TRAVIS_TAG matches LIBMBIN_VERSION." || echo "Error: The version tag $TRAVIS_TAG must match the LIBMBIN_VERSION defined in Version.cs" && set -e
fi
