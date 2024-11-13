namespace SlangNet.RHI.Unsafe;

/// <include file='DeviceInfo.xml' path='doc/member[@name="DeviceInfo"]/*' />
public unsafe partial struct DeviceInfo
{
    /// <include file='DeviceInfo.xml' path='doc/member[@name="DeviceInfo.deviceType"]/*' />
    [NativeTypeName("rhi::DeviceType")]
    public DeviceType deviceType;

    /// <include file='DeviceInfo.xml' path='doc/member[@name="DeviceInfo.limits"]/*' />
    [NativeTypeName("rhi::DeviceLimits")]
    public DeviceLimits limits;

    /// <include file='DeviceInfo.xml' path='doc/member[@name="DeviceInfo.identityProjectionMatrix"]/*' />
    [NativeTypeName("float[16]")]
    public fixed float identityProjectionMatrix[16];

    /// <include file='DeviceInfo.xml' path='doc/member[@name="DeviceInfo.apiName"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* apiName;

    /// <include file='DeviceInfo.xml' path='doc/member[@name="DeviceInfo.adapterName"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* adapterName;

    /// <include file='DeviceInfo.xml' path='doc/member[@name="DeviceInfo.timestampFrequency"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong timestampFrequency;
}
