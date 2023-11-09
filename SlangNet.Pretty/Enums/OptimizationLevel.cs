using static SlangNet.Unsafe.SlangOptimizationLevel;

namespace SlangNet;

public enum OptimizationLevel : uint
{
    None = SLANG_OPTIMIZATION_LEVEL_NONE,
    Default = SLANG_OPTIMIZATION_LEVEL_DEFAULT,
    High = SLANG_OPTIMIZATION_LEVEL_HIGH,
    Maximal = SLANG_OPTIMIZATION_LEVEL_MAXIMAL
}
