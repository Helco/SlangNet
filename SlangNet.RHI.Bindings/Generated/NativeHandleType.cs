namespace SlangNet.RHI.Unsafe;

/// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType"]/*' />
public enum NativeHandleType
{
    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.Unknown"]/*' />
    Unknown = 0x00000000,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.Win32"]/*' />
    Win32 = 0x00000001,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.FileDescriptor"]/*' />
    FileDescriptor = 0x00000002,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.D3D12Device"]/*' />
    D3D12Device = 0x00020001,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.D3D12CommandQueue"]/*' />
    D3D12CommandQueue = 0x00020002,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.D3D12GraphicsCommandList"]/*' />
    D3D12GraphicsCommandList = 0x00020003,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.D3D12Resource"]/*' />
    D3D12Resource = 0x00020004,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.D3D12PipelineState"]/*' />
    D3D12PipelineState = 0x00020005,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.D3D12StateObject"]/*' />
    D3D12StateObject = 0x00020006,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.D3D12CpuDescriptorHandle"]/*' />
    D3D12CpuDescriptorHandle = 0x00020007,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.D3D12Fence"]/*' />
    D3D12Fence = 0x00020008,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.D3D12DeviceAddress"]/*' />
    D3D12DeviceAddress = 0x00020009,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.VkDevice"]/*' />
    VkDevice = 0x00030001,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.VkPhysicalDevice"]/*' />
    VkPhysicalDevice = 0x00030002,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.VkInstance"]/*' />
    VkInstance = 0x00030003,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.VkQueue"]/*' />
    VkQueue = 0x00030004,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.VkCommandBuffer"]/*' />
    VkCommandBuffer = 0x00030005,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.VkBuffer"]/*' />
    VkBuffer = 0x00030006,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.VkImage"]/*' />
    VkImage = 0x00030007,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.VkImageView"]/*' />
    VkImageView = 0x00030008,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.VkAccelerationStructureKHR"]/*' />
    VkAccelerationStructureKHR = 0x00030009,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.VkSampler"]/*' />
    VkSampler = 0x0003000a,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.VkPipeline"]/*' />
    VkPipeline = 0x0003000b,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.VkSemaphore"]/*' />
    VkSemaphore = 0x0003000c,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.MTLDevice"]/*' />
    MTLDevice = 0x00040001,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.MTLCommandQueue"]/*' />
    MTLCommandQueue = 0x00040002,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.MTLCommandBuffer"]/*' />
    MTLCommandBuffer = 0x00040003,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.MTLTexture"]/*' />
    MTLTexture = 0x00040004,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.MTLBuffer"]/*' />
    MTLBuffer = 0x00040005,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.MTLComputePipelineState"]/*' />
    MTLComputePipelineState = 0x00040006,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.MTLRenderPipelineState"]/*' />
    MTLRenderPipelineState = 0x00040007,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.MTLSharedEvent"]/*' />
    MTLSharedEvent = 0x00040008,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.MTLSamplerState"]/*' />
    MTLSamplerState = 0x00040009,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.MTLAccelerationStructure"]/*' />
    MTLAccelerationStructure = 0x0004000a,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.CUdevice"]/*' />
    CUdevice = 0x00050001,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.CUdeviceptr"]/*' />
    CUdeviceptr = 0x00050002,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.CUtexObject"]/*' />
    CUtexObject = 0x00050003,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.CUstream"]/*' />
    CUstream = 0x00050004,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.OptixDeviceContext"]/*' />
    OptixDeviceContext = 0x00060001,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.OptixTraversableHandle"]/*' />
    OptixTraversableHandle = 0x00060002,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.WGPUDevice"]/*' />
    WGPUDevice = 0x00070001,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.WGPUBuffer"]/*' />
    WGPUBuffer = 0x00070002,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.WGPUTexture"]/*' />
    WGPUTexture = 0x00070003,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.WGPUSampler"]/*' />
    WGPUSampler = 0x00070004,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.WGPURenderPipeline"]/*' />
    WGPURenderPipeline = 0x00070005,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.WGPUComputePipeline"]/*' />
    WGPUComputePipeline = 0x00070006,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.WGPUQueue"]/*' />
    WGPUQueue = 0x00070007,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.WGPUCommandBuffer"]/*' />
    WGPUCommandBuffer = 0x00070008,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.WGPUTextureView"]/*' />
    WGPUTextureView = 0x00070009,

    /// <include file='NativeHandleType.xml' path='doc/member[@name="NativeHandleType.WGPUCommandEncoder"]/*' />
    WGPUCommandEncoder = 0x0007000a,
}
