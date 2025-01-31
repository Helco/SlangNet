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

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.beginRenderPass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::IRenderPassEncoder *")]
    public IRenderPassEncoder* beginRenderPass([NativeTypeName("const RenderPassDesc &")] RenderPassDesc* desc)
    {
        return lpVtbl->beginRenderPass((ICommandEncoder*)Unsafe.AsPointer(ref this), desc);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.beginComputePass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::IComputePassEncoder *")]
    public IComputePassEncoder* beginComputePass()
    {
        return lpVtbl->beginComputePass((ICommandEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.beginRayTracingPass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::IRayTracingPassEncoder *")]
    public IRayTracingPassEncoder* beginRayTracingPass()
    {
        return lpVtbl->beginRayTracingPass((ICommandEncoder*)Unsafe.AsPointer(ref this));
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
    public void uploadTextureData([NativeTypeName("rhi::ITexture *")] ITexture* dst, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange subresourceRange, [NativeTypeName("rhi::Offset3D")] Offset3D offset, [NativeTypeName("rhi::Extents")] Extents extent, [NativeTypeName("rhi::SubresourceData *")] SubresourceData* subresourceData, [NativeTypeName("uint32_t")] uint subresourceDataCount)
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
    public void resolveQuery([NativeTypeName("rhi::IQueryPool *")] IQueryPool* queryPool, [NativeTypeName("uint32_t")] uint index, [NativeTypeName("uint32_t")] uint count, [NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("uint64_t")] ulong offset)
    {
        lpVtbl->resolveQuery((ICommandEncoder*)Unsafe.AsPointer(ref this), queryPool, index, count, buffer, offset);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.buildAccelerationStructure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void buildAccelerationStructure([NativeTypeName("const AccelerationStructureBuildDesc &")] AccelerationStructureBuildDesc* desc, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* dst, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* src, [NativeTypeName("rhi::BufferWithOffset")] BufferWithOffset scratchBuffer, [NativeTypeName("uint32_t")] uint propertyQueryCount, [NativeTypeName("rhi::AccelerationStructureQueryDesc *")] AccelerationStructureQueryDesc* queryDescs)
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
    public void queryAccelerationStructureProperties([NativeTypeName("uint32_t")] uint accelerationStructureCount, IAccelerationStructure** accelerationStructures, [NativeTypeName("uint32_t")] uint queryCount, [NativeTypeName("rhi::AccelerationStructureQueryDesc *")] AccelerationStructureQueryDesc* queryDescs)
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

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.pushDebugGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void pushDebugGroup([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor)
    {
        lpVtbl->pushDebugGroup((ICommandEncoder*)Unsafe.AsPointer(ref this), name, rgbColor);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.popDebugGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void popDebugGroup()
    {
        lpVtbl->popDebugGroup((ICommandEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.insertDebugMarker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void insertDebugMarker([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor)
    {
        lpVtbl->insertDebugMarker((ICommandEncoder*)Unsafe.AsPointer(ref this), name, rgbColor);
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.writeTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void writeTimestamp([NativeTypeName("rhi::IQueryPool *")] IQueryPool* queryPool, [NativeTypeName("uint32_t")] uint queryIndex)
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

        [NativeTypeName("IRenderPassEncoder *(const RenderPassDesc &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, RenderPassDesc*, IRenderPassEncoder*> beginRenderPass;

        [NativeTypeName("IComputePassEncoder *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IComputePassEncoder*> beginComputePass;

        [NativeTypeName("IRayTracingPassEncoder *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IRayTracingPassEncoder*> beginRayTracingPass;

        [NativeTypeName("void (IBuffer *, Offset, IBuffer *, Offset, Size) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IBuffer*, ulong, IBuffer*, ulong, ulong, void> copyBuffer;

        [NativeTypeName("void (ITexture *, SubresourceRange, Offset3D, ITexture *, SubresourceRange, Offset3D, Extents) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, ITexture*, SubresourceRange, Offset3D, ITexture*, SubresourceRange, Offset3D, Extents, void> copyTexture;

        [NativeTypeName("void (IBuffer *, Offset, Size, Size, ITexture *, SubresourceRange, Offset3D, Extents) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IBuffer*, ulong, ulong, ulong, ITexture*, SubresourceRange, Offset3D, Extents, void> copyTextureToBuffer;

        [NativeTypeName("void (ITexture *, SubresourceRange, Offset3D, Extents, SubresourceData *, uint32_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, ITexture*, SubresourceRange, Offset3D, Extents, SubresourceData*, uint, void> uploadTextureData;

        [NativeTypeName("void (IBuffer *, Offset, Size, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IBuffer*, ulong, ulong, void*, void> uploadBufferData;

        [NativeTypeName("void (IBuffer *, const BufferRange *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IBuffer*, BufferRange*, void> clearBuffer;

        [NativeTypeName("void (ITexture *, const ClearValue &, const SubresourceRange *, bool, bool) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, ITexture*, ClearValue*, SubresourceRange*, bool, bool, void> clearTexture;

        [NativeTypeName("void (IQueryPool *, uint32_t, uint32_t, IBuffer *, uint64_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IQueryPool*, uint, uint, IBuffer*, ulong, void> resolveQuery;

        [NativeTypeName("void (const AccelerationStructureBuildDesc &, IAccelerationStructure *, IAccelerationStructure *, BufferWithOffset, uint32_t, AccelerationStructureQueryDesc *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, AccelerationStructureBuildDesc*, IAccelerationStructure*, IAccelerationStructure*, BufferWithOffset, uint, AccelerationStructureQueryDesc*, void> buildAccelerationStructure;

        [NativeTypeName("void (IAccelerationStructure *, IAccelerationStructure *, AccelerationStructureCopyMode) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IAccelerationStructure*, IAccelerationStructure*, AccelerationStructureCopyMode, void> copyAccelerationStructure;

        [NativeTypeName("void (uint32_t, IAccelerationStructure **, uint32_t, AccelerationStructureQueryDesc *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, uint, IAccelerationStructure**, uint, AccelerationStructureQueryDesc*, void> queryAccelerationStructureProperties;

        [NativeTypeName("void (BufferWithOffset, IAccelerationStructure *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, BufferWithOffset, IAccelerationStructure*, void> serializeAccelerationStructure;

        [NativeTypeName("void (IAccelerationStructure *, BufferWithOffset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IAccelerationStructure*, BufferWithOffset, void> deserializeAccelerationStructure;

        [NativeTypeName("void (IBuffer *, ResourceState) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IBuffer*, ResourceState, void> setBufferState;

        [NativeTypeName("void (ITexture *, SubresourceRange, ResourceState) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, ITexture*, SubresourceRange, ResourceState, void> setTextureState;

        [NativeTypeName("void (const char *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, sbyte*, float*, void> pushDebugGroup;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, void> popDebugGroup;

        [NativeTypeName("void (const char *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, sbyte*, float*, void> insertDebugMarker;

        [NativeTypeName("void (IQueryPool *, uint32_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, IQueryPool*, uint, void> writeTimestamp;

        [NativeTypeName("Result (ICommandBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, ICommandBuffer**, int> finish;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ICommandEncoder*, NativeHandle*, int> getNativeHandle;
    }
}
