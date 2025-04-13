namespace SlangNet.RHI.Unsafe;

/// <include file='D3D12ExperimentalFeaturesDesc.xml' path='doc/member[@name="D3D12ExperimentalFeaturesDesc"]/*' />
public unsafe partial struct D3D12ExperimentalFeaturesDesc
{
    /// <include file='D3D12ExperimentalFeaturesDesc.xml' path='doc/member[@name="D3D12ExperimentalFeaturesDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='D3D12ExperimentalFeaturesDesc.xml' path='doc/member[@name="D3D12ExperimentalFeaturesDesc.next"]/*' />
    [NativeTypeName("const void *")]
    public void* next;

    /// <include file='D3D12ExperimentalFeaturesDesc.xml' path='doc/member[@name="D3D12ExperimentalFeaturesDesc.featureCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint featureCount;

    /// <include file='D3D12ExperimentalFeaturesDesc.xml' path='doc/member[@name="D3D12ExperimentalFeaturesDesc.featureIIDs"]/*' />
    [NativeTypeName("const void *")]
    public void* featureIIDs;

    /// <include file='D3D12ExperimentalFeaturesDesc.xml' path='doc/member[@name="D3D12ExperimentalFeaturesDesc.configurationStructs"]/*' />
    [NativeTypeName("const void *")]
    public void* configurationStructs;

    /// <include file='D3D12ExperimentalFeaturesDesc.xml' path='doc/member[@name="D3D12ExperimentalFeaturesDesc.configurationStructSizes"]/*' />
    [NativeTypeName("const uint32_t *")]
    public uint* configurationStructSizes;
}
