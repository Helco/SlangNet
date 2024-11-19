using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IPipelineCreationAPIDispatcher.xml' path='doc/member[@name="IPipelineCreationAPIDispatcher"]/*' />
[NativeTypeName("struct IPipelineCreationAPIDispatcher : ISlangUnknown")]
public unsafe partial struct IPipelineCreationAPIDispatcher
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IPipelineCreationAPIDispatcher*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IPipelineCreationAPIDispatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IPipelineCreationAPIDispatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPipelineCreationAPIDispatcher.xml' path='doc/member[@name="IPipelineCreationAPIDispatcher.createComputePipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createComputePipeline([NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program, void* pipelineDesc, void** outPipelineState)
    {
        return lpVtbl->createComputePipeline((IPipelineCreationAPIDispatcher*)Unsafe.AsPointer(ref this), device, program, pipelineDesc, outPipelineState);
    }

    /// <include file='IPipelineCreationAPIDispatcher.xml' path='doc/member[@name="IPipelineCreationAPIDispatcher.createRenderPipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createRenderPipeline([NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program, void* pipelineDesc, void** outPipelineState)
    {
        return lpVtbl->createRenderPipeline((IPipelineCreationAPIDispatcher*)Unsafe.AsPointer(ref this), device, program, pipelineDesc, outPipelineState);
    }

    /// <include file='IPipelineCreationAPIDispatcher.xml' path='doc/member[@name="IPipelineCreationAPIDispatcher.createMeshPipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createMeshPipeline([NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program, void* pipelineDesc, void** outPipelineState)
    {
        return lpVtbl->createMeshPipeline((IPipelineCreationAPIDispatcher*)Unsafe.AsPointer(ref this), device, program, pipelineDesc, outPipelineState);
    }

    /// <include file='IPipelineCreationAPIDispatcher.xml' path='doc/member[@name="IPipelineCreationAPIDispatcher.beforeCreateRayTracingState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int beforeCreateRayTracingState([NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program)
    {
        return lpVtbl->beforeCreateRayTracingState((IPipelineCreationAPIDispatcher*)Unsafe.AsPointer(ref this), device, program);
    }

    /// <include file='IPipelineCreationAPIDispatcher.xml' path='doc/member[@name="IPipelineCreationAPIDispatcher.afterCreateRayTracingState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int afterCreateRayTracingState([NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program)
    {
        return lpVtbl->afterCreateRayTracingState((IPipelineCreationAPIDispatcher*)Unsafe.AsPointer(ref this), device, program);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipelineCreationAPIDispatcher*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipelineCreationAPIDispatcher*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipelineCreationAPIDispatcher*, uint> release;

        [NativeTypeName("Result (IDevice *, slang::IComponentType *, void *, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipelineCreationAPIDispatcher*, IDevice*, IComponentType*, void*, void**, int> createComputePipeline;

        [NativeTypeName("Result (IDevice *, slang::IComponentType *, void *, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipelineCreationAPIDispatcher*, IDevice*, IComponentType*, void*, void**, int> createRenderPipeline;

        [NativeTypeName("Result (IDevice *, slang::IComponentType *, void *, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipelineCreationAPIDispatcher*, IDevice*, IComponentType*, void*, void**, int> createMeshPipeline;

        [NativeTypeName("Result (IDevice *, slang::IComponentType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipelineCreationAPIDispatcher*, IDevice*, IComponentType*, int> beforeCreateRayTracingState;

        [NativeTypeName("Result (IDevice *, slang::IComponentType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IPipelineCreationAPIDispatcher*, IDevice*, IComponentType*, int> afterCreateRayTracingState;
    }
}
