namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureDesc.xml' path='doc/member[@name="AccelerationStructureDesc"]/*' />
public unsafe partial struct AccelerationStructureDesc
{
    /// <include file='AccelerationStructureDesc.xml' path='doc/member[@name="AccelerationStructureDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='AccelerationStructureDesc.xml' path='doc/member[@name="AccelerationStructureDesc.next"]/*' />
    [NativeTypeName("const void *")]
    public void* next;

    /// <include file='AccelerationStructureDesc.xml' path='doc/member[@name="AccelerationStructureDesc.size"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong size;

    /// <include file='AccelerationStructureDesc.xml' path='doc/member[@name="AccelerationStructureDesc.label"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* label;
}
