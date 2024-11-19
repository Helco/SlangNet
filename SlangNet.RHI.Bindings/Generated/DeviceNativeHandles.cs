using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='DeviceNativeHandles.xml' path='doc/member[@name="DeviceNativeHandles"]/*' />
public partial struct DeviceNativeHandles
{
    /// <include file='DeviceNativeHandles.xml' path='doc/member[@name="DeviceNativeHandles.handles"]/*' />
    [NativeTypeName("NativeHandle[3]")]
    public _handles_e__FixedBuffer handles;

    /// <include file='_handles_e__FixedBuffer.xml' path='doc/member[@name="_handles_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _handles_e__FixedBuffer
    {
        public NativeHandle e0;
    }
}
