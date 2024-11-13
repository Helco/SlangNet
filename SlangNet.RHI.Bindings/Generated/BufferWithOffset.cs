namespace SlangNet.RHI.Unsafe;

/// <include file='BufferWithOffset.xml' path='doc/member[@name="BufferWithOffset"]/*' />
public unsafe partial struct BufferWithOffset
{
    /// <include file='BufferWithOffset.xml' path='doc/member[@name="BufferWithOffset.buffer"]/*' />
    [NativeTypeName("rhi::IBuffer *")]
    public IBuffer* buffer;

    /// <include file='BufferWithOffset.xml' path='doc/member[@name="BufferWithOffset.offset"]/*' />
    [NativeTypeName("rhi::Offset")]
    public nuint offset;
}
