using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue"]/*' />
[NativeTypeName("struct ICommandQueue : ISlangUnknown")]
public unsafe partial struct ICommandQueue
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((ICommandQueue*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((ICommandQueue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((ICommandQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue.getType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::QueueType")]
    public QueueType getType()
    {
        return lpVtbl->getType((ICommandQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue.createCommandEncoder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createCommandEncoder(ICommandEncoder** outEncoder)
    {
        return lpVtbl->createCommandEncoder((ICommandQueue*)Unsafe.AsPointer(ref this), outEncoder);
    }

    /// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue.submit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int submit([NativeTypeName("uint32_t")] uint count, ICommandBuffer** commandBuffers, [NativeTypeName("rhi::IFence *")] IFence* fenceToSignal, [NativeTypeName("uint64_t")] ulong newFenceValue)
    {
        return lpVtbl->submit((ICommandQueue*)Unsafe.AsPointer(ref this), count, commandBuffers, fenceToSignal, newFenceValue);
    }

    /// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue.getNativeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        return lpVtbl->getNativeHandle((ICommandQueue*)Unsafe.AsPointer(ref this), outHandle);
    }

    /// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue.waitOnHost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int waitOnHost()
    {
        return lpVtbl->waitOnHost((ICommandQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandQueue.xml' path='doc/member[@name="ICommandQueue.waitForFenceValuesOnDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int waitForFenceValuesOnDevice([NativeTypeName("uint32_t")] uint fenceCount, IFence** fences, [NativeTypeName("uint64_t *")] ulong* waitValues)
    {
        return lpVtbl->waitForFenceValuesOnDevice((ICommandQueue*)Unsafe.AsPointer(ref this), fenceCount, fences, waitValues);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandQueue*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandQueue*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandQueue*, uint> release;

        [NativeTypeName("QueueType () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandQueue*, QueueType> getType;

        [NativeTypeName("Result (ICommandEncoder **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandQueue*, ICommandEncoder**, int> createCommandEncoder;

        [NativeTypeName("Result (uint32_t, ICommandBuffer **, IFence *, uint64_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandQueue*, uint, ICommandBuffer**, IFence*, ulong, int> submit;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandQueue*, NativeHandle*, int> getNativeHandle;

        [NativeTypeName("Result () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandQueue*, int> waitOnHost;

        [NativeTypeName("Result (uint32_t, IFence **, uint64_t *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandQueue*, uint, IFence**, ulong*, int> waitForFenceValuesOnDevice;
    }
}
