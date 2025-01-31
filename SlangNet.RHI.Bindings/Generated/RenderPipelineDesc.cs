namespace SlangNet.RHI.Unsafe;

/// <include file='RenderPipelineDesc.xml' path='doc/member[@name="RenderPipelineDesc"]/*' />
public unsafe partial struct RenderPipelineDesc
{
    /// <include file='RenderPipelineDesc.xml' path='doc/member[@name="RenderPipelineDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='RenderPipelineDesc.xml' path='doc/member[@name="RenderPipelineDesc.next"]/*' />
    public void* next;

    /// <include file='RenderPipelineDesc.xml' path='doc/member[@name="RenderPipelineDesc.program"]/*' />
    [NativeTypeName("rhi::IShaderProgram *")]
    public IShaderProgram* program;

    /// <include file='RenderPipelineDesc.xml' path='doc/member[@name="RenderPipelineDesc.inputLayout"]/*' />
    [NativeTypeName("rhi::IInputLayout *")]
    public IInputLayout* inputLayout;

    /// <include file='RenderPipelineDesc.xml' path='doc/member[@name="RenderPipelineDesc.primitiveTopology"]/*' />
    [NativeTypeName("rhi::PrimitiveTopology")]
    public PrimitiveTopology primitiveTopology;

    /// <include file='RenderPipelineDesc.xml' path='doc/member[@name="RenderPipelineDesc.targets"]/*' />
    [NativeTypeName("rhi::ColorTargetState *")]
    public ColorTargetState* targets;

    /// <include file='RenderPipelineDesc.xml' path='doc/member[@name="RenderPipelineDesc.targetCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint targetCount;

    /// <include file='RenderPipelineDesc.xml' path='doc/member[@name="RenderPipelineDesc.depthStencil"]/*' />
    [NativeTypeName("rhi::DepthStencilState")]
    public DepthStencilState depthStencil;

    /// <include file='RenderPipelineDesc.xml' path='doc/member[@name="RenderPipelineDesc.rasterizer"]/*' />
    [NativeTypeName("rhi::RasterizerDesc")]
    public RasterizerDesc rasterizer;

    /// <include file='RenderPipelineDesc.xml' path='doc/member[@name="RenderPipelineDesc.multisample"]/*' />
    [NativeTypeName("rhi::MultisampleState")]
    public MultisampleState multisample;
}
