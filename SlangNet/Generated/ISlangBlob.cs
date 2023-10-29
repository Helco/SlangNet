using System;
using System.Runtime.InteropServices;

namespace SlangNet;

/// <include file='ISlangBlob.xml' path='doc/member[@name="ISlangBlob"]/*' />
[NativeTypeName("struct ISlangBlob : ISlangUnknown")]
public unsafe partial struct ISlangBlob
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISlangBlob* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISlangBlob* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISlangBlob* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const void *")]
    public delegate void* _getBufferPointer(ISlangBlob* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("size_t")]
    public delegate UIntPtr _getBufferSize(ISlangBlob* pThis);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISlangBlob* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISlangBlob* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISlangBlob* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='ISlangBlob.xml' path='doc/member[@name="ISlangBlob.getBufferPointer"]/*' />
    [return: NativeTypeName("const void *")]
    public void* getBufferPointer()
    {
        fixed (ISlangBlob* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getBufferPointer>(lpVtbl->getBufferPointer)(pThis);
        }
    }

    /// <include file='ISlangBlob.xml' path='doc/member[@name="ISlangBlob.getBufferSize"]/*' />
    [return: NativeTypeName("size_t")]
    public UIntPtr getBufferSize()
    {
        fixed (ISlangBlob* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getBufferSize>(lpVtbl->getBufferSize)(pThis);
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

        [NativeTypeName("const void *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getBufferPointer;

        [NativeTypeName("size_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getBufferSize;
    }
}
