namespace SlangNet.RHI.Unsafe;

/// <include file='AspectBlendDesc.xml' path='doc/member[@name="AspectBlendDesc"]/*' />
public partial struct AspectBlendDesc
{
    /// <include file='AspectBlendDesc.xml' path='doc/member[@name="AspectBlendDesc.srcFactor"]/*' />
    [NativeTypeName("rhi::BlendFactor")]
    public BlendFactor srcFactor;

    /// <include file='AspectBlendDesc.xml' path='doc/member[@name="AspectBlendDesc.dstFactor"]/*' />
    [NativeTypeName("rhi::BlendFactor")]
    public BlendFactor dstFactor;

    /// <include file='AspectBlendDesc.xml' path='doc/member[@name="AspectBlendDesc.op"]/*' />
    [NativeTypeName("rhi::BlendOp")]
    public BlendOp op;
}
