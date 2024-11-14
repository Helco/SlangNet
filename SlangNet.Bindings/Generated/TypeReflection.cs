using static SlangNet.Unsafe.SlangScalarType;
using static SlangNet.Unsafe.SlangTypeKind;

namespace SlangNet.Unsafe;

/// <include file='TypeReflection.xml' path='doc/member[@name="TypeReflection"]/*' />
public partial struct TypeReflection
{

    /// <include file='Kind.xml' path='doc/member[@name="Kind"]/*' />
    [NativeTypeName("int")]
    public enum Kind : uint
    {
        /// <include file='Kind.xml' path='doc/member[@name="Kind.None"]/*' />
        None = SLANG_TYPE_KIND_NONE,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Struct"]/*' />
        Struct = SLANG_TYPE_KIND_STRUCT,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Array"]/*' />
        Array = SLANG_TYPE_KIND_ARRAY,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Matrix"]/*' />
        Matrix = SLANG_TYPE_KIND_MATRIX,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Vector"]/*' />
        Vector = SLANG_TYPE_KIND_VECTOR,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Scalar"]/*' />
        Scalar = SLANG_TYPE_KIND_SCALAR,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.ConstantBuffer"]/*' />
        ConstantBuffer = SLANG_TYPE_KIND_CONSTANT_BUFFER,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Resource"]/*' />
        Resource = SLANG_TYPE_KIND_RESOURCE,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.SamplerState"]/*' />
        SamplerState = SLANG_TYPE_KIND_SAMPLER_STATE,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.TextureBuffer"]/*' />
        TextureBuffer = SLANG_TYPE_KIND_TEXTURE_BUFFER,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.ShaderStorageBuffer"]/*' />
        ShaderStorageBuffer = SLANG_TYPE_KIND_SHADER_STORAGE_BUFFER,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.ParameterBlock"]/*' />
        ParameterBlock = SLANG_TYPE_KIND_PARAMETER_BLOCK,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.GenericTypeParameter"]/*' />
        GenericTypeParameter = SLANG_TYPE_KIND_GENERIC_TYPE_PARAMETER,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Interface"]/*' />
        Interface = SLANG_TYPE_KIND_INTERFACE,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.OutputStream"]/*' />
        OutputStream = SLANG_TYPE_KIND_OUTPUT_STREAM,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Specialized"]/*' />
        Specialized = SLANG_TYPE_KIND_SPECIALIZED,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Feedback"]/*' />
        Feedback = SLANG_TYPE_KIND_FEEDBACK,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Pointer"]/*' />
        Pointer = SLANG_TYPE_KIND_POINTER,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.DynamicResource"]/*' />
        DynamicResource = SLANG_TYPE_KIND_DYNAMIC_RESOURCE,
    }

    /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType"]/*' />
    [NativeTypeName("SlangScalarTypeIntegral")]
    public enum ScalarType : uint
    {
        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.None"]/*' />
        None = SLANG_SCALAR_TYPE_NONE,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.Void"]/*' />
        Void = SLANG_SCALAR_TYPE_VOID,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.Bool"]/*' />
        Bool = SLANG_SCALAR_TYPE_BOOL,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.Int32"]/*' />
        Int32 = SLANG_SCALAR_TYPE_INT32,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.UInt32"]/*' />
        UInt32 = SLANG_SCALAR_TYPE_UINT32,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.Int64"]/*' />
        Int64 = SLANG_SCALAR_TYPE_INT64,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.UInt64"]/*' />
        UInt64 = SLANG_SCALAR_TYPE_UINT64,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.Float16"]/*' />
        Float16 = SLANG_SCALAR_TYPE_FLOAT16,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.Float32"]/*' />
        Float32 = SLANG_SCALAR_TYPE_FLOAT32,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.Float64"]/*' />
        Float64 = SLANG_SCALAR_TYPE_FLOAT64,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.Int8"]/*' />
        Int8 = SLANG_SCALAR_TYPE_INT8,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.UInt8"]/*' />
        UInt8 = SLANG_SCALAR_TYPE_UINT8,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.Int16"]/*' />
        Int16 = SLANG_SCALAR_TYPE_INT16,

        /// <include file='ScalarType.xml' path='doc/member[@name="ScalarType.UInt16"]/*' />
        UInt16 = SLANG_SCALAR_TYPE_UINT16,
    }
}
