#!/bin/bash

pushd .
cd "$(dirname "$0")"
rm ../SlangNet/Generated/*.cs
#rm ../SlangNet/GeneratedDoc/*.xml
rm ../SlangNet.Tests/Generated/*.cs
ClangSharpPInvokeGenerator @GenerateSlangSource.rsp
#ClangSharpPInvokeGenerator @GenerateSlangXml.rsp
popd
