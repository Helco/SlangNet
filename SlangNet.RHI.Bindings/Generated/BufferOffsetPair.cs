namespace SlangNet.RHI.Unsafe;

/// <include file='BufferOffsetPair.xml' path='doc/member[@name="BufferOffsetPair"]/*' />
public unsafe partial struct BufferOffsetPair
{
    /// <include file='BufferOffsetPair.xml' path='doc/member[@name="BufferOffsetPair.buffer"]/*' />
    [NativeTypeName("rhi::IBuffer *")]
    public IBuffer* buffer;

    /// <include file='BufferOffsetPair.xml' path='doc/member[@name="BufferOffsetPair.offset"]/*' />
    [NativeTypeName("rhi::Offset")]
    public ulong offset;
}
