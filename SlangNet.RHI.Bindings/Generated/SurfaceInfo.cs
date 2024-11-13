namespace SlangNet.RHI.Unsafe;

/// <include file='SurfaceInfo.xml' path='doc/member[@name="SurfaceInfo"]/*' />
public unsafe partial struct SurfaceInfo
{
    /// <include file='SurfaceInfo.xml' path='doc/member[@name="SurfaceInfo.preferredFormat"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format preferredFormat;

    /// <include file='SurfaceInfo.xml' path='doc/member[@name="SurfaceInfo.supportedUsage"]/*' />
    [NativeTypeName("rhi::TextureUsage")]
    public TextureUsage supportedUsage;

    /// <include file='SurfaceInfo.xml' path='doc/member[@name="SurfaceInfo.formats"]/*' />
    [NativeTypeName("const Format *")]
    public Format* formats;

    /// <include file='SurfaceInfo.xml' path='doc/member[@name="SurfaceInfo.formatCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int formatCount;
}
