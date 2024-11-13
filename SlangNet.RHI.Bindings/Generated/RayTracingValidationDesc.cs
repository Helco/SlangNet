namespace SlangNet.RHI.Unsafe;

/// <include file='RayTracingValidationDesc.xml' path='doc/member[@name="RayTracingValidationDesc"]/*' />
public partial struct RayTracingValidationDesc
{
    /// <include file='RayTracingValidationDesc.xml' path='doc/member[@name="RayTracingValidationDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='RayTracingValidationDesc.xml' path='doc/member[@name="RayTracingValidationDesc.enableRaytracingValidation"]/*' />
    public bool enableRaytracingValidation;
}
