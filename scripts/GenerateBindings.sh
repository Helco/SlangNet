#!/bin/bash

pushd .
cd "$(dirname "$0")"
mkdir -p ../SlangNet.Bindings/Generated
mkdir -p ../SlangNet.Tests/SlangNet.Tests.Shared/Generated
rm ../SlangNet.Bindings/Generated/*.cs
rm ../SlangNet.Tests/SlangNet.Tests.Shared/Generated/*.cs
ClangSharpPInvokeGenerator @GenerateSlangSource.rsp
popd
