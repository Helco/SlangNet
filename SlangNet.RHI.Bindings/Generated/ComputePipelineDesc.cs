namespace SlangNet.RHI.Unsafe;

/// <include file='ComputePipelineDesc.xml' path='doc/member[@name="ComputePipelineDesc"]/*' />
public unsafe partial struct ComputePipelineDesc
{
    /// <include file='ComputePipelineDesc.xml' path='doc/member[@name="ComputePipelineDesc.program"]/*' />
    [NativeTypeName("rhi::IShaderProgram *")]
    public IShaderProgram* program;

    /// <include file='ComputePipelineDesc.xml' path='doc/member[@name="ComputePipelineDesc.d3d12RootSignatureOverride"]/*' />
    public void* d3d12RootSignatureOverride;
}
