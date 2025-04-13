using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IRenderPassEncoder.xml' path='doc/member[@name="IRenderPassEncoder"]/*' />
[NativeTypeName("struct IRenderPassEncoder : rhi::IPassEncoder")]
public unsafe partial struct IRenderPassEncoder
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IRenderPassEncoder*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IRenderPassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IRenderPassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPassEncoder.pushDebugGroup" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void pushDebugGroup([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor)
    {
        lpVtbl->pushDebugGroup((IRenderPassEncoder*)Unsafe.AsPointer(ref this), name, rgbColor);
    }

    /// <inheritdoc cref="IPassEncoder.popDebugGroup" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void popDebugGroup()
    {
        lpVtbl->popDebugGroup((IRenderPassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPassEncoder.insertDebugMarker" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void insertDebugMarker([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor)
    {
        lpVtbl->insertDebugMarker((IRenderPassEncoder*)Unsafe.AsPointer(ref this), name, rgbColor);
    }

    /// <inheritdoc cref="IPassEncoder.end" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void end()
    {
        lpVtbl->end((IRenderPassEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRenderPassEncoder.xml' path='doc/member[@name="IRenderPassEncoder.bindPipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void bindPipeline([NativeTypeName("rhi::IRenderPipeline *")] IRenderPipeline* pipeline, [NativeTypeName("rhi::IShaderObject *")] IShaderObject* rootObject)
    {
        lpVtbl->bindPipeline((IRenderPassEncoder*)Unsafe.AsPointer(ref this), pipeline, rootObject);
    }

    /// <include file='IRenderPassEncoder.xml' path='doc/member[@name="IRenderPassEncoder.bindPipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::IShaderObject *")]
    public IShaderObject* bindPipeline([NativeTypeName("rhi::IRenderPipeline *")] IRenderPipeline* pipeline)
    {
        return lpVtbl->bindPipeline1((IRenderPassEncoder*)Unsafe.AsPointer(ref this), pipeline);
    }

    /// <include file='IRenderPassEncoder.xml' path='doc/member[@name="IRenderPassEncoder.setRenderState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setRenderState([NativeTypeName("const RenderState &")] RenderState* state)
    {
        lpVtbl->setRenderState((IRenderPassEncoder*)Unsafe.AsPointer(ref this), state);
    }

    /// <include file='IRenderPassEncoder.xml' path='doc/member[@name="IRenderPassEncoder.draw"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void draw([NativeTypeName("const DrawArguments &")] DrawArguments* args)
    {
        lpVtbl->draw((IRenderPassEncoder*)Unsafe.AsPointer(ref this), args);
    }

    /// <include file='IRenderPassEncoder.xml' path='doc/member[@name="IRenderPassEncoder.drawIndexed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawIndexed([NativeTypeName("const DrawArguments &")] DrawArguments* args)
    {
        lpVtbl->drawIndexed((IRenderPassEncoder*)Unsafe.AsPointer(ref this), args);
    }

    /// <include file='IRenderPassEncoder.xml' path='doc/member[@name="IRenderPassEncoder.drawIndirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawIndirect([NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("rhi::BufferOffsetPair")] BufferOffsetPair argBuffer, [NativeTypeName("rhi::BufferOffsetPair")] BufferOffsetPair countBuffer = new BufferOffsetPair())
    {
        lpVtbl->drawIndirect((IRenderPassEncoder*)Unsafe.AsPointer(ref this), maxDrawCount, argBuffer, countBuffer);
    }

    /// <include file='IRenderPassEncoder.xml' path='doc/member[@name="IRenderPassEncoder.drawIndexedIndirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawIndexedIndirect([NativeTypeName("uint32_t")] uint maxDrawCount, [NativeTypeName("rhi::BufferOffsetPair")] BufferOffsetPair argBuffer, [NativeTypeName("rhi::BufferOffsetPair")] BufferOffsetPair countBuffer = new BufferOffsetPair())
    {
        lpVtbl->drawIndexedIndirect((IRenderPassEncoder*)Unsafe.AsPointer(ref this), maxDrawCount, argBuffer, countBuffer);
    }

    /// <include file='IRenderPassEncoder.xml' path='doc/member[@name="IRenderPassEncoder.drawMeshTasks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawMeshTasks([NativeTypeName("uint32_t")] uint x, [NativeTypeName("uint32_t")] uint y, [NativeTypeName("uint32_t")] uint z)
    {
        lpVtbl->drawMeshTasks((IRenderPassEncoder*)Unsafe.AsPointer(ref this), x, y, z);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, uint> release;

        [NativeTypeName("void (const char *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, sbyte*, float*, void> pushDebugGroup;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, void> popDebugGroup;

        [NativeTypeName("void (const char *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, sbyte*, float*, void> insertDebugMarker;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, void> end;

        [NativeTypeName("void (IRenderPipeline *, IShaderObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, IRenderPipeline*, IShaderObject*, void> bindPipeline;

        [NativeTypeName("IShaderObject *(IRenderPipeline *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, IRenderPipeline*, IShaderObject*> bindPipeline1;

        [NativeTypeName("void (const RenderState &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, RenderState*, void> setRenderState;

        [NativeTypeName("void (const DrawArguments &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, DrawArguments*, void> draw;

        [NativeTypeName("void (const DrawArguments &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, DrawArguments*, void> drawIndexed;

        [NativeTypeName("void (uint32_t, BufferOffsetPair, BufferOffsetPair) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, uint, BufferOffsetPair, BufferOffsetPair, void> drawIndirect;

        [NativeTypeName("void (uint32_t, BufferOffsetPair, BufferOffsetPair) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, uint, BufferOffsetPair, BufferOffsetPair, void> drawIndexedIndirect;

        [NativeTypeName("void (uint32_t, uint32_t, uint32_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, uint, uint, uint, void> drawMeshTasks;
    }
}
