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
    [InlineArray(2)]
    public partial struct _handleValues_e__FixedBuffer
    {
        public nint e0;
    }
}
