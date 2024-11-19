using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='ICommandBuffer.xml' path='doc/member[@name="ICommandBuffer"]/*' />
[NativeTypeName("struct ICommandBuffer : ISlangUnknown")]
public unsafe partial struct ICommandBuffer
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((ICommandBuffer*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((ICommandBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((ICommandBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandBuffer.xml' path='doc/member[@name="ICommandBuffer.getNativeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        return lpVtbl->getNativeHandle((ICommandBuffer*)Unsafe.AsPointer(ref this), outHandle);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandBuffer*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandBuffer*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandBuffer*, uint> release;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandBuffer*, NativeHandle*, int> getNativeHandle;
    }
}
