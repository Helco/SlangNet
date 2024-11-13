namespace SlangNet.RHI.Unsafe;

/// <include file='SubresourceRange.xml' path='doc/member[@name="SubresourceRange"]/*' />
public partial struct SubresourceRange
{
    /// <include file='SubresourceRange.xml' path='doc/member[@name="SubresourceRange.mipLevel"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int mipLevel;

    /// <include file='SubresourceRange.xml' path='doc/member[@name="SubresourceRange.mipLevelCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int mipLevelCount;

    /// <include file='SubresourceRange.xml' path='doc/member[@name="SubresourceRange.baseArrayLayer"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int baseArrayLayer;

    /// <include file='SubresourceRange.xml' path='doc/member[@name="SubresourceRange.layerCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int layerCount;
}
