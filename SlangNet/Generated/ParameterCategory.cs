using static SlangNet.SlangParameterCategory;

namespace SlangNet;

/// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory"]/*' />
[NativeTypeName("SlangParameterCategoryIntegral")]
public enum ParameterCategory : uint
{
    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.None"]/*' />
    None = SLANG_PARAMETER_CATEGORY_NONE,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.Mixed"]/*' />
    Mixed = SLANG_PARAMETER_CATEGORY_MIXED,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.ConstantBuffer"]/*' />
    ConstantBuffer = SLANG_PARAMETER_CATEGORY_CONSTANT_BUFFER,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.ShaderResource"]/*' />
    ShaderResource = SLANG_PARAMETER_CATEGORY_SHADER_RESOURCE,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.UnorderedAccess"]/*' />
    UnorderedAccess = SLANG_PARAMETER_CATEGORY_UNORDERED_ACCESS,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.VaryingInput"]/*' />
    VaryingInput = SLANG_PARAMETER_CATEGORY_VARYING_INPUT,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.VaryingOutput"]/*' />
    VaryingOutput = SLANG_PARAMETER_CATEGORY_VARYING_OUTPUT,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.SamplerState"]/*' />
    SamplerState = SLANG_PARAMETER_CATEGORY_SAMPLER_STATE,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.Uniform"]/*' />
    Uniform = SLANG_PARAMETER_CATEGORY_UNIFORM,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.DescriptorTableSlot"]/*' />
    DescriptorTableSlot = SLANG_PARAMETER_CATEGORY_DESCRIPTOR_TABLE_SLOT,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.SpecializationConstant"]/*' />
    SpecializationConstant = SLANG_PARAMETER_CATEGORY_SPECIALIZATION_CONSTANT,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.PushConstantBuffer"]/*' />
    PushConstantBuffer = SLANG_PARAMETER_CATEGORY_PUSH_CONSTANT_BUFFER,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.RegisterSpace"]/*' />
    RegisterSpace = SLANG_PARAMETER_CATEGORY_REGISTER_SPACE,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.GenericResource"]/*' />
    GenericResource = SLANG_PARAMETER_CATEGORY_GENERIC,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.RayPayload"]/*' />
    RayPayload = SLANG_PARAMETER_CATEGORY_RAY_PAYLOAD,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.HitAttributes"]/*' />
    HitAttributes = SLANG_PARAMETER_CATEGORY_HIT_ATTRIBUTES,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.CallablePayload"]/*' />
    CallablePayload = SLANG_PARAMETER_CATEGORY_CALLABLE_PAYLOAD,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.ShaderRecord"]/*' />
    ShaderRecord = SLANG_PARAMETER_CATEGORY_SHADER_RECORD,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.ExistentialTypeParam"]/*' />
    ExistentialTypeParam = SLANG_PARAMETER_CATEGORY_EXISTENTIAL_TYPE_PARAM,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.ExistentialObjectParam"]/*' />
    ExistentialObjectParam = SLANG_PARAMETER_CATEGORY_EXISTENTIAL_OBJECT_PARAM,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.VertexInput"]/*' />
    VertexInput = SLANG_PARAMETER_CATEGORY_VERTEX_INPUT,

    /// <include file='ParameterCategory.xml' path='doc/member[@name="ParameterCategory.FragmentOutput"]/*' />
    FragmentOutput = SLANG_PARAMETER_CATEGORY_FRAGMENT_OUTPUT,
}
