#!/bin/bash

pushd .
cd "$(dirname "$0")"
rm ../SlangNet.Bindings/Generated/*.cs
rm ../SlangNet.Tests/Generated/*.cs
ClangSharpPInvokeGenerator @GenerateSlangSource.rsp
popd
