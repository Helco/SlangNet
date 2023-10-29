#!/bin/bash

pushd .
cd "$(dirname "$0")"
rm ../SlangNet/Generated/*.cs
rm ../SlangNet.Tests/Generated/*.cs
ClangSharpPInvokeGenerator @GenerateSlang.rsp
popd
