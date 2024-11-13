using System;

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
    [NativeTypeName("rhi::Size")]
    public UIntPtr width;

    /// <include file='SurfaceConfig.xml' path='doc/member[@name="SurfaceConfig.height"]/*' />
    [NativeTypeName("rhi::Size")]
    public UIntPtr height;

    /// <include file='SurfaceConfig.xml' path='doc/member[@name="SurfaceConfig.desiredImageCount"]/*' />
    [NativeTypeName("rhi::Size")]
    public UIntPtr desiredImageCount;

    /// <include file='SurfaceConfig.xml' path='doc/member[@name="SurfaceConfig.vsync"]/*' />
    public bool vsync;
}
