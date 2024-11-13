using SlangNet.Unsafe;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IPipelineCreationAPIDispatcher.xml' path='doc/member[@name="IPipelineCreationAPIDispatcher"]/*' />
[NativeTypeName("struct IPipelineCreationAPIDispatcher : ISlangUnknown")]
public unsafe partial struct IPipelineCreationAPIDispatcher
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(IPipelineCreationAPIDispatcher* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(IPipelineCreationAPIDispatcher* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(IPipelineCreationAPIDispatcher* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createComputePipeline(IPipelineCreationAPIDispatcher* pThis, [NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program, void* pipelineDesc, void** outPipelineState);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createRenderPipeline(IPipelineCreationAPIDispatcher* pThis, [NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program, void* pipelineDesc, void** outPipelineState);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createMeshPipeline(IPipelineCreationAPIDispatcher* pThis, [NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program, void* pipelineDesc, void** outPipelineState);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _beforeCreateRayTracingState(IPipelineCreationAPIDispatcher* pThis, [NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _afterCreateRayTracingState(IPipelineCreationAPIDispatcher* pThis, [NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (IPipelineCreationAPIDispatcher* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (IPipelineCreationAPIDispatcher* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (IPipelineCreationAPIDispatcher* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='IPipelineCreationAPIDispatcher.xml' path='doc/member[@name="IPipelineCreationAPIDispatcher.createComputePipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createComputePipeline([NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program, void* pipelineDesc, void** outPipelineState)
    {
        fixed (IPipelineCreationAPIDispatcher* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createComputePipeline>(lpVtbl->createComputePipeline)(pThis, device, program, pipelineDesc, outPipelineState);
        }
    }

    /// <include file='IPipelineCreationAPIDispatcher.xml' path='doc/member[@name="IPipelineCreationAPIDispatcher.createRenderPipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createRenderPipeline([NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program, void* pipelineDesc, void** outPipelineState)
    {
        fixed (IPipelineCreationAPIDispatcher* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createRenderPipeline>(lpVtbl->createRenderPipeline)(pThis, device, program, pipelineDesc, outPipelineState);
        }
    }

    /// <include file='IPipelineCreationAPIDispatcher.xml' path='doc/member[@name="IPipelineCreationAPIDispatcher.createMeshPipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createMeshPipeline([NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program, void* pipelineDesc, void** outPipelineState)
    {
        fixed (IPipelineCreationAPIDispatcher* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createMeshPipeline>(lpVtbl->createMeshPipeline)(pThis, device, program, pipelineDesc, outPipelineState);
        }
    }

    /// <include file='IPipelineCreationAPIDispatcher.xml' path='doc/member[@name="IPipelineCreationAPIDispatcher.beforeCreateRayTracingState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int beforeCreateRayTracingState([NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program)
    {
        fixed (IPipelineCreationAPIDispatcher* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_beforeCreateRayTracingState>(lpVtbl->beforeCreateRayTracingState)(pThis, device, program);
        }
    }

    /// <include file='IPipelineCreationAPIDispatcher.xml' path='doc/member[@name="IPipelineCreationAPIDispatcher.afterCreateRayTracingState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int afterCreateRayTracingState([NativeTypeName("rhi::IDevice *")] IDevice* device, [NativeTypeName("slang::IComponentType *")] IComponentType* program)
    {
        fixed (IPipelineCreationAPIDispatcher* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_afterCreateRayTracingState>(lpVtbl->afterCreateRayTracingState)(pThis, device, program);
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

        [NativeTypeName("Result (IDevice *, slang::IComponentType *, void *, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createComputePipeline;

        [NativeTypeName("Result (IDevice *, slang::IComponentType *, void *, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createRenderPipeline;

        [NativeTypeName("Result (IDevice *, slang::IComponentType *, void *, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createMeshPipeline;

        [NativeTypeName("Result (IDevice *, slang::IComponentType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr beforeCreateRayTracingState;

        [NativeTypeName("Result (IDevice *, slang::IComponentType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr afterCreateRayTracingState;
    }
}
