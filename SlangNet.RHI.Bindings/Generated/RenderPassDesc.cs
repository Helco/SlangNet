namespace SlangNet.RHI.Unsafe;

/// <include file='RenderPassDesc.xml' path='doc/member[@name="RenderPassDesc"]/*' />
public unsafe partial struct RenderPassDesc
{
    /// <include file='RenderPassDesc.xml' path='doc/member[@name="RenderPassDesc.colorAttachments"]/*' />
    [NativeTypeName("const RenderPassColorAttachment *")]
    public RenderPassColorAttachment* colorAttachments;

    /// <include file='RenderPassDesc.xml' path='doc/member[@name="RenderPassDesc.colorAttachmentCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint colorAttachmentCount;

    /// <include file='RenderPassDesc.xml' path='doc/member[@name="RenderPassDesc.depthStencilAttachment"]/*' />
    [NativeTypeName("const RenderPassDepthStencilAttachment *")]
    public RenderPassDepthStencilAttachment* depthStencilAttachment;
}
