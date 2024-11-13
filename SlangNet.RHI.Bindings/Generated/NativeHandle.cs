namespace SlangNet.RHI.Unsafe;

/// <include file='NativeHandle.xml' path='doc/member[@name="NativeHandle"]/*' />
public partial struct NativeHandle
{
    /// <include file='NativeHandle.xml' path='doc/member[@name="NativeHandle.type"]/*' />
    [NativeTypeName("rhi::NativeHandleType")]
    public NativeHandleType type;

    /// <include file='NativeHandle.xml' path='doc/member[@name="NativeHandle.value"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong value;
}
