using SlangNet.Unsafe;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IPersistentShaderCache.xml' path='doc/member[@name="IPersistentShaderCache"]/*' />
[NativeTypeName("struct IPersistentShaderCache : ISlangUnknown")]
public unsafe partial struct IPersistentShaderCache
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(IPersistentShaderCache* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(IPersistentShaderCache* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(IPersistentShaderCache* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _writeCache(IPersistentShaderCache* pThis, ISlangBlob* key, ISlangBlob* data);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _queryCache(IPersistentShaderCache* pThis, ISlangBlob* key, ISlangBlob** outData);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (IPersistentShaderCache* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (IPersistentShaderCache* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (IPersistentShaderCache* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='IPersistentShaderCache.xml' path='doc/member[@name="IPersistentShaderCache.writeCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int writeCache(ISlangBlob* key, ISlangBlob* data)
    {
        fixed (IPersistentShaderCache* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_writeCache>(lpVtbl->writeCache)(pThis, key, data);
        }
    }

    /// <include file='IPersistentShaderCache.xml' path='doc/member[@name="IPersistentShaderCache.queryCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int queryCache(ISlangBlob* key, ISlangBlob** outData)
    {
        fixed (IPersistentShaderCache* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryCache>(lpVtbl->queryCache)(pThis, key, outData);
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

        [NativeTypeName("Result (ISlangBlob *, ISlangBlob *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr writeCache;

        [NativeTypeName("Result (ISlangBlob *, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr queryCache;
    }
}
