using SlangNet.Unsafe;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue"]/*' />
[NativeTypeName("struct ICommandQueue : ISlangUnknown")]
public unsafe partial struct ICommandQueue
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ICommandQueue* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ICommandQueue* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ICommandQueue* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::QueueType")]
    public delegate QueueType _getType(ICommandQueue* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createCommandEncoder(ICommandQueue* pThis, ICommandEncoder** outEncoder);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _submit(ICommandQueue* pThis, [NativeTypeName("rhi::GfxCount")] int count, [NativeTypeName("ICommandBuffer *const *")] ICommandBuffer** commandBuffers, [NativeTypeName("rhi::IFence *")] IFence* fenceToSignal, [NativeTypeName("uint64_t")] ulong newFenceValue);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getNativeHandle(ICommandQueue* pThis, [NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _waitOnHost(ICommandQueue* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _waitForFenceValuesOnDevice(ICommandQueue* pThis, [NativeTypeName("rhi::GfxCount")] int fenceCount, IFence** fences, [NativeTypeName("uint64_t *")] ulong* waitValues);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ICommandQueue* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ICommandQueue* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ICommandQueue* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue.getType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::QueueType")]
    public QueueType getType()
    {
        fixed (ICommandQueue* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getType>(lpVtbl->getType)(pThis);
        }
    }

    /// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue.createCommandEncoder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createCommandEncoder(ICommandEncoder** outEncoder)
    {
        fixed (ICommandQueue* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createCommandEncoder>(lpVtbl->createCommandEncoder)(pThis, outEncoder);
        }
    }

    /// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue.submit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int submit([NativeTypeName("rhi::GfxCount")] int count, [NativeTypeName("ICommandBuffer *const *")] ICommandBuffer** commandBuffers, [NativeTypeName("rhi::IFence *")] IFence* fenceToSignal, [NativeTypeName("uint64_t")] ulong newFenceValue)
    {
        fixed (ICommandQueue* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_submit>(lpVtbl->submit)(pThis, count, commandBuffers, fenceToSignal, newFenceValue);
        }
    }

    /// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue.getNativeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        fixed (ICommandQueue* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getNativeHandle>(lpVtbl->getNativeHandle)(pThis, outHandle);
        }
    }

    /// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue.waitOnHost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int waitOnHost()
    {
        fixed (ICommandQueue* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_waitOnHost>(lpVtbl->waitOnHost)(pThis);
        }
    }

    /// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue.waitForFenceValuesOnDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int waitForFenceValuesOnDevice([NativeTypeName("rhi::GfxCount")] int fenceCount, IFence** fences, [NativeTypeName("uint64_t *")] ulong* waitValues)
    {
        fixed (ICommandQueue* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_waitForFenceValuesOnDevice>(lpVtbl->waitForFenceValuesOnDevice)(pThis, fenceCount, fences, waitValues);
        }
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr release;

        [NativeTypeName("QueueType () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getType;

        [NativeTypeName("Result (ICommandEncoder **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createCommandEncoder;

        [NativeTypeName("Result (GfxCount, ICommandBuffer *const *, IFence *, uint64_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr submit;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getNativeHandle;

        [NativeTypeName("Result () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr waitOnHost;

        [NativeTypeName("Result (GfxCount, IFence **, uint64_t *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr waitForFenceValuesOnDevice;
    }
}
