using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IPassEncoder.xml' path='doc/member[@name="IPassEncoder"]/*' />
[NativeTypeName("struct IPassEncoder : ISlangUnknown")]
public unsafe partial struct IPassEncoder
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IPassEncoder*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IPassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IPassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPassEncoder.xml' path='doc/member[@name="IPassEncoder.pushDebugGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void pushDebugGroup([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor)
    {
        lpVtbl->pushDebugGroup((IPassEncoder*)Unsafe.AsPointer(ref this), name, rgbColor);
    }

    /// <include file='IPassEncoder.xml' path='doc/member[@name="IPassEncoder.popDebugGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void popDebugGroup()
    {
        lpVtbl->popDebugGroup((IPassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPassEncoder.xml' path='doc/member[@name="IPassEncoder.insertDebugMarker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void insertDebugMarker([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor)
    {
        lpVtbl->insertDebugMarker((IPassEncoder*)Unsafe.AsPointer(ref this), name, rgbColor);
    }

    /// <include file='IPassEncoder.xml' path='doc/member[@name="IPassEncoder.end"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void end()
    {
        lpVtbl->end((IPassEncoder*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPassEncoder*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPassEncoder*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPassEncoder*, uint> release;

        [NativeTypeName("void (const char *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPassEncoder*, sbyte*, float*, void> pushDebugGroup;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPassEncoder*, void> popDebugGroup;

        [NativeTypeName("void (const char *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPassEncoder*, sbyte*, float*, void> insertDebugMarker;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPassEncoder*, void> end;
    }
}
