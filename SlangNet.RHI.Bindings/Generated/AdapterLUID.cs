namespace SlangNet.RHI.Unsafe;

/// <include file='AdapterLUID.xml' path='doc/member[@name="AdapterLUID"]/*' />
public unsafe partial struct AdapterLUID
{
    /// <include file='AdapterLUID.xml' path='doc/member[@name="AdapterLUID.luid"]/*' />
    [NativeTypeName("uint8_t[16]")]
    public fixed byte luid[16];
}
