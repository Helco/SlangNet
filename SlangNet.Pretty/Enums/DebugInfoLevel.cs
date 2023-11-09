using static SlangNet.Unsafe.SlangDebugInfoLevel;

namespace SlangNet;

public enum DebugInfoLevel : uint
{
    None = SLANG_DEBUG_INFO_LEVEL_NONE,
    Minimal = SLANG_DEBUG_INFO_LEVEL_MINIMAL,
    Standard = SLANG_DEBUG_INFO_LEVEL_STANDARD,
    Maximal = SLANG_DEBUG_INFO_LEVEL_MAXIMAL
}
