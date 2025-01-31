namespace SlangNet.RHI.Unsafe;

/// <include file='BufferRange.xml' path='doc/member[@name="BufferRange"]/*' />
public partial struct BufferRange
{
    /// <include file='BufferRange.xml' path='doc/member[@name="BufferRange.offset"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong offset;

    /// <include file='BufferRange.xml' path='doc/member[@name="BufferRange.size"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong size;
}
