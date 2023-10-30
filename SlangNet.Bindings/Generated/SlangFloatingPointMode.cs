namespace SlangNet.Unsafe;

/// <include file='SlangFloatingPointMode.xml' path='doc/member[@name="SlangFloatingPointMode"]/*' />
[NativeTypeName("SlangFloatingPointModeIntegral")]
public enum SlangFloatingPointMode : uint
{
    /// <include file='SlangFloatingPointMode.xml' path='doc/member[@name="SlangFloatingPointMode.SLANG_FLOATING_POINT_MODE_DEFAULT"]/*' />
    SLANG_FLOATING_POINT_MODE_DEFAULT = 0,

    /// <include file='SlangFloatingPointMode.xml' path='doc/member[@name="SlangFloatingPointMode.SLANG_FLOATING_POINT_MODE_FAST"]/*' />
    SLANG_FLOATING_POINT_MODE_FAST,

    /// <include file='SlangFloatingPointMode.xml' path='doc/member[@name="SlangFloatingPointMode.SLANG_FLOATING_POINT_MODE_PRECISE"]/*' />
    SLANG_FLOATING_POINT_MODE_PRECISE,
}
