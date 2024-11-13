namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureDesc.xml' path='doc/member[@name="AccelerationStructureDesc"]/*' />
public unsafe partial struct AccelerationStructureDesc
{
    /// <include file='AccelerationStructureDesc.xml' path='doc/member[@name="AccelerationStructureDesc.size"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong size;

    /// <include file='AccelerationStructureDesc.xml' path='doc/member[@name="AccelerationStructureDesc.label"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* label;
}
