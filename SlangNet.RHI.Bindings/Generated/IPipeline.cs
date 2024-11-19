using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IPipeline.xml' path='doc/member[@name="IPipeline"]/*' />
[NativeTypeName("struct IPipeline : ISlangUnknown")]
public unsafe partial struct IPipeline
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IPipeline*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IPipeline*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IPipeline*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPipeline.xml' path='doc/member[@name="IPipeline.getProgram"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::IShaderProgram *")]
    public IShaderProgram* getProgram()
    {
        return lpVtbl->getProgram((IPipeline*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPipeline.xml' path='doc/member[@name="IPipeline.getNativeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        return lpVtbl->getNativeHandle((IPipeline*)Unsafe.AsPointer(ref this), outHandle);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipeline*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipeline*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipeline*, uint> release;

        [NativeTypeName("IShaderProgram *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipeline*, IShaderProgram*> getProgram;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipeline*, NativeHandle*, int> getNativeHandle;
    }
}
