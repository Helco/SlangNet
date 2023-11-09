using static SlangNet.Unsafe.SlangWriterMode;

namespace SlangNet;

public enum WriterMode : uint
{
    Text = SLANG_WRITER_MODE_TEXT,
    Binary = SLANG_WRITER_MODE_BINARY
}
