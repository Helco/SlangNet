using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='ISlangFileSystem.xml' path='doc/member[@name="ISlangFileSystem"]/*' />
[NativeTypeName("struct ISlangFileSystem : ISlangCastable")]
public unsafe partial struct ISlangFileSystem
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISlangFileSystem* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISlangFileSystem* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISlangFileSystem* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void* _castAs(ISlangFileSystem* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* guid);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _loadFile(ISlangFileSystem* pThis, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** outBlob);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISlangFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISlangFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISlangFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangCastable.castAs" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void* castAs([NativeTypeName("const SlangUUID &")] SlangUUID* guid)
    {
        fixed (ISlangFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_castAs>(lpVtbl->castAs)(pThis, guid);
        }
    }

    /// <include file='ISlangFileSystem.xml' path='doc/member[@name="ISlangFileSystem.loadFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int loadFile([NativeTypeName("const char *")] sbyte* path, ISlangBlob** outBlob)
    {
        fixed (ISlangFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadFile>(lpVtbl->loadFile)(pThis, path, outBlob);
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

        [NativeTypeName("SlangResult (const char *, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr loadFile;
    }
}
