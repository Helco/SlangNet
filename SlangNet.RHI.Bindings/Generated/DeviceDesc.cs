using SlangNet.Unsafe;

namespace SlangNet.RHI.Unsafe;

/// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc"]/*' />
public unsafe partial struct DeviceDesc
{
    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.next"]/*' />
    [NativeTypeName("const void *")]
    public void* next;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.deviceType"]/*' />
    [NativeTypeName("rhi::DeviceType")]
    public DeviceType deviceType;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.existingDeviceHandles"]/*' />
    [NativeTypeName("rhi::DeviceNativeHandles")]
    public DeviceNativeHandles existingDeviceHandles;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.adapterLUID"]/*' />
    [NativeTypeName("const AdapterLUID *")]
    public AdapterLUID* adapterLUID;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.requiredFeatureCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint requiredFeatureCount;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.requiredFeatures"]/*' />
    [NativeTypeName("const char **")]
    public sbyte** requiredFeatures;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.apiCommandDispatcher"]/*' />
    public ISlangUnknown* apiCommandDispatcher;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.slang"]/*' />
    [NativeTypeName("rhi::SlangDesc")]
    public SlangDesc slang;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.persistentShaderCache"]/*' />
    [NativeTypeName("rhi::IPersistentShaderCache *")]
    public IPersistentShaderCache* persistentShaderCache;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.nvapiExtUavSlot"]/*' />
    [NativeTypeName("uint32_t")]
    public uint nvapiExtUavSlot;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.nvapiExtRegisterSpace"]/*' />
    [NativeTypeName("uint32_t")]
    public uint nvapiExtRegisterSpace;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.enableValidation"]/*' />
    public bool enableValidation;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.enableRayTracingValidation"]/*' />
    public bool enableRayTracingValidation;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.debugCallback"]/*' />
    [NativeTypeName("rhi::IDebugCallback *")]
    public IDebugCallback* debugCallback;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.stagingHeapPageSize"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong stagingHeapPageSize;
}
