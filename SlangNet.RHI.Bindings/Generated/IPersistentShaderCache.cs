using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IPersistentShaderCache.xml' path='doc/member[@name="IPersistentShaderCache"]/*' />
[NativeTypeName("struct IPersistentShaderCache : ISlangUnknown")]
public unsafe partial struct IPersistentShaderCache
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IPersistentShaderCache*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IPersistentShaderCache*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IPersistentShaderCache*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPersistentShaderCache.xml' path='doc/member[@name="IPersistentShaderCache.writeCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int writeCache([NativeTypeName("ISlangBlob *")] SlangNet.Unsafe.ISlangBlob* key, [NativeTypeName("ISlangBlob *")] SlangNet.Unsafe.ISlangBlob* data)
    {
        return lpVtbl->writeCache((IPersistentShaderCache*)Unsafe.AsPointer(ref this), key, data);
    }

    /// <include file='IPersistentShaderCache.xml' path='doc/member[@name="IPersistentShaderCache.queryCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int queryCache([NativeTypeName("ISlangBlob *")] SlangNet.Unsafe.ISlangBlob* key, [NativeTypeName("ISlangBlob **")] SlangNet.Unsafe.ISlangBlob** outData)
    {
        return lpVtbl->queryCache((IPersistentShaderCache*)Unsafe.AsPointer(ref this), key, outData);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPersistentShaderCache*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPersistentShaderCache*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPersistentShaderCache*, uint> release;

        [NativeTypeName("Result (ISlangBlob *, ISlangBlob *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPersistentShaderCache*, SlangNet.Unsafe.ISlangBlob*, SlangNet.Unsafe.ISlangBlob*, int> writeCache;

        [NativeTypeName("Result (ISlangBlob *, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPersistentShaderCache*, SlangNet.Unsafe.ISlangBlob*, SlangNet.Unsafe.ISlangBlob**, int> queryCache;
    }
}
