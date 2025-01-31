namespace SlangNet.RHI.Unsafe;

/// <include file='SurfaceConfig.xml' path='doc/member[@name="SurfaceConfig"]/*' />
public partial struct SurfaceConfig
{
    /// <include file='SurfaceConfig.xml' path='doc/member[@name="SurfaceConfig.format"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format format;

    /// <include file='SurfaceConfig.xml' path='doc/member[@name="SurfaceConfig.usage"]/*' />
    [NativeTypeName("rhi::TextureUsage")]
    public TextureUsage usage;

    /// <include file='SurfaceConfig.xml' path='doc/member[@name="SurfaceConfig.width"]/*' />
    [NativeTypeName("uint32_t")]
    public uint width;

    /// <include file='SurfaceConfig.xml' path='doc/member[@name="SurfaceConfig.height"]/*' />
    [NativeTypeName("uint32_t")]
    public uint height;

    /// <include file='SurfaceConfig.xml' path='doc/member[@name="SurfaceConfig.desiredImageCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint desiredImageCount;

    /// <include file='SurfaceConfig.xml' path='doc/member[@name="SurfaceConfig.vsync"]/*' />
    public bool vsync;
}
