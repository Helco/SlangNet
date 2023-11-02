using static SlangNet.Unsafe.SlangMatrixLayoutMode;

namespace SlangNet;

public enum MatrixLayoutMode : uint
{
    Unknown = SLANG_MATRIX_LAYOUT_MODE_UNKNOWN,
    RowMajor = SLANG_MATRIX_LAYOUT_ROW_MAJOR,
    ColumnMajor = SLANG_MATRIX_LAYOUT_COLUMN_MAJOR
}
