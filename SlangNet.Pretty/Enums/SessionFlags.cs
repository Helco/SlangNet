using System;
using static SlangNet.Unsafe.Slang;

namespace SlangNet;

[Flags]
public enum SessionFlags : uint
{
    FalcorCustomSharedKeywordSemantics = kSessionFlag_FalcorCustomSharedKeywordSemantics
}
