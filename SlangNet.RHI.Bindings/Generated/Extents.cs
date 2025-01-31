namespace SlangNet.RHI.Unsafe;

/// <include file='Extents.xml' path='doc/member[@name="Extents"]/*' />
public partial struct Extents
{
    /// <include file='Extents.xml' path='doc/member[@name="Extents.width"]/*' />
    [NativeTypeName("int32_t")]
    public int width;

    /// <include file='Extents.xml' path='doc/member[@name="Extents.height"]/*' />
    [NativeTypeName("int32_t")]
    public int height;

    /// <include file='Extents.xml' path='doc/member[@name="Extents.depth"]/*' />
    [NativeTypeName("int32_t")]
    public int depth;
}
