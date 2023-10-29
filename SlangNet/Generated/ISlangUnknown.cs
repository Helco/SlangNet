using System;
using System.Runtime.InteropServices;

namespace SlangNet;

/// <include file='ISlangUnknown.xml' path='doc/member[@name="ISlangUnknown"]/*' />
public unsafe partial struct ISlangUnknown
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISlangUnknown* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISlangUnknown* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISlangUnknown* pThis);

    /// <include file='ISlangUnknown.xml' path='doc/member[@name="ISlangUnknown.queryInterface"]/*' />
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISlangUnknown* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <include file='ISlangUnknown.xml' path='doc/member[@name="ISlangUnknown.addRef"]/*' />
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISlangUnknown* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <include file='ISlangUnknown.xml' path='doc/member[@name="ISlangUnknown.release"]/*' />
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISlangUnknown* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
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
    }
}
