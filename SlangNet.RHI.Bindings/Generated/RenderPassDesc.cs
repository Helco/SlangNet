namespace SlangNet.RHI.Unsafe;

/// <include file='RenderPassDesc.xml' path='doc/member[@name="RenderPassDesc"]/*' />
public unsafe partial struct RenderPassDesc
{
    /// <include file='RenderPassDesc.xml' path='doc/member[@name="RenderPassDesc.colorAttachments"]/*' />
    [NativeTypeName("rhi::RenderPassColorAttachment *")]
    public RenderPassColorAttachment* colorAttachments;

    /// <include file='RenderPassDesc.xml' path='doc/member[@name="RenderPassDesc.colorAttachmentCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int colorAttachmentCount;

    /// <include file='RenderPassDesc.xml' path='doc/member[@name="RenderPassDesc.depthStencilAttachment"]/*' />
    [NativeTypeName("rhi::RenderPassDepthStencilAttachment *")]
    public RenderPassDepthStencilAttachment* depthStencilAttachment;
}
