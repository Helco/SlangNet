using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IAccelerationStructure.xml' path='doc/member[@name="IAccelerationStructure"]/*' />
[NativeTypeName("struct IAccelerationStructure : rhi::IResource")]
public unsafe partial struct IAccelerationStructure
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IAccelerationStructure*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IAccelerationStructure*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IAccelerationStructure*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IResource.getNativeHandle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        return lpVtbl->getNativeHandle((IAccelerationStructure*)Unsafe.AsPointer(ref this), outHandle);
    }

    /// <include file='IAccelerationStructure.xml' path='doc/member[@name="IAccelerationStructure.getHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::AccelerationStructureHandle")]
    public AccelerationStructureHandle getHandle()
    {
        AccelerationStructureHandle result;
        return *lpVtbl->getHandle((IAccelerationStructure*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='IAccelerationStructure.xml' path='doc/member[@name="IAccelerationStructure.getDeviceAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::DeviceAddress")]
    public ulong getDeviceAddress()
    {
        return lpVtbl->getDeviceAddress((IAccelerationStructure*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IAccelerationStructure*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IAccelerationStructure*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IAccelerationStructure*, uint> release;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IAccelerationStructure*, NativeHandle*, int> getNativeHandle;

        [NativeTypeName("AccelerationStructureHandle () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IAccelerationStructure*, AccelerationStructureHandle*, AccelerationStructureHandle*> getHandle;

        [NativeTypeName("DeviceAddress () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IAccelerationStructure*, ulong> getDeviceAddress;
    }
}
