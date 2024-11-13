namespace SlangNet.RHI.Unsafe;

/// <include file='ComputeState.xml' path='doc/member[@name="ComputeState"]/*' />
public unsafe partial struct ComputeState
{
    /// <include file='ComputeState.xml' path='doc/member[@name="ComputeState.pipeline"]/*' />
    [NativeTypeName("rhi::IComputePipeline *")]
    public IComputePipeline* pipeline;

    /// <include file='ComputeState.xml' path='doc/member[@name="ComputeState.rootObject"]/*' />
    [NativeTypeName("rhi::IShaderObject *")]
    public IShaderObject* rootObject;
}
