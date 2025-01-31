namespace SlangNet.RHI.Unsafe;

/// <include file='IndirectDispatchArguments.xml' path='doc/member[@name="IndirectDispatchArguments"]/*' />
public partial struct IndirectDispatchArguments
{
    /// <include file='IndirectDispatchArguments.xml' path='doc/member[@name="IndirectDispatchArguments.threadGroupCountX"]/*' />
    [NativeTypeName("uint32_t")]
    public uint threadGroupCountX;

    /// <include file='IndirectDispatchArguments.xml' path='doc/member[@name="IndirectDispatchArguments.threadGroupCountY"]/*' />
    [NativeTypeName("uint32_t")]
    public uint threadGroupCountY;

    /// <include file='IndirectDispatchArguments.xml' path='doc/member[@name="IndirectDispatchArguments.threadGroupCountZ"]/*' />
    [NativeTypeName("uint32_t")]
    public uint threadGroupCountZ;
}
