namespace SlangNet.RHI.Unsafe;

/// <include file='FenceDesc.xml' path='doc/member[@name="FenceDesc"]/*' />
public unsafe partial struct FenceDesc
{
    /// <include file='FenceDesc.xml' path='doc/member[@name="FenceDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='FenceDesc.xml' path='doc/member[@name="FenceDesc.next"]/*' />
    public void* next;

    /// <include file='FenceDesc.xml' path='doc/member[@name="FenceDesc.initialValue"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong initialValue;

    /// <include file='FenceDesc.xml' path='doc/member[@name="FenceDesc.isShared"]/*' />
    public bool isShared;

    /// <include file='FenceDesc.xml' path='doc/member[@name="FenceDesc.label"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* label;
}
