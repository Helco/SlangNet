namespace SlangNet.RHI.Unsafe;

/// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc"]/*' />
public unsafe partial struct RayTracingPipelineDesc
{
    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.next"]/*' />
    public void* next;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.program"]/*' />
    [NativeTypeName("rhi::IShaderProgram *")]
    public IShaderProgram* program;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.hitGroupCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint hitGroupCount;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.hitGroups"]/*' />
    [NativeTypeName("rhi::HitGroupDesc *")]
    public HitGroupDesc* hitGroups;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.maxRecursion"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxRecursion;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.maxRayPayloadSize"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxRayPayloadSize;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.maxAttributeSizeInBytes"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxAttributeSizeInBytes;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.flags"]/*' />
    [NativeTypeName("rhi::RayTracingPipelineFlags")]
    public RayTracingPipelineFlags flags;
}
