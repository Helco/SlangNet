#!/bin/bash

pushd .
cd "$(dirname "$0")"
mkdir -p ../SlangNet.RHI.Bindings/Generated
mkdir -p ../SlangNet.RHI.Tests/Generated
rm ../SlangNet.RHI.Bindings/Generated/*.cs
rm ../SlangNet.RHI.Tests/Generated/*.cs
ClangSharpPInvokeGenerator @GenerateSlangRHISource.rsp
popd
