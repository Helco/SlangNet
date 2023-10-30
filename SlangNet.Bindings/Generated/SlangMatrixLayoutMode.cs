using SlangNet.Unsafe;

namespace SlangNet;

/// <include file='SlangMatrixLayoutMode.xml' path='doc/member[@name="SlangMatrixLayoutMode"]/*' />
[NativeTypeName("SlangMatrixLayoutModeIntegral")]
public enum SlangMatrixLayoutMode : uint
{
    /// <include file='SlangMatrixLayoutMode.xml' path='doc/member[@name="SlangMatrixLayoutMode.SLANG_MATRIX_LAYOUT_MODE_UNKNOWN"]/*' />
    SLANG_MATRIX_LAYOUT_MODE_UNKNOWN = 0,

    /// <include file='SlangMatrixLayoutMode.xml' path='doc/member[@name="SlangMatrixLayoutMode.SLANG_MATRIX_LAYOUT_ROW_MAJOR"]/*' />
    SLANG_MATRIX_LAYOUT_ROW_MAJOR,

    /// <include file='SlangMatrixLayoutMode.xml' path='doc/member[@name="SlangMatrixLayoutMode.SLANG_MATRIX_LAYOUT_COLUMN_MAJOR"]/*' />
    SLANG_MATRIX_LAYOUT_COLUMN_MAJOR,
}
