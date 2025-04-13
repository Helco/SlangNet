namespace SlangNet.RHI.Unsafe;

/// <include file='SubresourceLayout.xml' path='doc/member[@name="SubresourceLayout"]/*' />
public partial struct SubresourceLayout
{
    /// <include file='SubresourceLayout.xml' path='doc/member[@name="SubresourceLayout.size"]/*' />
    [NativeTypeName("rhi::Extents")]
    public Extents size;

    /// <include file='SubresourceLayout.xml' path='doc/member[@name="SubresourceLayout.colPitch"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong colPitch;

    /// <include file='SubresourceLayout.xml' path='doc/member[@name="SubresourceLayout.rowPitch"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong rowPitch;

    /// <include file='SubresourceLayout.xml' path='doc/member[@name="SubresourceLayout.slicePitch"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong slicePitch;

    /// <include file='SubresourceLayout.xml' path='doc/member[@name="SubresourceLayout.sizeInBytes"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong sizeInBytes;

    /// <include file='SubresourceLayout.xml' path='doc/member[@name="SubresourceLayout.blockWidth"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong blockWidth;

    /// <include file='SubresourceLayout.xml' path='doc/member[@name="SubresourceLayout.blockHeight"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong blockHeight;

    /// <include file='SubresourceLayout.xml' path='doc/member[@name="SubresourceLayout.rowCount"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong rowCount;
}
