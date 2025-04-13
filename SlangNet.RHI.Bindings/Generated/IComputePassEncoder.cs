using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IComputePassEncoder.xml' path='doc/member[@name="IComputePassEncoder"]/*' />
[NativeTypeName("struct IComputePassEncoder : rhi::IPassEncoder")]
public unsafe partial struct IComputePassEncoder
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IComputePassEncoder*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IComputePassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IComputePassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPassEncoder.pushDebugGroup" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void pushDebugGroup([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor)
    {
        lpVtbl->pushDebugGroup((IComputePassEncoder*)Unsafe.AsPointer(ref this), name, rgbColor);
    }

    /// <inheritdoc cref="IPassEncoder.popDebugGroup" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void popDebugGroup()
    {
        lpVtbl->popDebugGroup((IComputePassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPassEncoder.insertDebugMarker" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void insertDebugMarker([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor)
    {
        lpVtbl->insertDebugMarker((IComputePassEncoder*)Unsafe.AsPointer(ref this), name, rgbColor);
    }

    /// <inheritdoc cref="IPassEncoder.end" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void end()
    {
        lpVtbl->end((IComputePassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IComputePassEncoder.xml' path='doc/member[@name="IComputePassEncoder.bindPipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void bindPipeline([NativeTypeName("rhi::IComputePipeline *")] IComputePipeline* pipeline, [NativeTypeName("rhi::IShaderObject *")] IShaderObject* rootObject)
    {
        lpVtbl->bindPipeline((IComputePassEncoder*)Unsafe.AsPointer(ref this), pipeline, rootObject);
    }

    /// <include file='IComputePassEncoder.xml' path='doc/member[@name="IComputePassEncoder.bindPipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::IShaderObject *")]
    public IShaderObject* bindPipeline([NativeTypeName("rhi::IComputePipeline *")] IComputePipeline* pipeline)
    {
        return lpVtbl->bindPipeline1((IComputePassEncoder*)Unsafe.AsPointer(ref this), pipeline);
    }

    /// <include file='IComputePassEncoder.xml' path='doc/member[@name="IComputePassEncoder.dispatchCompute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void dispatchCompute([NativeTypeName("uint32_t")] uint x, [NativeTypeName("uint32_t")] uint y, [NativeTypeName("uint32_t")] uint z)
    {
        lpVtbl->dispatchCompute((IComputePassEncoder*)Unsafe.AsPointer(ref this), x, y, z);
    }

    /// <include file='IComputePassEncoder.xml' path='doc/member[@name="IComputePassEncoder.dispatchComputeIndirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void dispatchComputeIndirect([NativeTypeName("rhi::BufferOffsetPair")] BufferOffsetPair argBuffer)
    {
        lpVtbl->dispatchComputeIndirect((IComputePassEncoder*)Unsafe.AsPointer(ref this), argBuffer);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IComputePassEncoder*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IComputePassEncoder*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IComputePassEncoder*, uint> release;

        [NativeTypeName("void (const char *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IComputePassEncoder*, sbyte*, float*, void> pushDebugGroup;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IComputePassEncoder*, void> popDebugGroup;

        [NativeTypeName("void (const char *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IComputePassEncoder*, sbyte*, float*, void> insertDebugMarker;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IComputePassEncoder*, void> end;

        [NativeTypeName("void (IComputePipeline *, IShaderObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IComputePassEncoder*, IComputePipeline*, IShaderObject*, void> bindPipeline;

        [NativeTypeName("IShaderObject *(IComputePipeline *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IComputePassEncoder*, IComputePipeline*, IShaderObject*> bindPipeline1;

        [NativeTypeName("void (uint32_t, uint32_t, uint32_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IComputePassEncoder*, uint, uint, uint, void> dispatchCompute;

        [NativeTypeName("void (BufferOffsetPair) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IComputePassEncoder*, BufferOffsetPair, void> dispatchComputeIndirect;
    }
}
