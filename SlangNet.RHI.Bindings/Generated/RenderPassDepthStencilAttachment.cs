namespace SlangNet.RHI.Unsafe;

/// <include file='RenderPassDepthStencilAttachment.xml' path='doc/member[@name="RenderPassDepthStencilAttachment"]/*' />
public unsafe partial struct RenderPassDepthStencilAttachment
{
    /// <include file='RenderPassDepthStencilAttachment.xml' path='doc/member[@name="RenderPassDepthStencilAttachment.view"]/*' />
    [NativeTypeName("rhi::ITextureView *")]
    public ITextureView* view;

    /// <include file='RenderPassDepthStencilAttachment.xml' path='doc/member[@name="RenderPassDepthStencilAttachment.depthLoadOp"]/*' />
    [NativeTypeName("rhi::LoadOp")]
    public LoadOp depthLoadOp;

    /// <include file='RenderPassDepthStencilAttachment.xml' path='doc/member[@name="RenderPassDepthStencilAttachment.depthStoreOp"]/*' />
    [NativeTypeName("rhi::StoreOp")]
    public StoreOp depthStoreOp;

    /// <include file='RenderPassDepthStencilAttachment.xml' path='doc/member[@name="RenderPassDepthStencilAttachment.depthClearValue"]/*' />
    public float depthClearValue;

    /// <include file='RenderPassDepthStencilAttachment.xml' path='doc/member[@name="RenderPassDepthStencilAttachment.depthReadOnly"]/*' />
    public bool depthReadOnly;

    /// <include file='RenderPassDepthStencilAttachment.xml' path='doc/member[@name="RenderPassDepthStencilAttachment.stencilLoadOp"]/*' />
    [NativeTypeName("rhi::LoadOp")]
    public LoadOp stencilLoadOp;

    /// <include file='RenderPassDepthStencilAttachment.xml' path='doc/member[@name="RenderPassDepthStencilAttachment.stencilStoreOp"]/*' />
    [NativeTypeName("rhi::StoreOp")]
    public StoreOp stencilStoreOp;

    /// <include file='RenderPassDepthStencilAttachment.xml' path='doc/member[@name="RenderPassDepthStencilAttachment.stencilClearValue"]/*' />
    [NativeTypeName("uint8_t")]
    public byte stencilClearValue;

    /// <include file='RenderPassDepthStencilAttachment.xml' path='doc/member[@name="RenderPassDepthStencilAttachment.stencilReadOnly"]/*' />
    public bool stencilReadOnly;
}
