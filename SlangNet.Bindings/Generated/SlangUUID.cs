namespace SlangNet.Unsafe;

/// <include file='SlangUUID.xml' path='doc/member[@name="SlangUUID"]/*' />
public unsafe partial struct SlangUUID
{
    /// <include file='SlangUUID.xml' path='doc/member[@name="SlangUUID.data1"]/*' />
    [NativeTypeName("uint32_t")]
    public uint data1;

    /// <include file='SlangUUID.xml' path='doc/member[@name="SlangUUID.data2"]/*' />
    [NativeTypeName("uint16_t")]
    public ushort data2;

    /// <include file='SlangUUID.xml' path='doc/member[@name="SlangUUID.data3"]/*' />
    [NativeTypeName("uint16_t")]
    public ushort data3;

    /// <include file='SlangUUID.xml' path='doc/member[@name="SlangUUID.data4"]/*' />
    [NativeTypeName("uint8_t[8]")]
    public fixed byte data4[8];
}
