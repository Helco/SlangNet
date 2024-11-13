namespace SlangNet.RHI.Unsafe;

/// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc"]/*' />
public unsafe partial struct TextureDesc
{
    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.type"]/*' />
    [NativeTypeName("rhi::TextureType")]
    public TextureType type;

    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.memoryType"]/*' />
    [NativeTypeName("rhi::MemoryType")]
    public MemoryType memoryType;

    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.usage"]/*' />
    [NativeTypeName("rhi::TextureUsage")]
    public TextureUsage usage;

    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.defaultState"]/*' />
    [NativeTypeName("rhi::ResourceState")]
    public ResourceState defaultState;

    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.isShared"]/*' />
    public bool isShared;

    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.size"]/*' />
    [NativeTypeName("rhi::Extents")]
    public Extents size;

    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.arrayLength"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int arrayLength;

    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.mipLevelCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int mipLevelCount;

    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.format"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format format;

    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.sampleCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int sampleCount;

    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.sampleQuality"]/*' />
    public int sampleQuality;

    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.optimalClearValue"]/*' />
    [NativeTypeName("rhi::ClearValue *")]
    public ClearValue* optimalClearValue;

    /// <include file='TextureDesc.xml' path='doc/member[@name="TextureDesc.label"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* label;
}
