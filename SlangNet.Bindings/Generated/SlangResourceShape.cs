using SlangNet.Unsafe;

namespace SlangNet;

/// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape"]/*' />
[NativeTypeName("SlangResourceShapeIntegral")]
public enum SlangResourceShape : uint
{
    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_RESOURCE_BASE_SHAPE_MASK"]/*' />
    SLANG_RESOURCE_BASE_SHAPE_MASK = 0x0F,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_RESOURCE_NONE"]/*' />
    SLANG_RESOURCE_NONE = 0x00,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_1D"]/*' />
    SLANG_TEXTURE_1D = 0x01,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_2D"]/*' />
    SLANG_TEXTURE_2D = 0x02,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_3D"]/*' />
    SLANG_TEXTURE_3D = 0x03,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_CUBE"]/*' />
    SLANG_TEXTURE_CUBE = 0x04,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_BUFFER"]/*' />
    SLANG_TEXTURE_BUFFER = 0x05,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_STRUCTURED_BUFFER"]/*' />
    SLANG_STRUCTURED_BUFFER = 0x06,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_BYTE_ADDRESS_BUFFER"]/*' />
    SLANG_BYTE_ADDRESS_BUFFER = 0x07,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_RESOURCE_UNKNOWN"]/*' />
    SLANG_RESOURCE_UNKNOWN = 0x08,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_ACCELERATION_STRUCTURE"]/*' />
    SLANG_ACCELERATION_STRUCTURE = 0x09,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_RESOURCE_EXT_SHAPE_MASK"]/*' />
    SLANG_RESOURCE_EXT_SHAPE_MASK = 0xF0,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_FEEDBACK_FLAG"]/*' />
    SLANG_TEXTURE_FEEDBACK_FLAG = 0x10,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_ARRAY_FLAG"]/*' />
    SLANG_TEXTURE_ARRAY_FLAG = 0x40,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_MULTISAMPLE_FLAG"]/*' />
    SLANG_TEXTURE_MULTISAMPLE_FLAG = 0x80,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_1D_ARRAY"]/*' />
    SLANG_TEXTURE_1D_ARRAY = SLANG_TEXTURE_1D | SLANG_TEXTURE_ARRAY_FLAG,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_2D_ARRAY"]/*' />
    SLANG_TEXTURE_2D_ARRAY = SLANG_TEXTURE_2D | SLANG_TEXTURE_ARRAY_FLAG,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_CUBE_ARRAY"]/*' />
    SLANG_TEXTURE_CUBE_ARRAY = SLANG_TEXTURE_CUBE | SLANG_TEXTURE_ARRAY_FLAG,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_2D_MULTISAMPLE"]/*' />
    SLANG_TEXTURE_2D_MULTISAMPLE = SLANG_TEXTURE_2D | SLANG_TEXTURE_MULTISAMPLE_FLAG,

    /// <include file='SlangResourceShape.xml' path='doc/member[@name="SlangResourceShape.SLANG_TEXTURE_2D_MULTISAMPLE_ARRAY"]/*' />
    SLANG_TEXTURE_2D_MULTISAMPLE_ARRAY = SLANG_TEXTURE_2D | SLANG_TEXTURE_MULTISAMPLE_FLAG | SLANG_TEXTURE_ARRAY_FLAG,
}
