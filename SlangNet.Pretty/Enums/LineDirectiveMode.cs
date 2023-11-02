using static SlangNet.Unsafe.SlangLineDirectiveMode;

namespace SlangNet;

public enum LineDirectiveMode : uint
{
    Default = SLANG_LINE_DIRECTIVE_MODE_DEFAULT,
    None = SLANG_LINE_DIRECTIVE_MODE_NONE,
    Standard = SLANG_LINE_DIRECTIVE_MODE_STANDARD,
    GLSL = SLANG_LINE_DIRECTIVE_MODE_GLSL,
    SourceMap = SLANG_LINE_DIRECTIVE_MODE_SOURCE_MAP
}
