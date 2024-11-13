namespace SlangNet.RHI.Unsafe;

/// <include file='SubresourceData.xml' path='doc/member[@name="SubresourceData"]/*' />
public unsafe partial struct SubresourceData
{
    /// <include file='SubresourceData.xml' path='doc/member[@name="SubresourceData.data"]/*' />
    [NativeTypeName("const void *")]
    public void* data;

    /// <include file='SubresourceData.xml' path='doc/member[@name="SubresourceData.strideY"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong strideY;

    /// <include file='SubresourceData.xml' path='doc/member[@name="SubresourceData.strideZ"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong strideZ;
}
