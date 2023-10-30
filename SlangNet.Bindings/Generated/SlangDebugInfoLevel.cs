namespace SlangNet.Unsafe;

/// <include file='SlangDebugInfoLevel.xml' path='doc/member[@name="SlangDebugInfoLevel"]/*' />
[NativeTypeName("SlangDebugInfoLevelIntegral")]
public enum SlangDebugInfoLevel : uint
{
    /// <include file='SlangDebugInfoLevel.xml' path='doc/member[@name="SlangDebugInfoLevel.SLANG_DEBUG_INFO_LEVEL_NONE"]/*' />
    SLANG_DEBUG_INFO_LEVEL_NONE = 0,

    /// <include file='SlangDebugInfoLevel.xml' path='doc/member[@name="SlangDebugInfoLevel.SLANG_DEBUG_INFO_LEVEL_MINIMAL"]/*' />
    SLANG_DEBUG_INFO_LEVEL_MINIMAL,

    /// <include file='SlangDebugInfoLevel.xml' path='doc/member[@name="SlangDebugInfoLevel.SLANG_DEBUG_INFO_LEVEL_STANDARD"]/*' />
    SLANG_DEBUG_INFO_LEVEL_STANDARD,

    /// <include file='SlangDebugInfoLevel.xml' path='doc/member[@name="SlangDebugInfoLevel.SLANG_DEBUG_INFO_LEVEL_MAXIMAL"]/*' />
    SLANG_DEBUG_INFO_LEVEL_MAXIMAL,
}
