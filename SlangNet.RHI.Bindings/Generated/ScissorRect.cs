namespace SlangNet.RHI.Unsafe;

/// <include file='ScissorRect.xml' path='doc/member[@name="ScissorRect"]/*' />
public partial struct ScissorRect
{
    /// <include file='ScissorRect.xml' path='doc/member[@name="ScissorRect.minX"]/*' />
    [NativeTypeName("int32_t")]
    public int minX;

    /// <include file='ScissorRect.xml' path='doc/member[@name="ScissorRect.minY"]/*' />
    [NativeTypeName("int32_t")]
    public int minY;

    /// <include file='ScissorRect.xml' path='doc/member[@name="ScissorRect.maxX"]/*' />
    [NativeTypeName("int32_t")]
    public int maxX;

    /// <include file='ScissorRect.xml' path='doc/member[@name="ScissorRect.maxY"]/*' />
    [NativeTypeName("int32_t")]
    public int maxY;
}
