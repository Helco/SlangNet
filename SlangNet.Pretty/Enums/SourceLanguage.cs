﻿using static SlangNet.Unsafe.SlangSourceLanguage;

namespace SlangNet;

public enum SourceLanguage
{
    Unknown = SLANG_SOURCE_LANGUAGE_UNKNOWN,
    Slang = SLANG_SOURCE_LANGUAGE_SLANG,
    HLSL = SLANG_SOURCE_LANGUAGE_HLSL,
    GLSL = SLANG_SOURCE_LANGUAGE_GLSL,
    C = SLANG_SOURCE_LANGUAGE_C,
    Cpp = SLANG_SOURCE_LANGUAGE_CPP,
    CUDA = SLANG_SOURCE_LANGUAGE_CUDA,
    SPIRV = SLANG_SOURCE_LANGUAGE_SPIRV,
}
