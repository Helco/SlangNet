using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='ISlangSharedLibrary_Dep1.xml' path='doc/member[@name="ISlangSharedLibrary_Dep1"]/*' />
[NativeTypeName("struct ISlangSharedLibrary_Dep1 : ISlangUnknown")]
public unsafe partial struct ISlangSharedLibrary_Dep1
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISlangSharedLibrary_Dep1* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISlangSharedLibrary_Dep1* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISlangSharedLibrary_Dep1* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void* _findSymbolAddressByName(ISlangSharedLibrary_Dep1* pThis, [NativeTypeName("const char *")] sbyte* name);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISlangSharedLibrary_Dep1* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISlangSharedLibrary_Dep1* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISlangSharedLibrary_Dep1* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='ISlangSharedLibrary_Dep1.xml' path='doc/member[@name="ISlangSharedLibrary_Dep1.findSymbolAddressByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void* findSymbolAddressByName([NativeTypeName("const char *")] sbyte* name)
    {
        fixed (ISlangSharedLibrary_Dep1* pThis = &this)
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

        [NativeTypeName("void *(const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr findSymbolAddressByName;
    }
}
