namespace SlangNet.RHI.Unsafe;

/// <include file='IndirectDispatchArguments.xml' path='doc/member[@name="IndirectDispatchArguments"]/*' />
public partial struct IndirectDispatchArguments
{
    /// <include file='IndirectDispatchArguments.xml' path='doc/member[@name="IndirectDispatchArguments.ThreadGroupCountX"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int ThreadGroupCountX;

    /// <include file='IndirectDispatchArguments.xml' path='doc/member[@name="IndirectDispatchArguments.ThreadGroupCountY"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int ThreadGroupCountY;

    /// <include file='IndirectDispatchArguments.xml' path='doc/member[@name="IndirectDispatchArguments.ThreadGroupCountZ"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int ThreadGroupCountZ;
}
