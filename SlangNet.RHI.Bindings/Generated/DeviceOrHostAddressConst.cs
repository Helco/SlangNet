using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='DeviceOrHostAddressConst.xml' path='doc/member[@name="DeviceOrHostAddressConst"]/*' />
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct DeviceOrHostAddressConst
{
    /// <include file='DeviceOrHostAddressConst.xml' path='doc/member[@name="DeviceOrHostAddressConst.deviceAddress"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("rhi::DeviceAddress")]
    public ulong deviceAddress;

    /// <include file='DeviceOrHostAddressConst.xml' path='doc/member[@name="DeviceOrHostAddressConst.hostAddress"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("const void *")]
    public void* hostAddress;
}
