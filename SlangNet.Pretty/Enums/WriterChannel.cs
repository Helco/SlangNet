using static SlangNet.Unsafe.SlangWriterChannel;

namespace SlangNet;

public enum WriterChannel : uint
{
    Diagnostic = SLANG_WRITER_CHANNEL_DIAGNOSTIC,
    StdOutput = SLANG_WRITER_CHANNEL_STD_OUTPUT,
    StdError = SLANG_WRITER_CHANNEL_STD_ERROR
}
