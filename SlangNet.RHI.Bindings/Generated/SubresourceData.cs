namespace SlangNet.RHI.Unsafe;

/// <include file='SubresourceData.xml' path='doc/member[@name="SubresourceData"]/*' />
public unsafe partial struct SubresourceData
{
    /// <include file='SubresourceData.xml' path='doc/member[@name="SubresourceData.data"]/*' />
    [NativeTypeName("const void *")]
    public void* data;

    /// <include file='SubresourceData.xml' path='doc/member[@name="SubresourceData.rowPitch"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong rowPitch;

    /// <include file='SubresourceData.xml' path='doc/member[@name="SubresourceData.slicePitch"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong slicePitch;
}
