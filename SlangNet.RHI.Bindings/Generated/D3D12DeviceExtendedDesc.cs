namespace SlangNet.RHI.Unsafe;

/// <include file='D3D12DeviceExtendedDesc.xml' path='doc/member[@name="D3D12DeviceExtendedDesc"]/*' />
public unsafe partial struct D3D12DeviceExtendedDesc
{
    /// <include file='D3D12DeviceExtendedDesc.xml' path='doc/member[@name="D3D12DeviceExtendedDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='D3D12DeviceExtendedDesc.xml' path='doc/member[@name="D3D12DeviceExtendedDesc.rootParameterShaderAttributeName"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* rootParameterShaderAttributeName;

    /// <include file='D3D12DeviceExtendedDesc.xml' path='doc/member[@name="D3D12DeviceExtendedDesc.debugBreakOnD3D12Error"]/*' />
    public bool debugBreakOnD3D12Error;

    /// <include file='D3D12DeviceExtendedDesc.xml' path='doc/member[@name="D3D12DeviceExtendedDesc.highestShaderModel"]/*' />
    [NativeTypeName("uint32_t")]
    public uint highestShaderModel;
}
