using System;
using static SlangNet.Unsafe.SlangResourceShape;

namespace SlangNet;

[Flags]
public enum ResourceShape : uint
{
    ResourceBaseShapeMask = SLANG_RESOURCE_BASE_SHAPE_MASK,

    None = SLANG_RESOURCE_NONE,
    Texture1D = SLANG_TEXTURE_1D,
    Texture2D = SLANG_TEXTURE_2D,
    Texture3D = SLANG_TEXTURE_3D,
    TextureCube = SLANG_TEXTURE_CUBE,
    TextureBuffer = SLANG_TEXTURE_BUFFER,
    StructuredBuffer = SLANG_STRUCTURED_BUFFER,
    ByteAddressBuffer = SLANG_BYTE_ADDRESS_BUFFER,
    Unknown = SLANG_RESOURCE_UNKNOWN,
    AccelerationStructure = SLANG_ACCELERATION_STRUCTURE,

    ExtShapeMask = SLANG_RESOURCE_EXT_SHAPE_MASK,
    TextureFeedbackFlag = SLANG_TEXTURE_FEEDBACK_FLAG,
    TextureArrayFlag = SLANG_TEXTURE_ARRAY_FLAG,
    TextureMultisampleFlag = SLANG_TEXTURE_MULTISAMPLE_FLAG,

    Texture1DArray = SLANG_TEXTURE_1D_ARRAY,
    Texture2DArray = SLANG_TEXTURE_2D_ARRAY,
    TextureCubeArray = SLANG_TEXTURE_CUBE_ARRAY,
    Texture2DMultisample = SLANG_TEXTURE_2D_MULTISAMPLE,
    Texture2DMultisampleArray = SLANG_TEXTURE_2D_MULTISAMPLE_ARRAY
}
