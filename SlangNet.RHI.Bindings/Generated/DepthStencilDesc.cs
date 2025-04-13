namespace SlangNet.RHI.Unsafe;

/// <include file='DepthStencilDesc.xml' path='doc/member[@name="DepthStencilDesc"]/*' />
public partial struct DepthStencilDesc
{
    /// <include file='DepthStencilDesc.xml' path='doc/member[@name="DepthStencilDesc.format"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format format;

    /// <include file='DepthStencilDesc.xml' path='doc/member[@name="DepthStencilDesc.depthTestEnable"]/*' />
    public bool depthTestEnable;

    /// <include file='DepthStencilDesc.xml' path='doc/member[@name="DepthStencilDesc.depthWriteEnable"]/*' />
    public bool depthWriteEnable;

    /// <include file='DepthStencilDesc.xml' path='doc/member[@name="DepthStencilDesc.depthFunc"]/*' />
    [NativeTypeName("rhi::ComparisonFunc")]
    public ComparisonFunc depthFunc;

    /// <include file='DepthStencilDesc.xml' path='doc/member[@name="DepthStencilDesc.stencilEnable"]/*' />
    public bool stencilEnable;

    /// <include file='DepthStencilDesc.xml' path='doc/member[@name="DepthStencilDesc.stencilReadMask"]/*' />
    [NativeTypeName("uint32_t")]
    public uint stencilReadMask;

    /// <include file='DepthStencilDesc.xml' path='doc/member[@name="DepthStencilDesc.stencilWriteMask"]/*' />
    [NativeTypeName("uint32_t")]
    public uint stencilWriteMask;

    /// <include file='DepthStencilDesc.xml' path='doc/member[@name="DepthStencilDesc.frontFace"]/*' />
    [NativeTypeName("rhi::DepthStencilOpDesc")]
    public DepthStencilOpDesc frontFace;

    /// <include file='DepthStencilDesc.xml' path='doc/member[@name="DepthStencilDesc.backFace"]/*' />
    [NativeTypeName("rhi::DepthStencilOpDesc")]
    public DepthStencilOpDesc backFace;

    /// <include file='DepthStencilDesc.xml' path='doc/member[@name="DepthStencilDesc.stencilRef"]/*' />
    [NativeTypeName("uint32_t")]
    public uint stencilRef;
}
