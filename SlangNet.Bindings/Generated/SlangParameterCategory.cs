using SlangNet.Unsafe;

namespace SlangNet;

/// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory"]/*' />
[NativeTypeName("SlangParameterCategoryIntegral")]
public enum SlangParameterCategory : uint
{
    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_NONE"]/*' />
    SLANG_PARAMETER_CATEGORY_NONE,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_MIXED"]/*' />
    SLANG_PARAMETER_CATEGORY_MIXED,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_CONSTANT_BUFFER"]/*' />
    SLANG_PARAMETER_CATEGORY_CONSTANT_BUFFER,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_SHADER_RESOURCE"]/*' />
    SLANG_PARAMETER_CATEGORY_SHADER_RESOURCE,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_UNORDERED_ACCESS"]/*' />
    SLANG_PARAMETER_CATEGORY_UNORDERED_ACCESS,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_VARYING_INPUT"]/*' />
    SLANG_PARAMETER_CATEGORY_VARYING_INPUT,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_VARYING_OUTPUT"]/*' />
    SLANG_PARAMETER_CATEGORY_VARYING_OUTPUT,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_SAMPLER_STATE"]/*' />
    SLANG_PARAMETER_CATEGORY_SAMPLER_STATE,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_UNIFORM"]/*' />
    SLANG_PARAMETER_CATEGORY_UNIFORM,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_DESCRIPTOR_TABLE_SLOT"]/*' />
    SLANG_PARAMETER_CATEGORY_DESCRIPTOR_TABLE_SLOT,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_SPECIALIZATION_CONSTANT"]/*' />
    SLANG_PARAMETER_CATEGORY_SPECIALIZATION_CONSTANT,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_PUSH_CONSTANT_BUFFER"]/*' />
    SLANG_PARAMETER_CATEGORY_PUSH_CONSTANT_BUFFER,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_REGISTER_SPACE"]/*' />
    SLANG_PARAMETER_CATEGORY_REGISTER_SPACE,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_GENERIC"]/*' />
    SLANG_PARAMETER_CATEGORY_GENERIC,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_RAY_PAYLOAD"]/*' />
    SLANG_PARAMETER_CATEGORY_RAY_PAYLOAD,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_HIT_ATTRIBUTES"]/*' />
    SLANG_PARAMETER_CATEGORY_HIT_ATTRIBUTES,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_CALLABLE_PAYLOAD"]/*' />
    SLANG_PARAMETER_CATEGORY_CALLABLE_PAYLOAD,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_SHADER_RECORD"]/*' />
    SLANG_PARAMETER_CATEGORY_SHADER_RECORD,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_EXISTENTIAL_TYPE_PARAM"]/*' />
    SLANG_PARAMETER_CATEGORY_EXISTENTIAL_TYPE_PARAM,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_EXISTENTIAL_OBJECT_PARAM"]/*' />
    SLANG_PARAMETER_CATEGORY_EXISTENTIAL_OBJECT_PARAM,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_COUNT"]/*' />
    SLANG_PARAMETER_CATEGORY_COUNT,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_VERTEX_INPUT"]/*' />
    SLANG_PARAMETER_CATEGORY_VERTEX_INPUT = SLANG_PARAMETER_CATEGORY_VARYING_INPUT,

    /// <include file='SlangParameterCategory.xml' path='doc/member[@name="SlangParameterCategory.SLANG_PARAMETER_CATEGORY_FRAGMENT_OUTPUT"]/*' />
    SLANG_PARAMETER_CATEGORY_FRAGMENT_OUTPUT = SLANG_PARAMETER_CATEGORY_VARYING_OUTPUT,
}
