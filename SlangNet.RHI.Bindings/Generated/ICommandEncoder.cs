using SlangNet.Unsafe;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder"]/*' />
[NativeTypeName("struct ICommandEncoder : ISlangUnknown")]
public unsafe partial struct ICommandEncoder
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ICommandEncoder* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ICommandEncoder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ICommandEncoder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _copyBuffer(ICommandEncoder* pThis, [NativeTypeName("rhi::IBuffer *")] IBuffer* dst, [NativeTypeName("rhi::Offset")] nuint dstOffset, [NativeTypeName("rhi::IBuffer *")] IBuffer* src, [NativeTypeName("rhi::Offset")] nuint srcOffset, [NativeTypeName("rhi::Size")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _copyTexture(ICommandEncoder* pThis, [NativeTypeName("rhi::ITexture *")] ITexture* dst, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange dstSubresource, [NativeTypeName("rhi::Offset3D")] Offset3D dstOffset, [NativeTypeName("rhi::ITexture *")] ITexture* src, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange srcSubresource, [NativeTypeName("rhi::Offset3D")] Offset3D srcOffset, [NativeTypeName("rhi::Extents")] Extents extent);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _copyTextureToBuffer(ICommandEncoder* pThis, [NativeTypeName("rhi::IBuffer *")] IBuffer* dst, [NativeTypeName("rhi::Offset")] nuint dstOffset, [NativeTypeName("rhi::Size")] UIntPtr dstSize, [NativeTypeName("rhi::Size")] UIntPtr dstRowStride, [NativeTypeName("rhi::ITexture *")] ITexture* src, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange srcSubresource, [NativeTypeName("rhi::Offset3D")] Offset3D srcOffset, [NativeTypeName("rhi::Extents")] Extents extent);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _uploadTextureData(ICommandEncoder* pThis, [NativeTypeName("rhi::ITexture *")] ITexture* dst, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange subresourceRange, [NativeTypeName("rhi::Offset3D")] Offset3D offset, [NativeTypeName("rhi::Extents")] Extents extent, [NativeTypeName("rhi::SubresourceData *")] SubresourceData* subresourceData, [NativeTypeName("rhi::GfxCount")] int subresourceDataCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _uploadBufferData(ICommandEncoder* pThis, [NativeTypeName("rhi::IBuffer *")] IBuffer* dst, [NativeTypeName("rhi::Offset")] nuint offset, [NativeTypeName("rhi::Size")] UIntPtr size, void* data);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _clearBuffer(ICommandEncoder* pThis, [NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("const BufferRange *")] BufferRange* range = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _clearTexture(ICommandEncoder* pThis, [NativeTypeName("rhi::ITexture *")] ITexture* texture, [NativeTypeName("const ClearValue &")] ClearValue* clearValue = null, [NativeTypeName("const SubresourceRange *")] SubresourceRange* subresourceRange = null, bool clearDepth = true, bool clearStencil = true);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _resolveQuery(ICommandEncoder* pThis, [NativeTypeName("rhi::IQueryPool *")] IQueryPool* queryPool, [NativeTypeName("rhi::GfxIndex")] int index, [NativeTypeName("rhi::GfxCount")] int count, [NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("rhi::Offset")] nuint offset);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _beginRenderPass(ICommandEncoder* pThis, [NativeTypeName("const RenderPassDesc &")] RenderPassDesc* desc);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _endRenderPass(ICommandEncoder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setRenderState(ICommandEncoder* pThis, [NativeTypeName("const RenderState &")] RenderState* state);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _draw(ICommandEncoder* pThis, [NativeTypeName("const DrawArguments &")] DrawArguments* args);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _drawIndexed(ICommandEncoder* pThis, [NativeTypeName("const DrawArguments &")] DrawArguments* args);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _drawIndirect(ICommandEncoder* pThis, [NativeTypeName("rhi::GfxCount")] int maxDrawCount, [NativeTypeName("rhi::IBuffer *")] IBuffer* argBuffer, [NativeTypeName("rhi::Offset")] nuint argOffset, [NativeTypeName("rhi::IBuffer *")] IBuffer* countBuffer = null, [NativeTypeName("rhi::Offset")] nuint countOffset = 0);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _drawIndexedIndirect(ICommandEncoder* pThis, [NativeTypeName("rhi::GfxCount")] int maxDrawCount, [NativeTypeName("rhi::IBuffer *")] IBuffer* argBuffer, [NativeTypeName("rhi::Offset")] nuint argOffset, [NativeTypeName("rhi::IBuffer *")] IBuffer* countBuffer = null, [NativeTypeName("rhi::Offset")] nuint countOffset = 0);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _drawMeshTasks(ICommandEncoder* pThis, int x, int y, int z);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _beginComputePass(ICommandEncoder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _endComputePass(ICommandEncoder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setComputeState(ICommandEncoder* pThis, [NativeTypeName("const ComputeState &")] ComputeState* state);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _dispatchCompute(ICommandEncoder* pThis, int x, int y, int z);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _dispatchComputeIndirect(ICommandEncoder* pThis, [NativeTypeName("rhi::IBuffer *")] IBuffer* argBuffer, [NativeTypeName("rhi::Offset")] nuint offset);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _beginRayTracingPass(ICommandEncoder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _endRayTracingPass(ICommandEncoder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setRayTracingState(ICommandEncoder* pThis, [NativeTypeName("const RayTracingState &")] RayTracingState* state);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _dispatchRays(ICommandEncoder* pThis, [NativeTypeName("rhi::GfxIndex")] int rayGenShaderIndex, [NativeTypeName("rhi::GfxCount")] int width, [NativeTypeName("rhi::GfxCount")] int height, [NativeTypeName("rhi::GfxCount")] int depth);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _buildAccelerationStructure(ICommandEncoder* pThis, [NativeTypeName("const AccelerationStructureBuildDesc &")] AccelerationStructureBuildDesc* desc, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* dst, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* src, [NativeTypeName("rhi::BufferWithOffset")] BufferWithOffset scratchBuffer, [NativeTypeName("rhi::GfxCount")] int propertyQueryCount, [NativeTypeName("rhi::AccelerationStructureQueryDesc *")] AccelerationStructureQueryDesc* queryDescs);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _copyAccelerationStructure(ICommandEncoder* pThis, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* dst, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* src, [NativeTypeName("rhi::AccelerationStructureCopyMode")] AccelerationStructureCopyMode mode);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _queryAccelerationStructureProperties(ICommandEncoder* pThis, [NativeTypeName("rhi::GfxCount")] int accelerationStructureCount, [NativeTypeName("IAccelerationStructure *const *")] IAccelerationStructure** accelerationStructures, [NativeTypeName("rhi::GfxCount")] int queryCount, [NativeTypeName("rhi::AccelerationStructureQueryDesc *")] AccelerationStructureQueryDesc* queryDescs);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _serializeAccelerationStructure(ICommandEncoder* pThis, [NativeTypeName("rhi::BufferWithOffset")] BufferWithOffset dst, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* src);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _deserializeAccelerationStructure(ICommandEncoder* pThis, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* dst, [NativeTypeName("rhi::BufferWithOffset")] BufferWithOffset src);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setBufferState(ICommandEncoder* pThis, [NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("rhi::ResourceState")] ResourceState state);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setTextureState(ICommandEncoder* pThis, [NativeTypeName("rhi::ITexture *")] ITexture* texture, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange subresourceRange, [NativeTypeName("rhi::ResourceState")] ResourceState state);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _beginDebugEvent(ICommandEncoder* pThis, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _endDebugEvent(ICommandEncoder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _writeTimestamp(ICommandEncoder* pThis, [NativeTypeName("rhi::IQueryPool *")] IQueryPool* queryPool, [NativeTypeName("rhi::GfxIndex")] int queryIndex);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _finish(ICommandEncoder* pThis, ICommandBuffer** outCommandBuffer);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getNativeHandle(ICommandEncoder* pThis, [NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.copyBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void copyBuffer([NativeTypeName("rhi::IBuffer *")] IBuffer* dst, [NativeTypeName("rhi::Offset")] nuint dstOffset, [NativeTypeName("rhi::IBuffer *")] IBuffer* src, [NativeTypeName("rhi::Offset")] nuint srcOffset, [NativeTypeName("rhi::Size")] UIntPtr size)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_copyBuffer>(lpVtbl->copyBuffer)(pThis, dst, dstOffset, src, srcOffset, size);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.copyTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void copyTexture([NativeTypeName("rhi::ITexture *")] ITexture* dst, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange dstSubresource, [NativeTypeName("rhi::Offset3D")] Offset3D dstOffset, [NativeTypeName("rhi::ITexture *")] ITexture* src, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange srcSubresource, [NativeTypeName("rhi::Offset3D")] Offset3D srcOffset, [NativeTypeName("rhi::Extents")] Extents extent)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_copyTexture>(lpVtbl->copyTexture)(pThis, dst, dstSubresource, dstOffset, src, srcSubresource, srcOffset, extent);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.copyTextureToBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void copyTextureToBuffer([NativeTypeName("rhi::IBuffer *")] IBuffer* dst, [NativeTypeName("rhi::Offset")] nuint dstOffset, [NativeTypeName("rhi::Size")] UIntPtr dstSize, [NativeTypeName("rhi::Size")] UIntPtr dstRowStride, [NativeTypeName("rhi::ITexture *")] ITexture* src, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange srcSubresource, [NativeTypeName("rhi::Offset3D")] Offset3D srcOffset, [NativeTypeName("rhi::Extents")] Extents extent)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_copyTextureToBuffer>(lpVtbl->copyTextureToBuffer)(pThis, dst, dstOffset, dstSize, dstRowStride, src, srcSubresource, srcOffset, extent);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.uploadTextureData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void uploadTextureData([NativeTypeName("rhi::ITexture *")] ITexture* dst, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange subresourceRange, [NativeTypeName("rhi::Offset3D")] Offset3D offset, [NativeTypeName("rhi::Extents")] Extents extent, [NativeTypeName("rhi::SubresourceData *")] SubresourceData* subresourceData, [NativeTypeName("rhi::GfxCount")] int subresourceDataCount)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_uploadTextureData>(lpVtbl->uploadTextureData)(pThis, dst, subresourceRange, offset, extent, subresourceData, subresourceDataCount);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.uploadBufferData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void uploadBufferData([NativeTypeName("rhi::IBuffer *")] IBuffer* dst, [NativeTypeName("rhi::Offset")] nuint offset, [NativeTypeName("rhi::Size")] UIntPtr size, void* data)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_uploadBufferData>(lpVtbl->uploadBufferData)(pThis, dst, offset, size, data);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.clearBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void clearBuffer([NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("const BufferRange *")] BufferRange* range = null)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_clearBuffer>(lpVtbl->clearBuffer)(pThis, buffer, range);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.clearTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void clearTexture([NativeTypeName("rhi::ITexture *")] ITexture* texture, [NativeTypeName("const ClearValue &")] ClearValue* clearValue = null, [NativeTypeName("const SubresourceRange *")] SubresourceRange* subresourceRange = null, bool clearDepth = true, bool clearStencil = true)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_clearTexture>(lpVtbl->clearTexture)(pThis, texture, clearValue, subresourceRange, clearDepth, clearStencil);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.resolveQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void resolveQuery([NativeTypeName("rhi::IQueryPool *")] IQueryPool* queryPool, [NativeTypeName("rhi::GfxIndex")] int index, [NativeTypeName("rhi::GfxCount")] int count, [NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("rhi::Offset")] nuint offset)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_resolveQuery>(lpVtbl->resolveQuery)(pThis, queryPool, index, count, buffer, offset);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.beginRenderPass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void beginRenderPass([NativeTypeName("const RenderPassDesc &")] RenderPassDesc* desc)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_beginRenderPass>(lpVtbl->beginRenderPass)(pThis, desc);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.endRenderPass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void endRenderPass()
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_endRenderPass>(lpVtbl->endRenderPass)(pThis);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.setRenderState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setRenderState([NativeTypeName("const RenderState &")] RenderState* state)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setRenderState>(lpVtbl->setRenderState)(pThis, state);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.draw"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void draw([NativeTypeName("const DrawArguments &")] DrawArguments* args)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_draw>(lpVtbl->draw)(pThis, args);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.drawIndexed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawIndexed([NativeTypeName("const DrawArguments &")] DrawArguments* args)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_drawIndexed>(lpVtbl->drawIndexed)(pThis, args);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.drawIndirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawIndirect([NativeTypeName("rhi::GfxCount")] int maxDrawCount, [NativeTypeName("rhi::IBuffer *")] IBuffer* argBuffer, [NativeTypeName("rhi::Offset")] nuint argOffset, [NativeTypeName("rhi::IBuffer *")] IBuffer* countBuffer = null, [NativeTypeName("rhi::Offset")] nuint countOffset = 0)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_drawIndirect>(lpVtbl->drawIndirect)(pThis, maxDrawCount, argBuffer, argOffset, countBuffer, countOffset);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.drawIndexedIndirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawIndexedIndirect([NativeTypeName("rhi::GfxCount")] int maxDrawCount, [NativeTypeName("rhi::IBuffer *")] IBuffer* argBuffer, [NativeTypeName("rhi::Offset")] nuint argOffset, [NativeTypeName("rhi::IBuffer *")] IBuffer* countBuffer = null, [NativeTypeName("rhi::Offset")] nuint countOffset = 0)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_drawIndexedIndirect>(lpVtbl->drawIndexedIndirect)(pThis, maxDrawCount, argBuffer, argOffset, countBuffer, countOffset);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.drawMeshTasks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void drawMeshTasks(int x, int y, int z)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_drawMeshTasks>(lpVtbl->drawMeshTasks)(pThis, x, y, z);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.beginComputePass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void beginComputePass()
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_beginComputePass>(lpVtbl->beginComputePass)(pThis);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.endComputePass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void endComputePass()
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_endComputePass>(lpVtbl->endComputePass)(pThis);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.setComputeState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setComputeState([NativeTypeName("const ComputeState &")] ComputeState* state)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setComputeState>(lpVtbl->setComputeState)(pThis, state);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.dispatchCompute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void dispatchCompute(int x, int y, int z)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_dispatchCompute>(lpVtbl->dispatchCompute)(pThis, x, y, z);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.dispatchComputeIndirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void dispatchComputeIndirect([NativeTypeName("rhi::IBuffer *")] IBuffer* argBuffer, [NativeTypeName("rhi::Offset")] nuint offset)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_dispatchComputeIndirect>(lpVtbl->dispatchComputeIndirect)(pThis, argBuffer, offset);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.beginRayTracingPass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void beginRayTracingPass()
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_beginRayTracingPass>(lpVtbl->beginRayTracingPass)(pThis);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.endRayTracingPass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void endRayTracingPass()
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_endRayTracingPass>(lpVtbl->endRayTracingPass)(pThis);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.setRayTracingState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setRayTracingState([NativeTypeName("const RayTracingState &")] RayTracingState* state)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setRayTracingState>(lpVtbl->setRayTracingState)(pThis, state);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.dispatchRays"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void dispatchRays([NativeTypeName("rhi::GfxIndex")] int rayGenShaderIndex, [NativeTypeName("rhi::GfxCount")] int width, [NativeTypeName("rhi::GfxCount")] int height, [NativeTypeName("rhi::GfxCount")] int depth)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_dispatchRays>(lpVtbl->dispatchRays)(pThis, rayGenShaderIndex, width, height, depth);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.buildAccelerationStructure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void buildAccelerationStructure([NativeTypeName("const AccelerationStructureBuildDesc &")] AccelerationStructureBuildDesc* desc, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* dst, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* src, [NativeTypeName("rhi::BufferWithOffset")] BufferWithOffset scratchBuffer, [NativeTypeName("rhi::GfxCount")] int propertyQueryCount, [NativeTypeName("rhi::AccelerationStructureQueryDesc *")] AccelerationStructureQueryDesc* queryDescs)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_buildAccelerationStructure>(lpVtbl->buildAccelerationStructure)(pThis, desc, dst, src, scratchBuffer, propertyQueryCount, queryDescs);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.copyAccelerationStructure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void copyAccelerationStructure([NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* dst, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* src, [NativeTypeName("rhi::AccelerationStructureCopyMode")] AccelerationStructureCopyMode mode)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_copyAccelerationStructure>(lpVtbl->copyAccelerationStructure)(pThis, dst, src, mode);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.queryAccelerationStructureProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void queryAccelerationStructureProperties([NativeTypeName("rhi::GfxCount")] int accelerationStructureCount, [NativeTypeName("IAccelerationStructure *const *")] IAccelerationStructure** accelerationStructures, [NativeTypeName("rhi::GfxCount")] int queryCount, [NativeTypeName("rhi::AccelerationStructureQueryDesc *")] AccelerationStructureQueryDesc* queryDescs)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_queryAccelerationStructureProperties>(lpVtbl->queryAccelerationStructureProperties)(pThis, accelerationStructureCount, accelerationStructures, queryCount, queryDescs);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.serializeAccelerationStructure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void serializeAccelerationStructure([NativeTypeName("rhi::BufferWithOffset")] BufferWithOffset dst, [NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* src)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_serializeAccelerationStructure>(lpVtbl->serializeAccelerationStructure)(pThis, dst, src);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.deserializeAccelerationStructure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void deserializeAccelerationStructure([NativeTypeName("rhi::IAccelerationStructure *")] IAccelerationStructure* dst, [NativeTypeName("rhi::BufferWithOffset")] BufferWithOffset src)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_deserializeAccelerationStructure>(lpVtbl->deserializeAccelerationStructure)(pThis, dst, src);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.setBufferState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setBufferState([NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("rhi::ResourceState")] ResourceState state)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setBufferState>(lpVtbl->setBufferState)(pThis, buffer, state);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.setTextureState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setTextureState([NativeTypeName("rhi::ITexture *")] ITexture* texture, [NativeTypeName("rhi::SubresourceRange")] SubresourceRange subresourceRange, [NativeTypeName("rhi::ResourceState")] ResourceState state)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setTextureState>(lpVtbl->setTextureState)(pThis, texture, subresourceRange, state);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.beginDebugEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void beginDebugEvent([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("float[3]")] float* rgbColor)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_beginDebugEvent>(lpVtbl->beginDebugEvent)(pThis, name, rgbColor);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.endDebugEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void endDebugEvent()
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_endDebugEvent>(lpVtbl->endDebugEvent)(pThis);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.writeTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void writeTimestamp([NativeTypeName("rhi::IQueryPool *")] IQueryPool* queryPool, [NativeTypeName("rhi::GfxIndex")] int queryIndex)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_writeTimestamp>(lpVtbl->writeTimestamp)(pThis, queryPool, queryIndex);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.finish"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int finish(ICommandBuffer** outCommandBuffer)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_finish>(lpVtbl->finish)(pThis, outCommandBuffer);
        }
    }

    /// <include file='ICommandEncoder.xml' path='doc/member[@name="ICommandEncoder.getNativeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        fixed (ICommandEncoder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getNativeHandle>(lpVtbl->getNativeHandle)(pThis, outHandle);
        }
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr release;

        [NativeTypeName("void (IBuffer *, Offset, IBuffer *, Offset, Size) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr copyBuffer;

        [NativeTypeName("void (ITexture *, SubresourceRange, Offset3D, ITexture *, SubresourceRange, Offset3D, Extents) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr copyTexture;

        [NativeTypeName("void (IBuffer *, Offset, Size, Size, ITexture *, SubresourceRange, Offset3D, Extents) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr copyTextureToBuffer;

        [NativeTypeName("void (ITexture *, SubresourceRange, Offset3D, Extents, SubresourceData *, GfxCount) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr uploadTextureData;

        [NativeTypeName("void (IBuffer *, Offset, Size, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr uploadBufferData;

        [NativeTypeName("void (IBuffer *, const BufferRange *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr clearBuffer;

        [NativeTypeName("void (ITexture *, const ClearValue &, const SubresourceRange *, bool, bool) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr clearTexture;

        [NativeTypeName("void (IQueryPool *, GfxIndex, GfxCount, IBuffer *, Offset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr resolveQuery;

        [NativeTypeName("void (const RenderPassDesc &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr beginRenderPass;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr endRenderPass;

        [NativeTypeName("void (const RenderState &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setRenderState;

        [NativeTypeName("void (const DrawArguments &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr draw;

        [NativeTypeName("void (const DrawArguments &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr drawIndexed;

        [NativeTypeName("void (GfxCount, IBuffer *, Offset, IBuffer *, Offset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr drawIndirect;

        [NativeTypeName("void (GfxCount, IBuffer *, Offset, IBuffer *, Offset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr drawIndexedIndirect;

        [NativeTypeName("void (int, int, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr drawMeshTasks;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr beginComputePass;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr endComputePass;

        [NativeTypeName("void (const ComputeState &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setComputeState;

        [NativeTypeName("void (int, int, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr dispatchCompute;

        [NativeTypeName("void (IBuffer *, Offset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr dispatchComputeIndirect;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr beginRayTracingPass;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr endRayTracingPass;

        [NativeTypeName("void (const RayTracingState &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setRayTracingState;

        [NativeTypeName("void (GfxIndex, GfxCount, GfxCount, GfxCount) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr dispatchRays;

        [NativeTypeName("void (const AccelerationStructureBuildDesc &, IAccelerationStructure *, IAccelerationStructure *, BufferWithOffset, GfxCount, AccelerationStructureQueryDesc *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr buildAccelerationStructure;

        [NativeTypeName("void (IAccelerationStructure *, IAccelerationStructure *, AccelerationStructureCopyMode) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr copyAccelerationStructure;

        [NativeTypeName("void (GfxCount, IAccelerationStructure *const *, GfxCount, AccelerationStructureQueryDesc *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr queryAccelerationStructureProperties;

        [NativeTypeName("void (BufferWithOffset, IAccelerationStructure *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr serializeAccelerationStructure;

        [NativeTypeName("void (IAccelerationStructure *, BufferWithOffset) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr deserializeAccelerationStructure;

        [NativeTypeName("void (IBuffer *, ResourceState) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setBufferState;

        [NativeTypeName("void (ITexture *, SubresourceRange, ResourceState) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setTextureState;

        [NativeTypeName("void (const char *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr beginDebugEvent;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr endDebugEvent;

        [NativeTypeName("void (IQueryPool *, GfxIndex) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr writeTimestamp;

        [NativeTypeName("Result (ICommandBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr finish;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getNativeHandle;
    }
}
