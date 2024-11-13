namespace SlangNet.RHI.Unsafe;

/// <include file='Offset3D.xml' path='doc/member[@name="Offset3D"]/*' />
public partial struct Offset3D
{
    /// <include file='Offset3D.xml' path='doc/member[@name="Offset3D.x"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int x;

    /// <include file='Offset3D.xml' path='doc/member[@name="Offset3D.y"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int y;

    /// <include file='Offset3D.xml' path='doc/member[@name="Offset3D.z"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int z;
}
