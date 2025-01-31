namespace SlangNet.RHI.Unsafe;

/// <include file='SubresourceRange.xml' path='doc/member[@name="SubresourceRange"]/*' />
public partial struct SubresourceRange
{
    /// <include file='SubresourceRange.xml' path='doc/member[@name="SubresourceRange.mipLevel"]/*' />
    [NativeTypeName("uint32_t")]
    public uint mipLevel;

    /// <include file='SubresourceRange.xml' path='doc/member[@name="SubresourceRange.mipLevelCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint mipLevelCount;

    /// <include file='SubresourceRange.xml' path='doc/member[@name="SubresourceRange.baseArrayLayer"]/*' />
    [NativeTypeName("uint32_t")]
    public uint baseArrayLayer;

    /// <include file='SubresourceRange.xml' path='doc/member[@name="SubresourceRange.layerCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint layerCount;
}
