using static SlangNet.Unsafe.SlangArchiveType;

namespace SlangNet;

public enum ArchiveType
{
    Undefined = SLANG_ARCHIVE_TYPE_UNDEFINED,
    Zip = SLANG_ARCHIVE_TYPE_ZIP,
    Riff = SLANG_ARCHIVE_TYPE_RIFF,
    RiffDeflate = SLANG_ARCHIVE_TYPE_RIFF_DEFLATE,
    RiffLZ4 = SLANG_ARCHIVE_TYPE_RIFF_LZ4
}
