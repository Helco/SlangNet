using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder"]/*' />
[NativeTypeName("struct ICommandEncoder : ISlangUnknown")]
public unsafe partial struct ICommandEncoder
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((ICommandEncoder*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((ICommandEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((ICommandEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.copyBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void copyBuffer([NativeTypeName("rhi::IBuffer *")] IBuffer* dst, [NativeTypeName("rhi::Offset")] ulong dstOffset, [NativeTypeName("rhi::IBuffer *")] IBuffer* src, [NativeTypeName("rhi::Offset")] ulong srcOffset, [NativeTypeName("rhi::Size")] ulong size)
    {
        lpVtbl->copyBuffer((ICommandEncoder*)Unsafe.AsPointer(ref this), dst, dstOffset, src, srcOffset, size);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.copyTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void copyTexture([NativeTypeName("rhi::ITexture *")] ITexture* dst, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange dstSubresource, [NativeTypeName("rhi::Offset3D")] Offset3D dstOffset, [NativeTypeName("rhi::ITexture *")] ITexture* src, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange srcSubresource, [NativeTypeName("rhi::Offset3D")] Offset3D srcOffset, [NativeTypeName("rhi::Extents")] Extents extent)
    {
        lpVtbl->copyTexture((ICommandEncoder*)Unsafe.AsPointer(ref this), dst, dstSubresource, dstOffset, src, srcSubresource, srcOffset, extent);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.copyTextureToBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void copyTextureToBuffer([NativeTypeName("rhi::IBuffer *")] IBuffer* dst, [NativeTypeName("rhi::Offset")] ulong dstOffset, [NativeTypeName("rhi::Size")] ulong dstSize, [NativeTypeName("rhi::Size")] ulong dstRowStride, [NativeTypeName("rhi::ITexture *")] ITexture* src, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange srcSubresource, [NativeTypeName("rhi::Offset3D")] Offset3D srcOffset, [NativeTypeName("rhi::Extents")] Extents extent)
    {
        lpVtbl->copyTextureToBuffer((ICommandEncoder*)Unsafe.AsPointer(ref this), dst, dstOffset, dstSize, dstRowStride, src, srcSubresource, srcOffset, extent);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.uploadTextureData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void uploadTextureData([NativeTypeName("rhi::ITexture *")] ITexture* dst, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange subresourceRange, [NativeTypeName("rhi::Offset3D")] Offset3D offset, [NativeTypeName("rhi::Extents")] Extents extent, [NativeTypeName("rhi::SubresourceData *")] SubresourceData* subresourceData, [NativeTypeName("rhi::GfxCount")] int subresourceDataCount)
    {
        lpVtbl->uploadTextureData((ICommandEncoder*)Unsafe.AsPointer(ref this), dst, subresourceRange, offset, extent, subresourceData, subresourceDataCount);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.uploadBufferData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void uploadBufferData([NativeTypeName("rhi::IBuffer *")] IBuffer* dst, [NativeTypeName("rhi::Offset")] ulong offset, [NativeTypeName("rhi::Size")] ulong size, void* data)
    {
        lpVtbl->uploadBufferData((ICommandEncoder*)Unsafe.AsPointer(ref this), dst, offset, size, data);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.clearBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void clearBuffer([NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("const BufferRange *")] BufferRange* range = null)
    {
        lpVtbl->clearBuffer((ICommandEncoder*)Unsafe.AsPointer(ref this), buffer, range);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.clearTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void clearTexture([NativeTypeName("rhi::ITexture *")] ITexture* texture, [NativeTypeName("const ClearValue &")] ClearValue* clearValue = null, [NativeTypeName("const SubresourceRange *")] SubresourceRange* subresourceRange = null, bool clearDepth = true, bool clearStencil = true)
    {
        lpVtbl->clearTexture((ICommandEncoder*)Unsafe.AsPointer(ref this), texture, clearValue, subresourceRange, clearDepth, clearStencil);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.resolveQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void resolveQuery([NativeTypeName("rhi::IQueryPool *")] IQueryPool* queryPool, [NativeTypeName("rhi::GfxIndex")] int index, [NativeTypeName("rhi::GfxCount")] int count, [NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("rhi::Offset")] ulong offset)
    {
        lpVtbl->resolveQuery((ICommandEncoder*)Unsafe.AsPointer(ref this), queryPool, index, count, buffer, offset);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.beginRenderPass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void beginRenderPass([NativeTypeName("const RenderPassDesc &")] RenderPassDesc* desc)
    {
        lpVtbl->beginRenderPass((ICommandEncoder*)Unsafe.AsPointer(ref this), desc);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.endRenderPass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void endRenderPass()
    {
        lpVtbl->endRenderPass((ICommandEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.setRenderState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setRenderState([NativeTypeName("const RenderState &")] RenderState* state)
    {
        lpVtbl->setRenderState((ICommandEncoder*)Unsafe.AsPointer(ref this), state);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.draw"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void draw([NativeTypeName("const DrawArguments &")] DrawArguments* args)
    {
        lpVtbl->draw((ICommandEncoder*)Unsafe.AsPointer(ref this), args);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.drawIndexed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawIndexed([NativeTypeName("const DrawArguments &")] DrawArguments* args)
    {
        lpVtbl->drawIndexed((ICommandEncoder*)Unsafe.AsPointer(ref this), args);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.drawIndirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawIndirect([NativeTypeName("rhi::GfxCount")] int maxDrawCount, [NativeTypeName("rhi::IBuffer *")] IBuffer* argBuffer, [NativeTypeName("rhi::Offset")] ulong argOffset, [NativeTypeName("rhi::IBuffer *")] IBuffer* countBuffer = null, [NativeTypeName("rhi::Offset")] ulong countOffset = 0)
    {
        lpVtbl->drawIndirect((ICommandEncoder*)Unsafe.AsPointer(ref this), maxDrawCount, argBuffer, argOffset, countBuffer, countOffset);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.drawIndexedIndirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawIndexedIndirect([NativeTypeName("rhi::GfxCount")] int maxDrawCount, [NativeTypeName("rhi::IBuffer *")] IBuffer* argBuffer, [NativeTypeName("rhi::Offset")] ulong argOffset, [NativeTypeName("rhi::IBuffer *")] IBuffer* countBuffer = null, [NativeTypeName("rhi::Offset")] ulong countOffset = 0)
    {
        lpVtbl->drawIndexedIndirect((ICommandEncoder*)Unsafe.AsPointer(ref this), maxDrawCount, argBuffer, argOffset, countBuffer, countOffset);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.drawMeshTasks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawMeshTasks(int x, int y, int z)
    {
        lpVtbl->drawMeshTasks((ICommandEncoder*)Unsafe.AsPointer(ref this), x, y, z);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.beginComputePass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void beginComputePass()
    {
        lpVtbl->beginComputePass((ICommandEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.endComputePass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void endComputePass()
    {
        lpVtbl->endComputePass((ICommandEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.setComputeState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setComputeState([NativeTypeName("const ComputeState &")] ComputeState* state)
    {
        lpVtbl->setComputeState((ICommandEncoder*)Unsafe.AsPointer(ref this), state);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.dispatchCompute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void dispatchCompute(int x, int y, int z)
    {
        lpVtbl->dispatchCompute((ICommandEncoder*)Unsafe.AsPointer(ref this), x, y, z);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.dispatchComputeIndirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void dispatchComputeIndirect([NativeTypeName("rhi::IBuffer *")] IBuffer* argBuffer, [NativeTypeName("rhi::Offset")] ulong offset)
    {
        lpVtbl->dispatchComputeIndirect((ICommandEncoder*)Unsafe.AsPointer(ref this), argBuffer, offset);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.beginRayTracingPass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void beginRayTracingPass()
    {
        lpVtbl->beginRayTracingPass((ICommandEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.endRayTracingPass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void endRayTracingPass()
    {
        lpVtbl->endRayTracingPass((ICommandEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.setRayTracingState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setRayTracingState([NativeTypeName("const RayTracingState &")] RayTracingState* state)
    {
        lpVtbl->setRayTracingState((ICommandEncoder*)Unsafe.AsPointer(ref this), state);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.dispatchRays"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void dispatchRays([NativeTypeName("rhi::GfxIndex")] int rayGenShaderIndex, [NativeTypeName("rhi::GfxCount")] int width, [NativeTypeName("rhi::GfxCount")] int height, [NativeTypeName("rhi::GfxCount")] int depth)
    {
        lpVtbl->dispatchRays((ICommandEncoder*)Unsafe.AsPointer(ref this), rayGenShaderIndex, width, height, depth);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.buildAccelerationStructure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void buildAccelerationStructure([NativeTypeName("const AccelerationStructureBuildDesc &")] AccelerationStructureBuildDesc* desc, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* dst, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* src, [NativeTypeName("rhi::BufferWithOffset")] BufferWithOffset scratchBuffer, [NativeTypeName("rhi::GfxCount")] int propertyQueryCount, [NativeTypeName("rhi::AccelerationStructureQueryDesc *")] AccelerationStructureQueryDesc* queryDescs)
    {
        lpVtbl->buildAccelerationStructure((ICommandEncoder*)Unsafe.AsPointer(ref this), desc, dst, src, scratchBuffer, propertyQueryCount, queryDescs);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.copyAccelerationStructure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void copyAccelerationStructure([NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* dst, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* src, [NativeTypeName("rhi::AccelerationStructureCopyMode")] AccelerationStructureCopyMode mode)
    {
        lpVtbl->copyAccelerationStructure((ICommandEncoder*)Unsafe.AsPointer(ref this), dst, src, mode);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.queryAccelerationStructureProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void queryAccelerationStructureProperties([NativeTypeName("rhi::GfxCount")] int accelerationStructureCount, [NativeTypeName("IAccelerationStructure *const *")] IAccelerationStructure** accelerationStructures, [NativeTypeName("rhi::GfxCount")] int queryCount, [NativeTypeName("rhi::AccelerationStructureQueryDesc *")] AccelerationStructureQueryDesc* queryDescs)
    {
        lpVtbl->queryAccelerationStructureProperties((ICommandEncoder*)Unsafe.AsPointer(ref this), accelerationStructureCount, accelerationStructures, queryCount, queryDescs);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.serializeAccelerationStructure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void serializeAccelerationStructure([NativeTypeName("rhi::BufferWithOffset")] BufferWithOffset dst, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* src)
    {
        lpVtbl->serializeAccelerationStructure((ICommandEncoder*)Unsafe.AsPointer(ref this), dst, src);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.deserializeAccelerationStructure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void deserializeAccelerationStructure([NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* dst, [NativeTypeName("rhi::BufferWithOffset")] BufferWithOffset src)
    {
        lpVtbl->deserializeAccelerationStructure((ICommandEncoder*)Unsafe.AsPointer(ref this), dst, src);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.setBufferState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setBufferState([NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("rhi::ResourceState")] ResourceState state)
    {
        lpVtbl->setBufferState((ICommandEncoder*)Unsafe.AsPointer(ref this), buffer, state);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.setTextureState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setTextureState([NativeTypeName("rhi::ITexture *")] ITexture* texture, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange subresourceRange, [NativeTypeName("rhi::ResourceState")] ResourceState state)
    {
        lpVtbl->setTextureState((ICommandEncoder*)Unsafe.AsPointer(ref this), texture, subresourceRange, state);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.beginDebugEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void beginDebugEvent([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor)
    {
        lpVtbl->beginDebugEvent((ICommandEncoder*)Unsafe.AsPointer(ref this), name, rgbColor);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.endDebugEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void endDebugEvent()
    {
        lpVtbl->endDebugEvent((ICommandEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.writeTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void writeTimestamp([NativeTypeName("rhi::IQueryPool *")] IQueryPool* queryPool, [NativeTypeName("rhi::GfxIndex")] int queryIndex)
    {
        lpVtbl->writeTimestamp((ICommandEncoder*)Unsafe.AsPointer(ref this), queryPool, queryIndex);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.finish"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int finish(ICommandBuffer** outCommandBuffer)
    {
        return lpVtbl->finish((ICommandEncoder*)Unsafe.AsPointer(ref this), outCommandBuffer);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.getNativeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        return lpVtbl->getNativeHandle((ICommandEncoder*)Unsafe.AsPointer(ref this), outHandle);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, uint> release;

        [NativeTypeName("void (IBuffer *, Offset, IBuffer *, Offset, Size) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IBuffer*, ulong, IBuffer*, ulong, ulong, void> copyBuffer;

        [NativeTypeName("void (ITexture *, SubresourceRange, Offset3D, ITexture *, SubresourceRange, Offset3D, Extents) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, ITexture*, SubresourceRange, Offset3D, ITexture*, SubresourceRange, Offset3D, Extents, void> copyTexture;

        [NativeTypeName("void (IBuffer *, Offset, Size, Size, ITexture *, SubresourceRange, Offset3D, Extents) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IBuffer*, ulong, ulong, ulong, ITexture*, SubresourceRange, Offset3D, Extents, void> copyTextureToBuffer;

        [NativeTypeName("void (ITexture *, SubresourceRange, Offset3D, Extents, SubresourceData *, GfxCount) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, ITexture*, SubresourceRange, Offset3D, Extents, SubresourceData*, int, void> uploadTextureData;

        [NativeTypeName("void (IBuffer *, Offset, Size, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IBuffer*, ulong, ulong, void*, void> uploadBufferData;

        [NativeTypeName("void (IBuffer *, const BufferRange *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IBuffer*, BufferRange*, void> clearBuffer;

        [NativeTypeName("void (ITexture *, const ClearValue &, const SubresourceRange *, bool, bool) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, ITexture*, ClearValue*, SubresourceRange*, bool, bool, void> clearTexture;

        [NativeTypeName("void (IQueryPool *, GfxIndex, GfxCount, IBuffer *, Offset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IQueryPool*, int, int, IBuffer*, ulong, void> resolveQuery;

        [NativeTypeName("void (const RenderPassDesc &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, RenderPassDesc*, void> beginRenderPass;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, void> endRenderPass;

        [NativeTypeName("void (const RenderState &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, RenderState*, void> setRenderState;

        [NativeTypeName("void (const DrawArguments &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, DrawArguments*, void> draw;

        [NativeTypeName("void (const DrawArguments &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, DrawArguments*, void> drawIndexed;

        [NativeTypeName("void (GfxCount, IBuffer *, Offset, IBuffer *, Offset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, int, IBuffer*, ulong, IBuffer*, ulong, void> drawIndirect;

        [NativeTypeName("void (GfxCount, IBuffer *, Offset, IBuffer *, Offset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, int, IBuffer*, ulong, IBuffer*, ulong, void> drawIndexedIndirect;

        [NativeTypeName("void (int, int, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, int, int, int, void> drawMeshTasks;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, void> beginComputePass;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, void> endComputePass;

        [NativeTypeName("void (const ComputeState &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, ComputeState*, void> setComputeState;

        [NativeTypeName("void (int, int, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, int, int, int, void> dispatchCompute;

        [NativeTypeName("void (IBuffer *, Offset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IBuffer*, ulong, void> dispatchComputeIndirect;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, void> beginRayTracingPass;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, void> endRayTracingPass;

        [NativeTypeName("void (const RayTracingState &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, RayTracingState*, void> setRayTracingState;

        [NativeTypeName("void (GfxIndex, GfxCount, GfxCount, GfxCount) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, int, int, int, int, void> dispatchRays;

        [NativeTypeName("void (const AccelerationStructureBuildDesc &, IAccelerationStructure *, IAccelerationStructure *, BufferWithOffset, GfxCount, AccelerationStructureQueryDesc *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, AccelerationStructureBuildDesc*, IAccelerationStructure*, IAccelerationStructure*, BufferWithOffset, int, AccelerationStructureQueryDesc*, void> buildAccelerationStructure;

        [NativeTypeName("void (IAccelerationStructure *, IAccelerationStructure *, AccelerationStructureCopyMode) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IAccelerationStructure*, IAccelerationStructure*, AccelerationStructureCopyMode, void> copyAccelerationStructure;

        [NativeTypeName("void (GfxCount, IAccelerationStructure *const *, GfxCount, AccelerationStructureQueryDesc *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, int, IAccelerationStructure**, int, AccelerationStructureQueryDesc*, void> queryAccelerationStructureProperties;

        [NativeTypeName("void (BufferWithOffset, IAccelerationStructure *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, BufferWithOffset, IAccelerationStructure*, void> serializeAccelerationStructure;

        [NativeTypeName("void (IAccelerationStructure *, BufferWithOffset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IAccelerationStructure*, BufferWithOffset, void> deserializeAccelerationStructure;

        [NativeTypeName("void (IBuffer *, ResourceState) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IBuffer*, ResourceState, void> setBufferState;

        [NativeTypeName("void (ITexture *, SubresourceRange, ResourceState) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, ITexture*, SubresourceRange, ResourceState, void> setTextureState;

        [NativeTypeName("void (const char *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, sbyte*, float*, void> beginDebugEvent;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, void> endDebugEvent;

        [NativeTypeName("void (IQueryPool *, GfxIndex) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IQueryPool*, int, void> writeTimestamp;

        [NativeTypeName("Result (ICommandBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, ICommandBuffer**, int> finish;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, NativeHandle*, int> getNativeHandle;
    }
}
