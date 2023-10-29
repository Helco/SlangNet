namespace SlangNet;

/// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType"]/*' />
[NativeTypeName("SlangBindingTypeIntegral")]
public enum SlangBindingType : uint
{
    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_UNKNOWN"]/*' />
    SLANG_BINDING_TYPE_UNKNOWN = 0,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_SAMPLER"]/*' />
    SLANG_BINDING_TYPE_SAMPLER,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_TEXTURE"]/*' />
    SLANG_BINDING_TYPE_TEXTURE,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_CONSTANT_BUFFER"]/*' />
    SLANG_BINDING_TYPE_CONSTANT_BUFFER,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_PARAMETER_BLOCK"]/*' />
    SLANG_BINDING_TYPE_PARAMETER_BLOCK,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_TYPED_BUFFER"]/*' />
    SLANG_BINDING_TYPE_TYPED_BUFFER,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_RAW_BUFFER"]/*' />
    SLANG_BINDING_TYPE_RAW_BUFFER,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_COMBINED_TEXTURE_SAMPLER"]/*' />
    SLANG_BINDING_TYPE_COMBINED_TEXTURE_SAMPLER,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_INPUT_RENDER_TARGET"]/*' />
    SLANG_BINDING_TYPE_INPUT_RENDER_TARGET,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_INLINE_UNIFORM_DATA"]/*' />
    SLANG_BINDING_TYPE_INLINE_UNIFORM_DATA,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_RAY_TRACING_ACCELERATION_STRUCTURE"]/*' />
    SLANG_BINDING_TYPE_RAY_TRACING_ACCELERATION_STRUCTURE,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_VARYING_INPUT"]/*' />
    SLANG_BINDING_TYPE_VARYING_INPUT,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_VARYING_OUTPUT"]/*' />
    SLANG_BINDING_TYPE_VARYING_OUTPUT,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_EXISTENTIAL_VALUE"]/*' />
    SLANG_BINDING_TYPE_EXISTENTIAL_VALUE,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_PUSH_CONSTANT"]/*' />
    SLANG_BINDING_TYPE_PUSH_CONSTANT,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_MUTABLE_FLAG"]/*' />
    SLANG_BINDING_TYPE_MUTABLE_FLAG = 0x100,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_MUTABLE_TETURE"]/*' />
    SLANG_BINDING_TYPE_MUTABLE_TETURE = SLANG_BINDING_TYPE_TEXTURE | SLANG_BINDING_TYPE_MUTABLE_FLAG,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_MUTABLE_TYPED_BUFFER"]/*' />
    SLANG_BINDING_TYPE_MUTABLE_TYPED_BUFFER = SLANG_BINDING_TYPE_TYPED_BUFFER | SLANG_BINDING_TYPE_MUTABLE_FLAG,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_MUTABLE_RAW_BUFFER"]/*' />
    SLANG_BINDING_TYPE_MUTABLE_RAW_BUFFER = SLANG_BINDING_TYPE_RAW_BUFFER | SLANG_BINDING_TYPE_MUTABLE_FLAG,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_BASE_MASK"]/*' />
    SLANG_BINDING_TYPE_BASE_MASK = 0x00FF,

    /// <include file='SlangBindingType.xml' path='doc/member[@name="SlangBindingType.SLANG_BINDING_TYPE_EXT_MASK"]/*' />
    SLANG_BINDING_TYPE_EXT_MASK = 0xFF00,
}
