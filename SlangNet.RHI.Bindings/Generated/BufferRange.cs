using System;

namespace SlangNet.RHI.Unsafe;

/// <include file='BufferRange.xml' path='doc/member[@name="BufferRange"]/*' />
public partial struct BufferRange
{
    /// <include file='BufferRange.xml' path='doc/member[@name="BufferRange.offset"]/*' />
    [NativeTypeName("rhi::Offset")]
    public nuint offset;

    /// <include file='BufferRange.xml' path='doc/member[@name="BufferRange.size"]/*' />
    [NativeTypeName("rhi::Size")]
    public UIntPtr size;
}
