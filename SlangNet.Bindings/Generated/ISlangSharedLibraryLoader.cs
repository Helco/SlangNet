using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='ISlangSharedLibraryLoader.xml' path='doc/member[@name="ISlangSharedLibraryLoader"]/*' />
[NativeTypeName("struct ISlangSharedLibraryLoader : ISlangUnknown")]
public unsafe partial struct ISlangSharedLibraryLoader
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISlangSharedLibraryLoader* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISlangSharedLibraryLoader* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISlangSharedLibraryLoader* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _loadSharedLibrary(ISlangSharedLibraryLoader* pThis, [NativeTypeName("const char *")] sbyte* path, ISlangSharedLibrary** sharedLibraryOut);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISlangSharedLibraryLoader* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISlangSharedLibraryLoader* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISlangSharedLibraryLoader* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='ISlangSharedLibraryLoader.xml' path='doc/member[@name="ISlangSharedLibraryLoader.loadSharedLibrary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int loadSharedLibrary([NativeTypeName("const char *")] sbyte* path, ISlangSharedLibrary** sharedLibraryOut)
    {
        fixed (ISlangSharedLibraryLoader* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadSharedLibrary>(lpVtbl->loadSharedLibrary)(pThis, path, sharedLibraryOut);
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

        [NativeTypeName("SlangResult (const char *, ISlangSharedLibrary **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr loadSharedLibrary;
    }
}
