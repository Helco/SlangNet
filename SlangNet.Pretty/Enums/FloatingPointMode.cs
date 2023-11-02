using static SlangNet.Unsafe.SlangFloatingPointMode;

namespace SlangNet;

public enum FloatingPointMode : uint
{
    Default = SLANG_FLOATING_POINT_MODE_DEFAULT,
    Fast = SLANG_FLOATING_POINT_MODE_FAST,
    Precise = SLANG_FLOATING_POINT_MODE_PRECISE
}
