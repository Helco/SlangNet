using SlangNet.Unsafe;
using static SlangNet.SlangBindingType;

namespace SlangNet # enums with duplicated declarations;

/// <include file='BindingType.xml' path='doc/member[@name="BindingType"]/*' />
[NativeTypeName("SlangBindingTypeIntegral")]
public enum BindingType : uint
{
    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.Unknown"]/*' />
    Unknown = SLANG_BINDING_TYPE_UNKNOWN,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.Sampler"]/*' />
    Sampler = SLANG_BINDING_TYPE_SAMPLER,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.Texture"]/*' />
    Texture = SLANG_BINDING_TYPE_TEXTURE,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.ConstantBuffer"]/*' />
    ConstantBuffer = SLANG_BINDING_TYPE_CONSTANT_BUFFER,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.ParameterBlock"]/*' />
    ParameterBlock = SLANG_BINDING_TYPE_PARAMETER_BLOCK,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.TypedBuffer"]/*' />
    TypedBuffer = SLANG_BINDING_TYPE_TYPED_BUFFER,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.RawBuffer"]/*' />
    RawBuffer = SLANG_BINDING_TYPE_RAW_BUFFER,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.CombinedTextureSampler"]/*' />
    CombinedTextureSampler = SLANG_BINDING_TYPE_COMBINED_TEXTURE_SAMPLER,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.InputRenderTarget"]/*' />
    InputRenderTarget = SLANG_BINDING_TYPE_INPUT_RENDER_TARGET,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.InlineUniformData"]/*' />
    InlineUniformData = SLANG_BINDING_TYPE_INLINE_UNIFORM_DATA,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.RayTracingAccelerationStructure"]/*' />
    RayTracingAccelerationStructure = SLANG_BINDING_TYPE_RAY_TRACING_ACCELERATION_STRUCTURE,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.VaryingInput"]/*' />
    VaryingInput = SLANG_BINDING_TYPE_VARYING_INPUT,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.VaryingOutput"]/*' />
    VaryingOutput = SLANG_BINDING_TYPE_VARYING_OUTPUT,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.ExistentialValue"]/*' />
    ExistentialValue = SLANG_BINDING_TYPE_EXISTENTIAL_VALUE,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.PushConstant"]/*' />
    PushConstant = SLANG_BINDING_TYPE_PUSH_CONSTANT,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.MutableFlag"]/*' />
    MutableFlag = SLANG_BINDING_TYPE_MUTABLE_FLAG,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.MutableTexture"]/*' />
    MutableTexture = SLANG_BINDING_TYPE_MUTABLE_TETURE,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.MutableTypedBuffer"]/*' />
    MutableTypedBuffer = SLANG_BINDING_TYPE_MUTABLE_TYPED_BUFFER,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.MutableRawBuffer"]/*' />
    MutableRawBuffer = SLANG_BINDING_TYPE_MUTABLE_RAW_BUFFER,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.BaseMask"]/*' />
    BaseMask = SLANG_BINDING_TYPE_BASE_MASK,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.ExtMask"]/*' />
    ExtMask = SLANG_BINDING_TYPE_EXT_MASK,
}
