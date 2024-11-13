using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IDebugCallback.xml' path='doc/member[@name="IDebugCallback"]/*' />
public unsafe partial struct IDebugCallback
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _handleMessage(IDebugCallback* pThis, [NativeTypeName("rhi::DebugMessageType")] DebugMessageType type, [NativeTypeName("rhi::DebugMessageSource")] DebugMessageSource source, [NativeTypeName("const char *")] sbyte* message);

    /// <include file='IDebugCallback.xml' path='doc/member[@name="IDebugCallback.handleMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void handleMessage([NativeTypeName("rhi::DebugMessageType")] DebugMessageType type, [NativeTypeName("rhi::DebugMessageSource")] DebugMessageSource source, [NativeTypeName("const char *")] sbyte* message)
    {
        fixed (IDebugCallback* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_handleMessage>(lpVtbl->handleMessage)(pThis, type, source, message);
        }
    }

    public partial struct Vtbl
    {
        [NativeTypeName("void (DebugMessageType, DebugMessageSource, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr handleMessage;
    }
}
