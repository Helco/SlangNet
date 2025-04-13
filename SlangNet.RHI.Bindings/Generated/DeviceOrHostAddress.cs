using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='DeviceOrHostAddress.xml' path='doc/member[@name="DeviceOrHostAddress"]/*' />
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct DeviceOrHostAddress
{
    /// <include file='DeviceOrHostAddress.xml' path='doc/member[@name="DeviceOrHostAddress.deviceAddress"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("rhi::DeviceAddress")]
    public ulong deviceAddress;

    /// <include file='DeviceOrHostAddress.xml' path='doc/member[@name="DeviceOrHostAddress.hostAddress"]/*' />
    [FieldOffset(0)]
    public void* hostAddress;
}
