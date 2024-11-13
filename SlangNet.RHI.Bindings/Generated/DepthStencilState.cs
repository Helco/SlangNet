namespace SlangNet.RHI.Unsafe;

/// <include file='DepthStencilState.xml' path='doc/member[@name="DepthStencilState"]/*' />
public partial struct DepthStencilState
{
    /// <include file='DepthStencilState.xml' path='doc/member[@name="DepthStencilState.format"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format format;

    /// <include file='DepthStencilState.xml' path='doc/member[@name="DepthStencilState.depthTestEnable"]/*' />
    public bool depthTestEnable;

    /// <include file='DepthStencilState.xml' path='doc/member[@name="DepthStencilState.depthWriteEnable"]/*' />
    public bool depthWriteEnable;

    /// <include file='DepthStencilState.xml' path='doc/member[@name="DepthStencilState.depthFunc"]/*' />
    [NativeTypeName("rhi::ComparisonFunc")]
    public ComparisonFunc depthFunc;

    /// <include file='DepthStencilState.xml' path='doc/member[@name="DepthStencilState.stencilEnable"]/*' />
    public bool stencilEnable;

    /// <include file='DepthStencilState.xml' path='doc/member[@name="DepthStencilState.stencilReadMask"]/*' />
    [NativeTypeName("uint32_t")]
    public uint stencilReadMask;

    /// <include file='DepthStencilState.xml' path='doc/member[@name="DepthStencilState.stencilWriteMask"]/*' />
    [NativeTypeName("uint32_t")]
    public uint stencilWriteMask;

    /// <include file='DepthStencilState.xml' path='doc/member[@name="DepthStencilState.frontFace"]/*' />
    [NativeTypeName("rhi::DepthStencilOpDesc")]
    public DepthStencilOpDesc frontFace;

    /// <include file='DepthStencilState.xml' path='doc/member[@name="DepthStencilState.backFace"]/*' />
    [NativeTypeName("rhi::DepthStencilOpDesc")]
    public DepthStencilOpDesc backFace;

    /// <include file='DepthStencilState.xml' path='doc/member[@name="DepthStencilState.stencilRef"]/*' />
    [NativeTypeName("uint32_t")]
    public uint stencilRef;
}
