using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IDebugCallback.xml' path='doc/member[@name="IDebugCallback"]/*' />
public unsafe partial struct IDebugCallback
{
    public Vtbl* lpVtbl;

    /// <include file='IDebugCallback.xml' path='doc/member[@name="IDebugCallback.handleMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void handleMessage([NativeTypeName("rhi::DebugMessageType")] DebugMessageType type, [NativeTypeName("rhi::DebugMessageSource")] DebugMessageSource source, [NativeTypeName("const char *")] sbyte* message)
    {
        lpVtbl->handleMessage((IDebugCallback*)Unsafe.AsPointer(ref this), type, source, message);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("void (DebugMessageType, DebugMessageSource, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDebugCallback*, DebugMessageType, DebugMessageSource, sbyte*, void> handleMessage;
    }
}
