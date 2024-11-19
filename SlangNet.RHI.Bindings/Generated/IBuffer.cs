using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IBuffer.xml' path='doc/member[@name="IBuffer"]/*' />
[NativeTypeName("struct IBuffer : rhi::IResource")]
public unsafe partial struct IBuffer
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IBuffer*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IResource.getNativeHandle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        return lpVtbl->getNativeHandle((IBuffer*)Unsafe.AsPointer(ref this), outHandle);
    }

    /// <include file='IBuffer.xml' path='doc/member[@name="IBuffer.getDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const BufferDesc &")]
    public BufferDesc* getDesc()
    {
        return lpVtbl->getDesc((IBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBuffer.xml' path='doc/member[@name="IBuffer.getSharedHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getSharedHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        return lpVtbl->getSharedHandle((IBuffer*)Unsafe.AsPointer(ref this), outHandle);
    }

    /// <include file='IBuffer.xml' path='doc/member[@name="IBuffer.getDeviceAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::DeviceAddress")]
    public ulong getDeviceAddress()
    {
        return lpVtbl->getDeviceAddress((IBuffer*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IBuffer*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IBuffer*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IBuffer*, uint> release;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IBuffer*, NativeHandle*, int> getNativeHandle;

        [NativeTypeName("const BufferDesc &() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IBuffer*, BufferDesc*> getDesc;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IBuffer*, NativeHandle*, int> getSharedHandle;

        [NativeTypeName("DeviceAddress () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IBuffer*, ulong> getDeviceAddress;
    }
}
