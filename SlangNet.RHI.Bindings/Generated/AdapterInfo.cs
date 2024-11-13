namespace SlangNet.RHI.Unsafe;

/// <include file='AdapterInfo.xml' path='doc/member[@name="AdapterInfo"]/*' />
public unsafe partial struct AdapterInfo
{
    /// <include file='AdapterInfo.xml' path='doc/member[@name="AdapterInfo.name"]/*' />
    [NativeTypeName("char[128]")]
    public fixed sbyte name[128];

    /// <include file='AdapterInfo.xml' path='doc/member[@name="AdapterInfo.vendorID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vendorID;

    /// <include file='AdapterInfo.xml' path='doc/member[@name="AdapterInfo.deviceID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint deviceID;

    /// <include file='AdapterInfo.xml' path='doc/member[@name="AdapterInfo.luid"]/*' />
    [NativeTypeName("rhi::AdapterLUID")]
    public AdapterLUID luid;
}
