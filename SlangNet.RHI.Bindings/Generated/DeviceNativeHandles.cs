using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='DeviceNativeHandles.xml' path='doc/member[@name="DeviceNativeHandles"]/*' />
public partial struct DeviceNativeHandles
{
    /// <include file='DeviceNativeHandles.xml' path='doc/member[@name="DeviceNativeHandles.handles"]/*' />
    [NativeTypeName("NativeHandle[3]")]
    public _handles_e__FixedBuffer handles;

    /// <include file='_handles_e__FixedBuffer.xml' path='doc/member[@name="_handles_e__FixedBuffer"]/*' />
    public partial struct _handles_e__FixedBuffer
    {
        public NativeHandle e0;
        public NativeHandle e1;
        public NativeHandle e2;

        public unsafe ref NativeHandle this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (NativeHandle* pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
