#!/bin/bash
clang++ -shared -fPIC -fdeclspec -o build/libnative.so src/person.cpp src/wrapper.cpp
