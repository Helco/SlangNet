using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IDevice.xml' path='doc/member[@name="IDevice"]/*' />
[NativeTypeName("struct IDevice : ISlangUnknown")]
public unsafe partial struct IDevice
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IDevice*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getNativeDeviceHandles"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeDeviceHandles([NativeTypeName("rhi::DeviceNativeHandles *")] DeviceNativeHandles* outHandles)
    {
        return lpVtbl->getNativeDeviceHandles((IDevice*)Unsafe.AsPointer(ref this), outHandles);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.hasFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool hasFeature([NativeTypeName("const char *")] sbyte* feature)
    {
        return lpVtbl->hasFeature((IDevice*)Unsafe.AsPointer(ref this), feature);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getFeatures"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getFeatures([NativeTypeName("const char **")] sbyte** outFeatures, [NativeTypeName("rhi::Size")] ulong bufferSize, [NativeTypeName("rhi::GfxCount *")] int* outFeatureCount)
    {
        return lpVtbl->getFeatures((IDevice*)Unsafe.AsPointer(ref this), outFeatures, bufferSize, outFeatureCount);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getFormatSupport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getFormatSupport([NativeTypeName("rhi::Format")] Format format, [NativeTypeName("rhi::FormatSupport *")] FormatSupport* outFormatSupport)
    {
        return lpVtbl->getFormatSupport((IDevice*)Unsafe.AsPointer(ref this), format, outFormatSupport);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getSlangSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getSlangSession([NativeTypeName("slang::ISession **")] ISession** outSlangSession)
    {
        return lpVtbl->getSlangSession((IDevice*)Unsafe.AsPointer(ref this), outSlangSession);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createTexture([NativeTypeName("const TextureDesc &")] TextureDesc* desc, [NativeTypeName("const SubresourceData *")] SubresourceData* initData, ITexture** outTexture)
    {
        return lpVtbl->createTexture((IDevice*)Unsafe.AsPointer(ref this), desc, initData, outTexture);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createTextureFromNativeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createTextureFromNativeHandle([NativeTypeName("rhi::NativeHandle")] NativeHandle handle, [NativeTypeName("const TextureDesc &")] TextureDesc* srcDesc, ITexture** outTexture)
    {
        return lpVtbl->createTextureFromNativeHandle((IDevice*)Unsafe.AsPointer(ref this), handle, srcDesc, outTexture);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createTextureFromSharedHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createTextureFromSharedHandle([NativeTypeName("rhi::NativeHandle")] NativeHandle handle, [NativeTypeName("const TextureDesc &")] TextureDesc* srcDesc, [NativeTypeName("const Size")] ulong size, ITexture** outTexture)
    {
        return lpVtbl->createTextureFromSharedHandle((IDevice*)Unsafe.AsPointer(ref this), handle, srcDesc, size, outTexture);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createBuffer([NativeTypeName("const BufferDesc &")] BufferDesc* desc, [NativeTypeName("const void *")] void* initData, IBuffer** outBuffer)
    {
        return lpVtbl->createBuffer((IDevice*)Unsafe.AsPointer(ref this), desc, initData, outBuffer);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createBufferFromNativeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createBufferFromNativeHandle([NativeTypeName("rhi::NativeHandle")] NativeHandle handle, [NativeTypeName("const BufferDesc &")] BufferDesc* srcDesc, IBuffer** outBuffer)
    {
        return lpVtbl->createBufferFromNativeHandle((IDevice*)Unsafe.AsPointer(ref this), handle, srcDesc, outBuffer);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createBufferFromSharedHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createBufferFromSharedHandle([NativeTypeName("rhi::NativeHandle")] NativeHandle handle, [NativeTypeName("const BufferDesc &")] BufferDesc* srcDesc, IBuffer** outBuffer)
    {
        return lpVtbl->createBufferFromSharedHandle((IDevice*)Unsafe.AsPointer(ref this), handle, srcDesc, outBuffer);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.mapBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int mapBuffer([NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("rhi::CpuAccessMode")] CpuAccessMode mode, void** outData)
    {
        return lpVtbl->mapBuffer((IDevice*)Unsafe.AsPointer(ref this), buffer, mode, outData);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.unmapBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int unmapBuffer([NativeTypeName("rhi::IBuffer *")] IBuffer* buffer)
    {
        return lpVtbl->unmapBuffer((IDevice*)Unsafe.AsPointer(ref this), buffer);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createSampler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createSampler([NativeTypeName("const SamplerDesc &")] SamplerDesc* desc, ISampler** outSampler)
    {
        return lpVtbl->createSampler((IDevice*)Unsafe.AsPointer(ref this), desc, outSampler);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createTextureView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createTextureView([NativeTypeName("rhi::ITexture *")] ITexture* texture, [NativeTypeName("const TextureViewDesc &")] TextureViewDesc* desc, ITextureView** outView)
    {
        return lpVtbl->createTextureView((IDevice*)Unsafe.AsPointer(ref this), texture, desc, outView);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createSurface([NativeTypeName("rhi::WindowHandle")] WindowHandle windowHandle, ISurface** outSurface)
    {
        return lpVtbl->createSurface((IDevice*)Unsafe.AsPointer(ref this), windowHandle, outSurface);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createInputLayout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createInputLayout([NativeTypeName("const InputLayoutDesc &")] InputLayoutDesc* desc, IInputLayout** outLayout)
    {
        return lpVtbl->createInputLayout((IDevice*)Unsafe.AsPointer(ref this), desc, outLayout);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getQueue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getQueue([NativeTypeName("rhi::QueueType")] QueueType type, ICommandQueue** outQueue)
    {
        return lpVtbl->getQueue((IDevice*)Unsafe.AsPointer(ref this), type, outQueue);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createShaderObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createShaderObject([NativeTypeName("slang::ISession *")] ISession* slangSession, [NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("rhi::ShaderObjectContainerType")] ShaderObjectContainerType container, IShaderObject** outObject)
    {
        return lpVtbl->createShaderObject((IDevice*)Unsafe.AsPointer(ref this), slangSession, type, container, outObject);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createShaderObjectFromTypeLayout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createShaderObjectFromTypeLayout([NativeTypeName("slang::TypeLayoutReflection *")] TypeLayoutReflection* typeLayout, IShaderObject** outObject)
    {
        return lpVtbl->createShaderObjectFromTypeLayout((IDevice*)Unsafe.AsPointer(ref this), typeLayout, outObject);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createRootShaderObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createRootShaderObject([NativeTypeName("rhi::IShaderProgram *")] IShaderProgram* program, IShaderObject** outObject)
    {
        return lpVtbl->createRootShaderObject((IDevice*)Unsafe.AsPointer(ref this), program, outObject);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createShaderTable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createShaderTable([NativeTypeName("const IShaderTable::Desc &")] IShaderTable_Desc* desc, IShaderTable** outTable)
    {
        return lpVtbl->createShaderTable((IDevice*)Unsafe.AsPointer(ref this), desc, outTable);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createShaderProgram"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createShaderProgram([NativeTypeName("const ShaderProgramDesc &")] ShaderProgramDesc* desc, IShaderProgram** outProgram, [NativeTypeName("ISlangBlob **")] SlangNet.Unsafe.ISlangBlob** outDiagnosticBlob = null)
    {
        return lpVtbl->createShaderProgram((IDevice*)Unsafe.AsPointer(ref this), desc, outProgram, outDiagnosticBlob);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createRenderPipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createRenderPipeline([NativeTypeName("const RenderPipelineDesc &")] RenderPipelineDesc* desc, IRenderPipeline** outPipeline)
    {
        return lpVtbl->createRenderPipeline((IDevice*)Unsafe.AsPointer(ref this), desc, outPipeline);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createComputePipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createComputePipeline([NativeTypeName("const ComputePipelineDesc &")] ComputePipelineDesc* desc, IComputePipeline** outPipeline)
    {
        return lpVtbl->createComputePipeline((IDevice*)Unsafe.AsPointer(ref this), desc, outPipeline);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createRayTracingPipeline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createRayTracingPipeline([NativeTypeName("const RayTracingPipelineDesc &")] RayTracingPipelineDesc* desc, IRayTracingPipeline** outPipeline)
    {
        return lpVtbl->createRayTracingPipeline((IDevice*)Unsafe.AsPointer(ref this), desc, outPipeline);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.readTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int readTexture([NativeTypeName("rhi::ITexture *")] ITexture* texture, [NativeTypeName("ISlangBlob **")] SlangNet.Unsafe.ISlangBlob** outBlob, [NativeTypeName("rhi::Size *")] ulong* outRowPitch, [NativeTypeName("rhi::Size *")] ulong* outPixelSize)
    {
        return lpVtbl->readTexture((IDevice*)Unsafe.AsPointer(ref this), texture, outBlob, outRowPitch, outPixelSize);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.readBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int readBuffer([NativeTypeName("rhi::IBuffer *")] IBuffer* buffer, [NativeTypeName("rhi::Offset")] ulong offset, [NativeTypeName("rhi::Size")] ulong size, [NativeTypeName("ISlangBlob **")] SlangNet.Unsafe.ISlangBlob** outBlob)
    {
        return lpVtbl->readBuffer((IDevice*)Unsafe.AsPointer(ref this), buffer, offset, size, outBlob);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getDeviceInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const DeviceInfo &")]
    public DeviceInfo* getDeviceInfo()
    {
        return lpVtbl->getDeviceInfo((IDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createQueryPool"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createQueryPool([NativeTypeName("const QueryPoolDesc &")] QueryPoolDesc* desc, IQueryPool** outPool)
    {
        return lpVtbl->createQueryPool((IDevice*)Unsafe.AsPointer(ref this), desc, outPool);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getAccelerationStructureSizes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getAccelerationStructureSizes([NativeTypeName("const AccelerationStructureBuildDesc &")] AccelerationStructureBuildDesc* desc, [NativeTypeName("rhi::AccelerationStructureSizes *")] AccelerationStructureSizes* outSizes)
    {
        return lpVtbl->getAccelerationStructureSizes((IDevice*)Unsafe.AsPointer(ref this), desc, outSizes);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createAccelerationStructure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createAccelerationStructure([NativeTypeName("const AccelerationStructureDesc &")] AccelerationStructureDesc* desc, IAccelerationStructure** outAccelerationStructure)
    {
        return lpVtbl->createAccelerationStructure((IDevice*)Unsafe.AsPointer(ref this), desc, outAccelerationStructure);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.createFence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createFence([NativeTypeName("const FenceDesc &")] FenceDesc* desc, IFence** outFence)
    {
        return lpVtbl->createFence((IDevice*)Unsafe.AsPointer(ref this), desc, outFence);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.waitForFences"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int waitForFences([NativeTypeName("rhi::GfxCount")] int fenceCount, IFence** fences, [NativeTypeName("uint64_t *")] ulong* values, bool waitForAll, [NativeTypeName("uint64_t")] ulong timeout)
    {
        return lpVtbl->waitForFences((IDevice*)Unsafe.AsPointer(ref this), fenceCount, fences, values, waitForAll, timeout);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getTextureAllocationInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getTextureAllocationInfo([NativeTypeName("const TextureDesc &")] TextureDesc* desc, [NativeTypeName("rhi::Size *")] ulong* outSize, [NativeTypeName("rhi::Size *")] ulong* outAlignment)
    {
        return lpVtbl->getTextureAllocationInfo((IDevice*)Unsafe.AsPointer(ref this), desc, outSize, outAlignment);
    }

    /// <include file='IDevice.xml' path='doc/member[@name="IDevice.getTextureRowAlignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getTextureRowAlignment([NativeTypeName("rhi::Size *")] ulong* outAlignment)
    {
        return lpVtbl->getTextureRowAlignment((IDevice*)Unsafe.AsPointer(ref this), outAlignment);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, uint> release;

        [NativeTypeName("Result (DeviceNativeHandles *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, DeviceNativeHandles*, int> getNativeDeviceHandles;

        [NativeTypeName("bool (const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, sbyte*, bool> hasFeature;

        [NativeTypeName("Result (const char **, Size, GfxCount *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, sbyte**, ulong, int*, int> getFeatures;

        [NativeTypeName("Result (Format, FormatSupport *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, Format, FormatSupport*, int> getFormatSupport;

        [NativeTypeName("Result (slang::ISession **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, ISession**, int> getSlangSession;

        [NativeTypeName("Result (const TextureDesc &, const SubresourceData *, ITexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, TextureDesc*, SubresourceData*, ITexture**, int> createTexture;

        [NativeTypeName("Result (NativeHandle, const TextureDesc &, ITexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, NativeHandle, TextureDesc*, ITexture**, int> createTextureFromNativeHandle;

        [NativeTypeName("Result (NativeHandle, const TextureDesc &, const Size, ITexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, NativeHandle, TextureDesc*, ulong, ITexture**, int> createTextureFromSharedHandle;

        [NativeTypeName("Result (const BufferDesc &, const void *, IBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, BufferDesc*, void*, IBuffer**, int> createBuffer;

        [NativeTypeName("Result (NativeHandle, const BufferDesc &, IBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, NativeHandle, BufferDesc*, IBuffer**, int> createBufferFromNativeHandle;

        [NativeTypeName("Result (NativeHandle, const BufferDesc &, IBuffer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, NativeHandle, BufferDesc*, IBuffer**, int> createBufferFromSharedHandle;

        [NativeTypeName("Result (IBuffer *, CpuAccessMode, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, IBuffer*, CpuAccessMode, void**, int> mapBuffer;

        [NativeTypeName("Result (IBuffer *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, IBuffer*, int> unmapBuffer;

        [NativeTypeName("Result (const SamplerDesc &, ISampler **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, SamplerDesc*, ISampler**, int> createSampler;

        [NativeTypeName("Result (ITexture *, const TextureViewDesc &, ITextureView **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, ITexture*, TextureViewDesc*, ITextureView**, int> createTextureView;

        [NativeTypeName("Result (WindowHandle, ISurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, WindowHandle, ISurface**, int> createSurface;

        [NativeTypeName("Result (const InputLayoutDesc &, IInputLayout **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, InputLayoutDesc*, IInputLayout**, int> createInputLayout;

        [NativeTypeName("Result (QueueType, ICommandQueue **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, QueueType, ICommandQueue**, int> getQueue;

        [NativeTypeName("Result (slang::ISession *, slang::TypeReflection *, ShaderObjectContainerType, IShaderObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, ISession*, TypeReflection*, ShaderObjectContainerType, IShaderObject**, int> createShaderObject;

        [NativeTypeName("Result (slang::TypeLayoutReflection *, IShaderObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, TypeLayoutReflection*, IShaderObject**, int> createShaderObjectFromTypeLayout;

        [NativeTypeName("Result (IShaderProgram *, IShaderObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, IShaderProgram*, IShaderObject**, int> createRootShaderObject;

        [NativeTypeName("Result (const IShaderTable::Desc &, IShaderTable **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, IShaderTable_Desc*, IShaderTable**, int> createShaderTable;

        [NativeTypeName("Result (const ShaderProgramDesc &, IShaderProgram **, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, ShaderProgramDesc*, IShaderProgram**, SlangNet.Unsafe.ISlangBlob**, int> createShaderProgram;

        [NativeTypeName("Result (const RenderPipelineDesc &, IRenderPipeline **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, RenderPipelineDesc*, IRenderPipeline**, int> createRenderPipeline;

        [NativeTypeName("Result (const ComputePipelineDesc &, IComputePipeline **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, ComputePipelineDesc*, IComputePipeline**, int> createComputePipeline;

        [NativeTypeName("Result (const RayTracingPipelineDesc &, IRayTracingPipeline **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, RayTracingPipelineDesc*, IRayTracingPipeline**, int> createRayTracingPipeline;

        [NativeTypeName("Result (ITexture *, ISlangBlob **, Size *, Size *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, ITexture*, SlangNet.Unsafe.ISlangBlob**, ulong*, ulong*, int> readTexture;

        [NativeTypeName("Result (IBuffer *, Offset, Size, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, IBuffer*, ulong, ulong, SlangNet.Unsafe.ISlangBlob**, int> readBuffer;

        [NativeTypeName("const DeviceInfo &() const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, DeviceInfo*> getDeviceInfo;

        [NativeTypeName("Result (const QueryPoolDesc &, IQueryPool **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, QueryPoolDesc*, IQueryPool**, int> createQueryPool;

        [NativeTypeName("Result (const AccelerationStructureBuildDesc &, AccelerationStructureSizes *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, AccelerationStructureBuildDesc*, AccelerationStructureSizes*, int> getAccelerationStructureSizes;

        [NativeTypeName("Result (const AccelerationStructureDesc &, IAccelerationStructure **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, AccelerationStructureDesc*, IAccelerationStructure**, int> createAccelerationStructure;

        [NativeTypeName("Result (const FenceDesc &, IFence **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, FenceDesc*, IFence**, int> createFence;

        [NativeTypeName("Result (GfxCount, IFence **, uint64_t *, bool, uint64_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, int, IFence**, ulong*, bool, ulong, int> waitForFences;

        [NativeTypeName("Result (const TextureDesc &, Size *, Size *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, TextureDesc*, ulong*, ulong*, int> getTextureAllocationInfo;

        [NativeTypeName("Result (Size *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDevice*, ulong*, int> getTextureRowAlignment;
    }
}
