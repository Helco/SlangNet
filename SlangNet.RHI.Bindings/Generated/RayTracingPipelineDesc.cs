namespace SlangNet.RHI.Unsafe;

/// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc"]/*' />
public unsafe partial struct RayTracingPipelineDesc
{
    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.program"]/*' />
    [NativeTypeName("rhi::IShaderProgram *")]
    public IShaderProgram* program;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.hitGroupCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int hitGroupCount;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.hitGroups"]/*' />
    [NativeTypeName("rhi::HitGroupDesc *")]
    public HitGroupDesc* hitGroups;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.maxRecursion"]/*' />
    public int maxRecursion;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.maxRayPayloadSize"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong maxRayPayloadSize;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.maxAttributeSizeInBytes"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong maxAttributeSizeInBytes;

    /// <include file='RayTracingPipelineDesc.xml' path='doc/member[@name="RayTracingPipelineDesc.flags"]/*' />
    [NativeTypeName("rhi::RayTracingPipelineFlags")]
    public RayTracingPipelineFlags flags;
}
