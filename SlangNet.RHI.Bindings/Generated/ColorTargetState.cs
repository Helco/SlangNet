namespace SlangNet.RHI.Unsafe;

/// <include file='ColorTargetState.xml' path='doc/member[@name="ColorTargetState"]/*' />
public partial struct ColorTargetState
{
    /// <include file='ColorTargetState.xml' path='doc/member[@name="ColorTargetState.format"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format format;

    /// <include file='ColorTargetState.xml' path='doc/member[@name="ColorTargetState.color"]/*' />
    [NativeTypeName("rhi::AspectBlendDesc")]
    public AspectBlendDesc color;

    /// <include file='ColorTargetState.xml' path='doc/member[@name="ColorTargetState.alpha"]/*' />
    [NativeTypeName("rhi::AspectBlendDesc")]
    public AspectBlendDesc alpha;

    /// <include file='ColorTargetState.xml' path='doc/member[@name="ColorTargetState.enableBlend"]/*' />
    public bool enableBlend;

    /// <include file='ColorTargetState.xml' path='doc/member[@name="ColorTargetState.logicOp"]/*' />
    [NativeTypeName("rhi::LogicOp")]
    public LogicOp logicOp;

    /// <include file='ColorTargetState.xml' path='doc/member[@name="ColorTargetState.writeMask"]/*' />
    [NativeTypeName("rhi::RenderTargetWriteMaskT")]
    public byte writeMask;
}
