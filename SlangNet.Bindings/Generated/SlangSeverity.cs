using SlangNet.Unsafe;

namespace SlangNet;

/// <include file='SlangSeverity.xml' path='doc/member[@name="SlangSeverity"]/*' />
[NativeTypeName("SlangSeverityIntegral")]
public enum SlangSeverity
{
    /// <include file='SlangSeverity.xml' path='doc/member[@name="SlangSeverity.SLANG_SEVERITY_DISABLED"]/*' />
    SLANG_SEVERITY_DISABLED = 0,

    /// <include file='SlangSeverity.xml' path='doc/member[@name="SlangSeverity.SLANG_SEVERITY_NOTE"]/*' />
    SLANG_SEVERITY_NOTE,

    /// <include file='SlangSeverity.xml' path='doc/member[@name="SlangSeverity.SLANG_SEVERITY_WARNING"]/*' />
    SLANG_SEVERITY_WARNING,

    /// <include file='SlangSeverity.xml' path='doc/member[@name="SlangSeverity.SLANG_SEVERITY_ERROR"]/*' />
    SLANG_SEVERITY_ERROR,

    /// <include file='SlangSeverity.xml' path='doc/member[@name="SlangSeverity.SLANG_SEVERITY_FATAL"]/*' />
    SLANG_SEVERITY_FATAL,

    /// <include file='SlangSeverity.xml' path='doc/member[@name="SlangSeverity.SLANG_SEVERITY_INTERNAL"]/*' />
    SLANG_SEVERITY_INTERNAL,
}
