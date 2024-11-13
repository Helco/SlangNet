namespace SlangNet.RHI.Unsafe;

/// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc"]/*' />
public unsafe partial struct DeviceDesc
{
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
    [NativeTypeName("rhi::GfxCount")]
    public int requiredFeatureCount;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.requiredFeatures"]/*' />
    [NativeTypeName("const char **")]
    public sbyte** requiredFeatures;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.apiCommandDispatcher"]/*' />
    public ISlangUnknown* apiCommandDispatcher;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.nvapiExtnSlot"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int nvapiExtnSlot;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.slang"]/*' />
    [NativeTypeName("rhi::SlangDesc")]
    public SlangDesc slang;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.persistentShaderCache"]/*' />
    [NativeTypeName("rhi::IPersistentShaderCache *")]
    public IPersistentShaderCache* persistentShaderCache;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.extendedDescCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int extendedDescCount;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.extendedDescs"]/*' />
    public void** extendedDescs;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.enableValidation"]/*' />
    public bool enableValidation;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.enableBackendValidation"]/*' />
    public bool enableBackendValidation;

    /// <include file='DeviceDesc.xml' path='doc/member[@name="DeviceDesc.debugCallback"]/*' />
    [NativeTypeName("rhi::IDebugCallback *")]
    public IDebugCallback* debugCallback;
}
