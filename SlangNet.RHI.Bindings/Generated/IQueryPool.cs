using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IQueryPool.xml' path='doc/member[@name="IQueryPool"]/*' />
[NativeTypeName("struct IQueryPool : ISlangUnknown")]
public unsafe partial struct IQueryPool
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IQueryPool*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IQueryPool*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IQueryPool*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IQueryPool.xml' path='doc/member[@name="IQueryPool.getResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getResult([NativeTypeName("rhi::GfxIndex")] int queryIndex, [NativeTypeName("rhi::GfxCount")] int count, [NativeTypeName("uint64_t *")] ulong* data)
    {
        return lpVtbl->getResult((IQueryPool*)Unsafe.AsPointer(ref this), queryIndex, count, data);
    }

    /// <include file='IQueryPool.xml' path='doc/member[@name="IQueryPool.reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int reset()
    {
        return lpVtbl->reset((IQueryPool*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IQueryPool*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IQueryPool*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IQueryPool*, uint> release;

        [NativeTypeName("Result (GfxIndex, GfxCount, uint64_t *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IQueryPool*, int, int, ulong*, int> getResult;

        [NativeTypeName("Result () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IQueryPool*, int> reset;
    }
}
