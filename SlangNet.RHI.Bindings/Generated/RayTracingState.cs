namespace SlangNet.RHI.Unsafe;

/// <include file='RayTracingState.xml' path='doc/member[@name="RayTracingState"]/*' />
public unsafe partial struct RayTracingState
{
    /// <include file='RayTracingState.xml' path='doc/member[@name="RayTracingState.pipeline"]/*' />
    [NativeTypeName("rhi::IRayTracingPipeline *")]
    public IRayTracingPipeline* pipeline;

    /// <include file='RayTracingState.xml' path='doc/member[@name="RayTracingState.shaderTable"]/*' />
    [NativeTypeName("rhi::IShaderTable *")]
    public IShaderTable* shaderTable;

    /// <include file='RayTracingState.xml' path='doc/member[@name="RayTracingState.rootObject"]/*' />
    [NativeTypeName("rhi::IShaderObject *")]
    public IShaderObject* rootObject;
}
