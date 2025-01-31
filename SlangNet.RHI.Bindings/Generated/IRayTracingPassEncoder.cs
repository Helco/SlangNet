using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IRayTracingPassEncoder.xml' path='doc/member[@name="IRayTracingPassEncoder"]/*' />
[NativeTypeName("struct IRayTracingPassEncoder : rhi::IPassEncoder")]
public unsafe partial struct IRayTracingPassEncoder
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IRayTracingPassEncoder*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IRayTracingPassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IRayTracingPassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPassEncoder.pushDebugGroup" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void pushDebugGroup([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor)
    {
        lpVtbl->pushDebugGroup((IRayTracingPassEncoder*)Unsafe.AsPointer(ref this), name, rgbColor);
    }

    /// <inheritdoc cref="IPassEncoder.popDebugGroup" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void popDebugGroup()
    {
        lpVtbl->popDebugGroup((IRayTracingPassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPassEncoder.insertDebugMarker" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void insertDebugMarker([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor)
    {
        lpVtbl->insertDebugMarker((IRayTracingPassEncoder*)Unsafe.AsPointer(ref this), name, rgbColor);
    }

    /// <inheritdoc cref="IPassEncoder.end" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void end()
    {
        lpVtbl->end((IRayTracingPassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRayTracingPassEncoder.xml' path='doc/member[@name="IRayTracingPassEncoder.setRayTracingState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setRayTracingState([NativeTypeName("const RayTracingState &")] RayTracingState* state)
    {
        lpVtbl->setRayTracingState((IRayTracingPassEncoder*)Unsafe.AsPointer(ref this), state);
    }

    /// <include file='IRayTracingPassEncoder.xml' path='doc/member[@name="IRayTracingPassEncoder.dispatchRays"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void dispatchRays([NativeTypeName("uint32_t")] uint rayGenShaderIndex, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth)
    {
        lpVtbl->dispatchRays((IRayTracingPassEncoder*)Unsafe.AsPointer(ref this), rayGenShaderIndex, width, height, depth);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRayTracingPassEncoder*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRayTracingPassEncoder*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRayTracingPassEncoder*, uint> release;

        [NativeTypeName("void (const char *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRayTracingPassEncoder*, sbyte*, float*, void> pushDebugGroup;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRayTracingPassEncoder*, void> popDebugGroup;

        [NativeTypeName("void (const char *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRayTracingPassEncoder*, sbyte*, float*, void> insertDebugMarker;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRayTracingPassEncoder*, void> end;

        [NativeTypeName("void (const RayTracingState &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRayTracingPassEncoder*, RayTracingState*, void> setRayTracingState;

        [NativeTypeName("void (uint32_t, uint32_t, uint32_t, uint32_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRayTracingPassEncoder*, uint, uint, uint, uint, void> dispatchRays;
    }
}
