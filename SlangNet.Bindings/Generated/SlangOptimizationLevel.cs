using SlangNet.Unsafe;

namespace SlangNet;

/// <include file='SlangOptimizationLevel.xml' path='doc/member[@name="SlangOptimizationLevel"]/*' />
[NativeTypeName("SlangOptimizationLevelIntegral")]
public enum SlangOptimizationLevel : uint
{
    /// <include file='SlangOptimizationLevel.xml' path='doc/member[@name="SlangOptimizationLevel.SLANG_OPTIMIZATION_LEVEL_NONE"]/*' />
    SLANG_OPTIMIZATION_LEVEL_NONE = 0,

    /// <include file='SlangOptimizationLevel.xml' path='doc/member[@name="SlangOptimizationLevel.SLANG_OPTIMIZATION_LEVEL_DEFAULT"]/*' />
    SLANG_OPTIMIZATION_LEVEL_DEFAULT,

    /// <include file='SlangOptimizationLevel.xml' path='doc/member[@name="SlangOptimizationLevel.SLANG_OPTIMIZATION_LEVEL_HIGH"]/*' />
    SLANG_OPTIMIZATION_LEVEL_HIGH,

    /// <include file='SlangOptimizationLevel.xml' path='doc/member[@name="SlangOptimizationLevel.SLANG_OPTIMIZATION_LEVEL_MAXIMAL"]/*' />
    SLANG_OPTIMIZATION_LEVEL_MAXIMAL,
}
