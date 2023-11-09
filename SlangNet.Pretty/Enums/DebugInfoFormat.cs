using static SlangNet.Unsafe.SlangDebugInfoFormat;

namespace SlangNet;

public enum DebugInfoFormat : uint
{
    Default = SLANG_DEBUG_INFO_FORMAT_DEFAULT,
    C7 = SLANG_DEBUG_INFO_FORMAT_C7,
    PDB = SLANG_DEBUG_INFO_FORMAT_PDB,
    STABS = SLANG_DEBUG_INFO_FORMAT_STABS,
    COFF = SLANG_DEBUG_INFO_FORMAT_STABS,
    DWARF = SLANG_DEBUG_INFO_FORMAT_DWARF
}
