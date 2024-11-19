using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IFence.xml' path='doc/member[@name="IFence"]/*' />
[NativeTypeName("struct IFence : ISlangUnknown")]
public unsafe partial struct IFence
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IFence*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IFence*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IFence*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFence.xml' path='doc/member[@name="IFence.getCurrentValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getCurrentValue([NativeTypeName("uint64_t *")] ulong* outValue)
    {
        return lpVtbl->getCurrentValue((IFence*)Unsafe.AsPointer(ref this), outValue);
    }

    /// <include file='IFence.xml' path='doc/member[@name="IFence.setCurrentValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setCurrentValue([NativeTypeName("uint64_t")] ulong value)
    {
        return lpVtbl->setCurrentValue((IFence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFence.xml' path='doc/member[@name="IFence.getNativeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        return lpVtbl->getNativeHandle((IFence*)Unsafe.AsPointer(ref this), outHandle);
    }

    /// <include file='IFence.xml' path='doc/member[@name="IFence.getSharedHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getSharedHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        return lpVtbl->getSharedHandle((IFence*)Unsafe.AsPointer(ref this), outHandle);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IFence*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IFence*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IFence*, uint> release;

        [NativeTypeName("Result (uint64_t *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IFence*, ulong*, int> getCurrentValue;

        [NativeTypeName("Result (uint64_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IFence*, ulong, int> setCurrentValue;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IFence*, NativeHandle*, int> getNativeHandle;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IFence*, NativeHandle*, int> getSharedHandle;
    }
}
