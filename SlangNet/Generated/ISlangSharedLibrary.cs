using System;
using System.Runtime.InteropServices;

namespace SlangNet;

/// <include file='ISlangSharedLibrary.xml' path='doc/member[@name="ISlangSharedLibrary"]/*' />
[NativeTypeName("struct ISlangSharedLibrary : ISlangCastable")]
public unsafe partial struct ISlangSharedLibrary
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISlangSharedLibrary* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISlangSharedLibrary* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISlangSharedLibrary* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void* _castAs(ISlangSharedLibrary* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* guid);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void* _findSymbolAddressByName(ISlangSharedLibrary* pThis, [NativeTypeName("const char *")] sbyte* name);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISlangSharedLibrary* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISlangSharedLibrary* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISlangSharedLibrary* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangCastable.castAs" />
    public void* castAs([NativeTypeName("const SlangUUID &")] SlangUUID* guid)
    {
        fixed (ISlangSharedLibrary* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_castAs>(lpVtbl->castAs)(pThis, guid);
        }
    }

    /// <include file='ISlangSharedLibrary.xml' path='doc/member[@name="ISlangSharedLibrary.findSymbolAddressByName"]/*' />
    public void* findSymbolAddressByName([NativeTypeName("const char *")] sbyte* name)
    {
        fixed (ISlangSharedLibrary* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_findSymbolAddressByName>(lpVtbl->findSymbolAddressByName)(pThis, name);
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

        [NativeTypeName("void *(const SlangUUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr castAs;

        [NativeTypeName("void *(const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr findSymbolAddressByName;
    }
}
