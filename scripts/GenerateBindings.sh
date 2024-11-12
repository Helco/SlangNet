#!/bin/bash

pushd .
cd "$(dirname "$0")"
mkdir -p ../SlangNet.Bindings/Generated
mkdir -p ../SlangNet.Tests/Generated
rm ../SlangNet.Bindings/Generated/*.cs
rm ../SlangNet.Tests/Generated/*.cs
ClangSharpPInvokeGenerator @GenerateSlangSource.rsp
popd
