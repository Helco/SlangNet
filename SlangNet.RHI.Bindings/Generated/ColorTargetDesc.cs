namespace SlangNet.RHI.Unsafe;

/// <include file='ColorTargetDesc.xml' path='doc/member[@name="ColorTargetDesc"]/*' />
public partial struct ColorTargetDesc
{
    /// <include file='ColorTargetDesc.xml' path='doc/member[@name="ColorTargetDesc.format"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format format;

    /// <include file='ColorTargetDesc.xml' path='doc/member[@name="ColorTargetDesc.color"]/*' />
    [NativeTypeName("rhi::AspectBlendDesc")]
    public AspectBlendDesc color;

    /// <include file='ColorTargetDesc.xml' path='doc/member[@name="ColorTargetDesc.alpha"]/*' />
    [NativeTypeName("rhi::AspectBlendDesc")]
    public AspectBlendDesc alpha;

    /// <include file='ColorTargetDesc.xml' path='doc/member[@name="ColorTargetDesc.enableBlend"]/*' />
    public bool enableBlend;

    /// <include file='ColorTargetDesc.xml' path='doc/member[@name="ColorTargetDesc.logicOp"]/*' />
    [NativeTypeName("rhi::LogicOp")]
    public LogicOp logicOp;

    /// <include file='ColorTargetDesc.xml' path='doc/member[@name="ColorTargetDesc.writeMask"]/*' />
    [NativeTypeName("rhi::RenderTargetWriteMaskT")]
    public byte writeMask;
}
