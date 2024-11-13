namespace SlangNet.RHI.Unsafe;

/// <include file='RenderPassColorAttachment.xml' path='doc/member[@name="RenderPassColorAttachment"]/*' />
public unsafe partial struct RenderPassColorAttachment
{
    /// <include file='RenderPassColorAttachment.xml' path='doc/member[@name="RenderPassColorAttachment.view"]/*' />
    [NativeTypeName("rhi::ITextureView *")]
    public ITextureView* view;

    /// <include file='RenderPassColorAttachment.xml' path='doc/member[@name="RenderPassColorAttachment.resolveTarget"]/*' />
    [NativeTypeName("rhi::ITextureView *")]
    public ITextureView* resolveTarget;

    /// <include file='RenderPassColorAttachment.xml' path='doc/member[@name="RenderPassColorAttachment.loadOp"]/*' />
    [NativeTypeName("rhi::LoadOp")]
    public LoadOp loadOp;

    /// <include file='RenderPassColorAttachment.xml' path='doc/member[@name="RenderPassColorAttachment.storeOp"]/*' />
    [NativeTypeName("rhi::StoreOp")]
    public StoreOp storeOp;

    /// <include file='RenderPassColorAttachment.xml' path='doc/member[@name="RenderPassColorAttachment.clearValue"]/*' />
    [NativeTypeName("float[4]")]
    public fixed float clearValue[4];
}
