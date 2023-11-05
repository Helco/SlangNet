using static SlangNet.Unsafe.SlangTypeKind;
using static SlangNet.Unsafe.SlangScalarType;

namespace SlangNet;

// outside of TypeReflection to prevent name conflicts

public enum TypeKind : uint
{
    None = SLANG_TYPE_KIND_NONE,
    Struct = SLANG_TYPE_KIND_STRUCT,
    Array = SLANG_TYPE_KIND_ARRAY,
    Matrix = SLANG_TYPE_KIND_MATRIX,
    Vector = SLANG_TYPE_KIND_VECTOR,
    Scalar = SLANG_TYPE_KIND_SCALAR,
    ConstantBuffer = SLANG_TYPE_KIND_CONSTANT_BUFFER,
    Resource = SLANG_TYPE_KIND_RESOURCE,
    SamplerState = SLANG_TYPE_KIND_SAMPLER_STATE,
    TextureBuffer = SLANG_TYPE_KIND_TEXTURE_BUFFER,
    ShaderStorageBuffer = SLANG_TYPE_KIND_SHADER_STORAGE_BUFFER,
    ParameterBlock = SLANG_TYPE_KIND_PARAMETER_BLOCK,
    GenericTypeParameter = SLANG_TYPE_KIND_GENERIC_TYPE_PARAMETER,
    Interface = SLANG_TYPE_KIND_INTERFACE,
    OutputStream = SLANG_TYPE_KIND_OUTPUT_STREAM,
    Specialized = SLANG_TYPE_KIND_SPECIALIZED,
    Feedback = SLANG_TYPE_KIND_FEEDBACK,
    Pointer = SLANG_TYPE_KIND_POINTER,
}

public enum ScalarType : uint
{
    None = SLANG_SCALAR_TYPE_NONE,
    Void = SLANG_SCALAR_TYPE_VOID,
    Bool = SLANG_SCALAR_TYPE_BOOL,
    Int32 = SLANG_SCALAR_TYPE_INT32,
    UInt32 = SLANG_SCALAR_TYPE_UINT32,
    Int64 = SLANG_SCALAR_TYPE_INT64,
    UInt64 = SLANG_SCALAR_TYPE_UINT64,
    Float16 = SLANG_SCALAR_TYPE_FLOAT16,
    Float32 = SLANG_SCALAR_TYPE_FLOAT32,
    Float64 = SLANG_SCALAR_TYPE_FLOAT64,
    Int8 = SLANG_SCALAR_TYPE_INT8,
    UInt8 = SLANG_SCALAR_TYPE_UINT8,
    Int16 = SLANG_SCALAR_TYPE_INT16,
    UInt16 = SLANG_SCALAR_TYPE_UINT16,
}
