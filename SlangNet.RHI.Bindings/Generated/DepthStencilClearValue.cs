namespace SlangNet.RHI.Unsafe;

/// <include file='DepthStencilClearValue.xml' path='doc/member[@name="DepthStencilClearValue"]/*' />
public partial struct DepthStencilClearValue
{
    /// <include file='DepthStencilClearValue.xml' path='doc/member[@name="DepthStencilClearValue.depth"]/*' />
    public float depth;

    /// <include file='DepthStencilClearValue.xml' path='doc/member[@name="DepthStencilClearValue.stencil"]/*' />
    [NativeTypeName("uint32_t")]
    public uint stencil;
}
