namespace SlangNet.RHI.Unsafe;

/// <include file='DepthStencilOpDesc.xml' path='doc/member[@name="DepthStencilOpDesc"]/*' />
public partial struct DepthStencilOpDesc
{
    /// <include file='DepthStencilOpDesc.xml' path='doc/member[@name="DepthStencilOpDesc.stencilFailOp"]/*' />
    [NativeTypeName("rhi::StencilOp")]
    public StencilOp stencilFailOp;

    /// <include file='DepthStencilOpDesc.xml' path='doc/member[@name="DepthStencilOpDesc.stencilDepthFailOp"]/*' />
    [NativeTypeName("rhi::StencilOp")]
    public StencilOp stencilDepthFailOp;

    /// <include file='DepthStencilOpDesc.xml' path='doc/member[@name="DepthStencilOpDesc.stencilPassOp"]/*' />
    [NativeTypeName("rhi::StencilOp")]
    public StencilOp stencilPassOp;

    /// <include file='DepthStencilOpDesc.xml' path='doc/member[@name="DepthStencilOpDesc.stencilFunc"]/*' />
    [NativeTypeName("rhi::ComparisonFunc")]
    public ComparisonFunc stencilFunc;
}
