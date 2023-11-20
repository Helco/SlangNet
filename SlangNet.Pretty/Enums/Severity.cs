using static SlangNet.Unsafe.SlangSeverity;

namespace SlangNet;

public enum Severity
{
    Disabled = SLANG_SEVERITY_DISABLED,
    Note = SLANG_SEVERITY_NOTE,
    Warning = SLANG_SEVERITY_WARNING,
    Error = SLANG_SEVERITY_ERROR,
    Fatal = SLANG_SEVERITY_FATAL,
    Internal = SLANG_SEVERITY_INTERNAL
}
