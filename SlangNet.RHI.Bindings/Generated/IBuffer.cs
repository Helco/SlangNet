using SlangNet.Unsafe;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IBuffer.xml' path='doc/member[@name="IBuffer"]/*' />
[NativeTypeName("struct IBuffer : rhi::IResource")]
public unsafe partial struct IBuffer
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(IBuffer* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(IBuffer* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(IBuffer* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getNativeHandle(IBuffer* pThis, [NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const BufferDesc &")]
    public delegate BufferDesc* _getDesc(IBuffer* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getSharedHandle(IBuffer* pThis, [NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::DeviceAddress")]
    public delegate ulong _getDeviceAddress(IBuffer* pThis);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (IBuffer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (IBuffer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (IBuffer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <inheritdoc cref="IResource.getNativeHandle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        fixed (IBuffer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getNativeHandle>(lpVtbl->getNativeHandle)(pThis, outHandle);
        }
    }

    /// <include file='IBuffer.xml' path='doc/member[@name="IBuffer.getDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const BufferDesc &")]
    public BufferDesc* getDesc()
    {
        fixed (IBuffer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDesc>(lpVtbl->getDesc)(pThis);
        }
    }

    /// <include file='IBuffer.xml' path='doc/member[@name="IBuffer.getSharedHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getSharedHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        fixed (IBuffer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getSharedHandle>(lpVtbl->getSharedHandle)(pThis, outHandle);
        }
    }

    /// <include file='IBuffer.xml' path='doc/member[@name="IBuffer.getDeviceAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::DeviceAddress")]
    public ulong getDeviceAddress()
    {
        fixed (IBuffer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDeviceAddress>(lpVtbl->getDeviceAddress)(pThis);
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

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getNativeHandle;

        [NativeTypeName("const BufferDesc &() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDesc;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getSharedHandle;

        [NativeTypeName("DeviceAddress () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDeviceAddress;
    }
}
