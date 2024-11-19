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
    public void drawIndirect([NativeTypeName("rhi::GfxCount")] int maxDrawCount, [NativeTypeName("rhi::IBuffer *")] IBuffer* argBuffer, [NativeTypeName("rhi::Offset")] ulong argOffset, [NativeTypeName("rhi::IBuffer *")] IBuffer* countBuffer = null, [NativeTypeName("rhi::Offset")] ulong countOffset = 0)
    {
        lpVtbl->drawIndirect((IRenderPassEncoder*)Unsafe.AsPointer(ref this), maxDrawCount, argBuffer, argOffset, countBuffer, countOffset);
    }

    /// <include file='IRenderPassEncoder.xml' path='doc/member[@name="IRenderPassEncoder.drawIndexedIndirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawIndexedIndirect([NativeTypeName("rhi::GfxCount")] int maxDrawCount, [NativeTypeName("rhi::IBuffer *")] IBuffer* argBuffer, [NativeTypeName("rhi::Offset")] ulong argOffset, [NativeTypeName("rhi::IBuffer *")] IBuffer* countBuffer = null, [NativeTypeName("rhi::Offset")] ulong countOffset = 0)
    {
        lpVtbl->drawIndexedIndirect((IRenderPassEncoder*)Unsafe.AsPointer(ref this), maxDrawCount, argBuffer, argOffset, countBuffer, countOffset);
    }

    /// <include file='IRenderPassEncoder.xml' path='doc/member[@name="IRenderPassEncoder.drawMeshTasks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawMeshTasks([NativeTypeName("rhi::GfxCount")] int x, [NativeTypeName("rhi::GfxCount")] int y, [NativeTypeName("rhi::GfxCount")] int z)
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

        [NativeTypeName("void (const RenderState &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, RenderState*, void> setRenderState;

        [NativeTypeName("void (const DrawArguments &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, DrawArguments*, void> draw;

        [NativeTypeName("void (const DrawArguments &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, DrawArguments*, void> drawIndexed;

        [NativeTypeName("void (GfxCount, IBuffer *, Offset, IBuffer *, Offset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, int, IBuffer*, ulong, IBuffer*, ulong, void> drawIndirect;

        [NativeTypeName("void (GfxCount, IBuffer *, Offset, IBuffer *, Offset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, int, IBuffer*, ulong, IBuffer*, ulong, void> drawIndexedIndirect;

        [NativeTypeName("void (GfxCount, GfxCount, GfxCount) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRenderPassEncoder*, int, int, int, void> drawMeshTasks;
    }
}
