using SlangNet.Unsafe;

namespace SlangNet;

/// <include file='SlangWriterMode.xml' path='doc/member[@name="SlangWriterMode"]/*' />
[NativeTypeName("SlangWriterModeIntegral")]
public enum SlangWriterMode : uint
{
    /// <include file='SlangWriterMode.xml' path='doc/member[@name="SlangWriterMode.SLANG_WRITER_MODE_TEXT"]/*' />
    SLANG_WRITER_MODE_TEXT,

    /// <include file='SlangWriterMode.xml' path='doc/member[@name="SlangWriterMode.SLANG_WRITER_MODE_BINARY"]/*' />
    SLANG_WRITER_MODE_BINARY,
}
