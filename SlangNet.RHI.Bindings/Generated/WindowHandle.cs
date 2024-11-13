using System;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='WindowHandle.xml' path='doc/member[@name="WindowHandle"]/*' />
public partial struct WindowHandle
{
    /// <include file='WindowHandle.xml' path='doc/member[@name="WindowHandle.type"]/*' />
    [NativeTypeName("rhi::WindowHandleType")]
    public WindowHandleType type;

    /// <include file='WindowHandle.xml' path='doc/member[@name="WindowHandle.handleValues"]/*' />
    [NativeTypeName("intptr_t[2]")]
    public _handleValues_e__FixedBuffer handleValues;

    /// <include file='_handleValues_e__FixedBuffer.xml' path='doc/member[@name="_handleValues_e__FixedBuffer"]/*' />
    public partial struct _handleValues_e__FixedBuffer
    {
        public IntPtr e0;
        public IntPtr e1;

        public unsafe ref IntPtr this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (IntPtr* pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
