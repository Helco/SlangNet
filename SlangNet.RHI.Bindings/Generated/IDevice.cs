using SlangNet.Unsafe;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IDevice.xml' path='doc/member[@name="IDevice"]/*' />
[NativeTypeName("struct IDevice : ISlangUnknown")]
public unsafe partial struct IDevice
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(IDevice* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(IDevice* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(IDevice* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getNativeDeviceHandles(IDevice* pThis, [NativeTypeName("rhi::DeviceNativeHandles *")] DeviceNativeHandles* outHandles);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool _hasFeature(IDevice* pThis, [NativeTypeName("const char *")] sbyte* feature);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getFeatures(IDevice* pThis, [NativeTypeName("const char **")] sbyte** outFeatures, [NativeTypeName("rhi::Size")] UIntPtr bufferSize, [NativeTypeName("rhi::GfxCount *")] int* outFeatureCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getFormatSupport(IDevice* pThis, [NativeTypeName("rhi::Format")] Format format, [NativeTypeName("rhi::FormatSupport *")] FormatSupport* outFormatSupport);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getSlangSession(IDevice* pThis, [NativeTypeName("slang::ISession **")] ISession** outSlangSession);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createTexture(IDevice* pThis, [NativeTypeName("const TextureDesc &")] TextureDesc* desc, [NativeTypeName("const SubresourceData *")] SubresourceData* initData, ITexture** outTexture);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createTextureFromNativeHandle(IDevice* pThis, [NativeTypeName("rhi::NativeHandle")] NativeHandle handle, [NativeTypeName("const TextureDesc &")] TextureDesc* srcDesc, ITexture** outTexture);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createTextureFromSharedHandle(IDevice* pThis, [NativeTypeName("rhi::NativeHandle")] NativeHandle handle, [NativeTypeName("const TextureDesc &")] TextureDesc* srcDesc, [NativeTypeName("const Size")] UIntPtr size, ITexture** outTexture);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createBuffer(IDevice* pThis, [NativeTypeName("const BufferDesc &")] BufferDesc* desc, [NativeTypeName("const void *")] void* initData, IBuffer** outBuffer);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createBufferFromNativeHandle(IDevice* pThis, [NativeTypeName("rhi::NativeHandle")] NativeHandle handle, [NativeTypeName("const BufferDesc &")] BufferDesc* srcDesc, IBuffer** outBuffer);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createBufferFromSharedHandle(IDevice* pThis, [NativeTypeName("rhi::NativeHandle")] NativeHandle handle, [NativeTypeName("const BufferDesc &")] BufferDesc* srcDesc, IBuffer** outBuffer);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _mapBuffer(IDevice* pThis, [NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("rhi::CpuAccessMode")] CpuAccessMode mode, void** outData);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _unmapBuffer(IDevice* pThis, [NativeTypeName("rhi::IBuffer *")] IBuffer* buffer);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createSampler(IDevice* pThis, [NativeTypeName("const SamplerDesc &")] SamplerDesc* desc, ISampler** outSampler);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createTextureView(IDevice* pThis, [NativeTypeName("rhi::ITexture *")] ITexture* texture, [NativeTypeName("const TextureViewDesc &")] TextureViewDesc* desc, ITextureView** outView);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createSurface(IDevice* pThis, [NativeTypeName("rhi::WindowHandle")] WindowHandle windowHandle, ISurface** outSurface);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createInputLayout(IDevice* pThis, [NativeTypeName("const InputLayoutDesc &")] InputLayoutDesc* desc, IInputLayout** outLayout);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getQueue(IDevice* pThis, [NativeTypeName("rhi::QueueType")] QueueType type, ICommandQueue** outQueue);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createShaderObject(IDevice* pThis, [NativeTypeName("slang::ISession *")] ISession* slangSession, [NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("rhi::ShaderObjectContainerType")] ShaderObjectContainerType container, IShaderObject** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createShaderObjectFromTypeLayout(IDevice* pThis, [NativeTypeName("slang::TypeLayoutReflection *")] TypeLayoutReflection* typeLayout, IShaderObject** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createRootShaderObject(IDevice* pThis, [NativeTypeName("rhi::IShaderProgram *")] IShaderProgram* program, IShaderObject** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createShaderTable(IDevice* pThis, [NativeTypeName("const IShaderTable::Desc &")] Desc* desc, IShaderTable** outTable);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createShaderProgram(IDevice* pThis, [NativeTypeName("const ShaderProgramDesc &")] ShaderProgramDesc* desc, IShaderProgram** outProgram, ISlangBlob** outDiagnosticBlob = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createRenderPipeline(IDevice* pThis, [NativeTypeName("const RenderPipelineDesc &")] RenderPipelineDesc* desc, IRenderPipeline** outPipeline);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createComputePipeline(IDevice* pThis, [NativeTypeName("const ComputePipelineDesc &")] ComputePipelineDesc* desc, IComputePipeline** outPipeline);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createRayTracingPipeline(IDevice* pThis, [NativeTypeName("const RayTracingPipelineDesc &")] RayTracingPipelineDesc* desc, IRayTracingPipeline** outPipeline);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _readTexture(IDevice* pThis, [NativeTypeName("rhi::ITexture *")] ITexture* texture, ISlangBlob** outBlob, [NativeTypeName("rhi::Size *")] UIntPtr* outRowPitch, [NativeTypeName("rhi::Size *")] UIntPtr* outPixelSize);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _readBuffer(IDevice* pThis, [NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("rhi::Offset")] nuint offset, [NativeTypeName("rhi::Size")] UIntPtr size, ISlangBlob** outBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const DeviceInfo &")]
    public delegate DeviceInfo* _getDeviceInfo(IDevice* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createQueryPool(IDevice* pThis, [NativeTypeName("const QueryPoolDesc &")] QueryPoolDesc* desc, IQueryPool** outPool);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getAccelerationStructureSizes(IDevice* pThis, [NativeTypeName("const AccelerationStructureBuildDesc &")] AccelerationStructureBuildDesc* desc, [NativeTypeName("rhi::AccelerationStructureSizes *")] AccelerationStructureSizes* outSizes);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createAccelerationStructure(IDevice* pThis, [NativeTypeName("const AccelerationStructureDesc &")] AccelerationStructureDesc* desc, IAccelerationStructure** outAccelerationStructure);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createFence(IDevice* pThis, [NativeTypeName("const FenceDesc &")] FenceDesc* desc, IFence** outFence);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _waitForFences(IDevice* pThis, [NativeTypeName("rhi::GfxCount")] int fenceCount, IFence** fences, [NativeTypeName("uint64_t *")] ulong* values, bool waitForAll, [NativeTypeName("uint64_t")] ulong timeout);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getTextureAllocationInfo(IDevice* pThis, [NativeTypeName("const TextureDesc &")] TextureDesc* desc, [NativeTypeName("rhi::Size *")] UIntPtr* outSize, [NativeTypeName("rhi::Size *")] UIntPtr* outAlignment);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getTextureRowAlignment(IDevice* pThis, [NativeTypeName("rhi::Size *")] UIntPtr* outAlignment);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getNativeDeviceHandles"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeDeviceHandles([NativeTypeName("rhi::DeviceNativeHandles *")] DeviceNativeHandles* outHandles)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getNativeDeviceHandles>(lpVtbl->getNativeDeviceHandles)(pThis, outHandles);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.hasFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool hasFeature([NativeTypeName("const char *")] sbyte* feature)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_hasFeature>(lpVtbl->hasFeature)(pThis, feature);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getFeatures"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getFeatures([NativeTypeName("const char **")] sbyte** outFeatures, [NativeTypeName("rhi::Size")] UIntPtr bufferSize, [NativeTypeName("rhi::GfxCount *")] int* outFeatureCount)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getFeatures>(lpVtbl->getFeatures)(pThis, outFeatures, bufferSize, outFeatureCount);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getFormatSupport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getFormatSupport([NativeTypeName("rhi::Format")] Format format, [NativeTypeName("rhi::FormatSupport *")] FormatSupport* outFormatSupport)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getFormatSupport>(lpVtbl->getFormatSupport)(pThis, format, outFormatSupport);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getSlangSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getSlangSession([NativeTypeName("slang::ISession **")] ISession** outSlangSession)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getSlangSession>(lpVtbl->getSlangSession)(pThis, outSlangSession);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createTexture([NativeTypeName("const TextureDesc &")] TextureDesc* desc, [NativeTypeName("const SubresourceData *")] SubresourceData* initData, ITexture** outTexture)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createTexture>(lpVtbl->createTexture)(pThis, desc, initData, outTexture);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createTextureFromNativeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createTextureFromNativeHandle([NativeTypeName("rhi::NativeHandle")] NativeHandle handle, [NativeTypeName("const TextureDesc &")] TextureDesc* srcDesc, ITexture** outTexture)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createTextureFromNativeHandle>(lpVtbl->createTextureFromNativeHandle)(pThis, handle, srcDesc, outTexture);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createTextureFromSharedHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createTextureFromSharedHandle([NativeTypeName("rhi::NativeHandle")] NativeHandle handle, [NativeTypeName("const TextureDesc &")] TextureDesc* srcDesc, [NativeTypeName("const Size")] UIntPtr size, ITexture** outTexture)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createTextureFromSharedHandle>(lpVtbl->createTextureFromSharedHandle)(pThis, handle, srcDesc, size, outTexture);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createBuffer([NativeTypeName("const BufferDesc &")] BufferDesc* desc, [NativeTypeName("const void *")] void* initData, IBuffer** outBuffer)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createBuffer>(lpVtbl->createBuffer)(pThis, desc, initData, outBuffer);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createBufferFromNativeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createBufferFromNativeHandle([NativeTypeName("rhi::NativeHandle")] NativeHandle handle, [NativeTypeName("const BufferDesc &")] BufferDesc* srcDesc, IBuffer** outBuffer)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createBufferFromNativeHandle>(lpVtbl->createBufferFromNativeHandle)(pThis, handle, srcDesc, outBuffer);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createBufferFromSharedHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createBufferFromSharedHandle([NativeTypeName("rhi::NativeHandle")] NativeHandle handle, [NativeTypeName("const BufferDesc &")] BufferDesc* srcDesc, IBuffer** outBuffer)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createBufferFromSharedHandle>(lpVtbl->createBufferFromSharedHandle)(pThis, handle, srcDesc, outBuffer);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.mapBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int mapBuffer([NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("rhi::CpuAccessMode")] CpuAccessMode mode, void** outData)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_mapBuffer>(lpVtbl->mapBuffer)(pThis, buffer, mode, outData);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.unmapBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int unmapBuffer([NativeTypeName("rhi::IBuffer *")] IBuffer* buffer)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_unmapBuffer>(lpVtbl->unmapBuffer)(pThis, buffer);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createSampler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createSampler([NativeTypeName("const SamplerDesc &")] SamplerDesc* desc, ISampler** outSampler)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createSampler>(lpVtbl->createSampler)(pThis, desc, outSampler);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createTextureView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createTextureView([NativeTypeName("rhi::ITexture *")] ITexture* texture, [NativeTypeName("const TextureViewDesc &")] TextureViewDesc* desc, ITextureView** outView)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createTextureView>(lpVtbl->createTextureView)(pThis, texture, desc, outView);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createSurface([NativeTypeName("rhi::WindowHandle")] WindowHandle windowHandle, ISurface** outSurface)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createSurface>(lpVtbl->createSurface)(pThis, windowHandle, outSurface);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createInputLayout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createInputLayout([NativeTypeName("const InputLayoutDesc &")] InputLayoutDesc* desc, IInputLayout** outLayout)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createInputLayout>(lpVtbl->createInputLayout)(pThis, desc, outLayout);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getQueue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getQueue([NativeTypeName("rhi::QueueType")] QueueType type, ICommandQueue** outQueue)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getQueue>(lpVtbl->getQueue)(pThis, type, outQueue);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createShaderObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createShaderObject([NativeTypeName("slang::ISession *")] ISession* slangSession, [NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("rhi::ShaderObjectContainerType")] ShaderObjectContainerType container, IShaderObject** outObject)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createShaderObject>(lpVtbl->createShaderObject)(pThis, slangSession, type, container, outObject);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createShaderObjectFromTypeLayout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createShaderObjectFromTypeLayout([NativeTypeName("slang::TypeLayoutReflection *")] TypeLayoutReflection* typeLayout, IShaderObject** outObject)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createShaderObjectFromTypeLayout>(lpVtbl->createShaderObjectFromTypeLayout)(pThis, typeLayout, outObject);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createRootShaderObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createRootShaderObject([NativeTypeName("rhi::IShaderProgram *")] IShaderProgram* program, IShaderObject** outObject)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createRootShaderObject>(lpVtbl->createRootShaderObject)(pThis, program, outObject);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createShaderTable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createShaderTable([NativeTypeName("const IShaderTable::Desc &")] Desc* desc, IShaderTable** outTable)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createShaderTable>(lpVtbl->createShaderTable)(pThis, desc, outTable);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createShaderProgram"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createShaderProgram([NativeTypeName("const ShaderProgramDesc &")] ShaderProgramDesc* desc, IShaderProgram** outProgram, ISlangBlob** outDiagnosticBlob = null)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createShaderProgram>(lpVtbl->createShaderProgram)(pThis, desc, outProgram, outDiagnosticBlob);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createRenderPipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createRenderPipeline([NativeTypeName("const RenderPipelineDesc &")] RenderPipelineDesc* desc, IRenderPipeline** outPipeline)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createRenderPipeline>(lpVtbl->createRenderPipeline)(pThis, desc, outPipeline);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createComputePipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createComputePipeline([NativeTypeName("const ComputePipelineDesc &")] ComputePipelineDesc* desc, IComputePipeline** outPipeline)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createComputePipeline>(lpVtbl->createComputePipeline)(pThis, desc, outPipeline);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createRayTracingPipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createRayTracingPipeline([NativeTypeName("const RayTracingPipelineDesc &")] RayTracingPipelineDesc* desc, IRayTracingPipeline** outPipeline)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createRayTracingPipeline>(lpVtbl->createRayTracingPipeline)(pThis, desc, outPipeline);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.readTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int readTexture([NativeTypeName("rhi::ITexture *")] ITexture* texture, ISlangBlob** outBlob, [NativeTypeName("rhi::Size *")] UIntPtr* outRowPitch, [NativeTypeName("rhi::Size *")] UIntPtr* outPixelSize)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_readTexture>(lpVtbl->readTexture)(pThis, texture, outBlob, outRowPitch, outPixelSize);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.readBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int readBuffer([NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("rhi::Offset")] nuint offset, [NativeTypeName("rhi::Size")] UIntPtr size, ISlangBlob** outBlob)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_readBuffer>(lpVtbl->readBuffer)(pThis, buffer, offset, size, outBlob);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getDeviceInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const DeviceInfo &")]
    public DeviceInfo* getDeviceInfo()
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDeviceInfo>(lpVtbl->getDeviceInfo)(pThis);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createQueryPool"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createQueryPool([NativeTypeName("const QueryPoolDesc &")] QueryPoolDesc* desc, IQueryPool** outPool)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createQueryPool>(lpVtbl->createQueryPool)(pThis, desc, outPool);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getAccelerationStructureSizes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getAccelerationStructureSizes([NativeTypeName("const AccelerationStructureBuildDesc &")] AccelerationStructureBuildDesc* desc, [NativeTypeName("rhi::AccelerationStructureSizes *")] AccelerationStructureSizes* outSizes)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getAccelerationStructureSizes>(lpVtbl->getAccelerationStructureSizes)(pThis, desc, outSizes);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createAccelerationStructure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createAccelerationStructure([NativeTypeName("const AccelerationStructureDesc &")] AccelerationStructureDesc* desc, IAccelerationStructure** outAccelerationStructure)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createAccelerationStructure>(lpVtbl->createAccelerationStructure)(pThis, desc, outAccelerationStructure);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createFence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createFence([NativeTypeName("const FenceDesc &")] FenceDesc* desc, IFence** outFence)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createFence>(lpVtbl->createFence)(pThis, desc, outFence);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.waitForFences"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int waitForFences([NativeTypeName("rhi::GfxCount")] int fenceCount, IFence** fences, [NativeTypeName("uint64_t *")] ulong* values, bool waitForAll, [NativeTypeName("uint64_t")] ulong timeout)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_waitForFences>(lpVtbl->waitForFences)(pThis, fenceCount, fences, values, waitForAll, timeout);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getTextureAllocationInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getTextureAllocationInfo([NativeTypeName("const TextureDesc &")] TextureDesc* desc, [NativeTypeName("rhi::Size *")] UIntPtr* outSize, [NativeTypeName("rhi::Size *")] UIntPtr* outAlignment)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTextureAllocationInfo>(lpVtbl->getTextureAllocationInfo)(pThis, desc, outSize, outAlignment);
        }
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getTextureRowAlignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getTextureRowAlignment([NativeTypeName("rhi::Size *")] UIntPtr* outAlignment)
    {
        fixed (IDevice* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTextureRowAlignment>(lpVtbl->getTextureRowAlignment)(pThis, outAlignment);
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

        [NativeTypeName("Result (DeviceNativeHandles *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getNativeDeviceHandles;

        [NativeTypeName("bool (const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr hasFeature;

        [NativeTypeName("Result (const char **, Size, GfxCount *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getFeatures;

        [NativeTypeName("Result (Format, FormatSupport *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getFormatSupport;

        [NativeTypeName("Result (slang::ISession **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getSlangSession;

        [NativeTypeName("Result (const TextureDesc &, const SubresourceData *, ITexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createTexture;

        [NativeTypeName("Result (NativeHandle, const TextureDesc &, ITexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createTextureFromNativeHandle;

        [NativeTypeName("Result (NativeHandle, const TextureDesc &, const Size, ITexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createTextureFromSharedHandle;

        [NativeTypeName("Result (const BufferDesc &, const void *, IBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createBuffer;

        [NativeTypeName("Result (NativeHandle, const BufferDesc &, IBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createBufferFromNativeHandle;

        [NativeTypeName("Result (NativeHandle, const BufferDesc &, IBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createBufferFromSharedHandle;

        [NativeTypeName("Result (IBuffer *, CpuAccessMode, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr mapBuffer;

        [NativeTypeName("Result (IBuffer *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr unmapBuffer;

        [NativeTypeName("Result (const SamplerDesc &, ISampler **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createSampler;

        [NativeTypeName("Result (ITexture *, const TextureViewDesc &, ITextureView **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createTextureView;

        [NativeTypeName("Result (WindowHandle, ISurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createSurface;

        [NativeTypeName("Result (const InputLayoutDesc &, IInputLayout **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createInputLayout;

        [NativeTypeName("Result (QueueType, ICommandQueue **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getQueue;

        [NativeTypeName("Result (slang::ISession *, slang::TypeReflection *, ShaderObjectContainerType, IShaderObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createShaderObject;

        [NativeTypeName("Result (slang::TypeLayoutReflection *, IShaderObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createShaderObjectFromTypeLayout;

        [NativeTypeName("Result (IShaderProgram *, IShaderObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createRootShaderObject;

        [NativeTypeName("Result (const IShaderTable::Desc &, IShaderTable **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createShaderTable;

        [NativeTypeName("Result (const ShaderProgramDesc &, IShaderProgram **, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createShaderProgram;

        [NativeTypeName("Result (const RenderPipelineDesc &, IRenderPipeline **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createRenderPipeline;

        [NativeTypeName("Result (const ComputePipelineDesc &, IComputePipeline **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createComputePipeline;

        [NativeTypeName("Result (const RayTracingPipelineDesc &, IRayTracingPipeline **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createRayTracingPipeline;

        [NativeTypeName("Result (ITexture *, ISlangBlob **, Size *, Size *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr readTexture;

        [NativeTypeName("Result (IBuffer *, Offset, Size, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr readBuffer;

        [NativeTypeName("const DeviceInfo &() const __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDeviceInfo;

        [NativeTypeName("Result (const QueryPoolDesc &, IQueryPool **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createQueryPool;

        [NativeTypeName("Result (const AccelerationStructureBuildDesc &, AccelerationStructureSizes *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getAccelerationStructureSizes;

        [NativeTypeName("Result (const AccelerationStructureDesc &, IAccelerationStructure **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createAccelerationStructure;

        [NativeTypeName("Result (const FenceDesc &, IFence **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createFence;

        [NativeTypeName("Result (GfxCount, IFence **, uint64_t *, bool, uint64_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr waitForFences;

        [NativeTypeName("Result (const TextureDesc &, Size *, Size *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getTextureAllocationInfo;

        [NativeTypeName("Result (Size *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getTextureRowAlignment;
    }
}
