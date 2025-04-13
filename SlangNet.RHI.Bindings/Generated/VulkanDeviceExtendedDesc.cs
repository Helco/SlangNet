namespace SlangNet.RHI.Unsafe;

/// <include file='VulkanDeviceExtendedDesc.xml' path='doc/member[@name="VulkanDeviceExtendedDesc"]/*' />
public unsafe partial struct VulkanDeviceExtendedDesc
{
    /// <include file='VulkanDeviceExtendedDesc.xml' path='doc/member[@name="VulkanDeviceExtendedDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='VulkanDeviceExtendedDesc.xml' path='doc/member[@name="VulkanDeviceExtendedDesc.next"]/*' />
    [NativeTypeName("const void *")]
    public void* next;

    /// <include file='VulkanDeviceExtendedDesc.xml' path='doc/member[@name="VulkanDeviceExtendedDesc.enableDebugPrintf"]/*' />
    public bool enableDebugPrintf;
}
