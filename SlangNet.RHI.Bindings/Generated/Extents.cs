namespace SlangNet.RHI.Unsafe;

/// <include file='Extents.xml' path='doc/member[@name="Extents"]/*' />
public partial struct Extents
{
    /// <include file='Extents.xml' path='doc/member[@name="Extents.width"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int width;

    /// <include file='Extents.xml' path='doc/member[@name="Extents.height"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int height;

    /// <include file='Extents.xml' path='doc/member[@name="Extents.depth"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int depth;
}
