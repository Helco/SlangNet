using System;
using SlangNet.Unsafe;

namespace SlangNet;

[Flags]
public enum CompileStdLibFlags : uint
{
    WriteDocumentation = CompileStdLibFlag.Enum.WriteDocumentation
}
