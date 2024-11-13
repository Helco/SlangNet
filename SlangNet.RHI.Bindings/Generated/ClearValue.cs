namespace SlangNet.RHI.Unsafe;

/// <include file='ClearValue.xml' path='doc/member[@name="ClearValue"]/*' />
public partial struct ClearValue
{
    /// <include file='ClearValue.xml' path='doc/member[@name="ClearValue.color"]/*' />
    [NativeTypeName("rhi::ColorClearValue")]
    public ColorClearValue color;

    /// <include file='ClearValue.xml' path='doc/member[@name="ClearValue.depthStencil"]/*' />
    [NativeTypeName("rhi::DepthStencilClearValue")]
    public DepthStencilClearValue depthStencil;
}
