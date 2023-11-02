using System;
using static SlangNet.Unsafe.Slang;

namespace SlangNet;

[Flags]
public enum TargetFlags
{
    ParameterBlocksUseRegisterSpaces = SLANG_TARGET_FLAG_PARAMETER_BLOCKS_USE_REGISTER_SPACES,
    GenerateWholeProgram = SLANG_TARGET_FLAG_GENERATE_WHOLE_PROGRAM,
    DumpIR = SLANG_TARGET_FLAG_DUMP_IR,
    GenerateSPIRVDirectly = SLANG_TARGET_FLAG_GENERATE_SPIRV_DIRECTLY
}
