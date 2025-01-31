namespace SlangNet.RHI.Unsafe;

/// <include file='QueryPoolDesc.xml' path='doc/member[@name="QueryPoolDesc"]/*' />
public unsafe partial struct QueryPoolDesc
{
    /// <include file='QueryPoolDesc.xml' path='doc/member[@name="QueryPoolDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='QueryPoolDesc.xml' path='doc/member[@name="QueryPoolDesc.next"]/*' />
    public void* next;

    /// <include file='QueryPoolDesc.xml' path='doc/member[@name="QueryPoolDesc.type"]/*' />
    [NativeTypeName("rhi::QueryType")]
    public QueryType type;

    /// <include file='QueryPoolDesc.xml' path='doc/member[@name="QueryPoolDesc.count"]/*' />
    [NativeTypeName("uint32_t")]
    public uint count;

    /// <include file='QueryPoolDesc.xml' path='doc/member[@name="QueryPoolDesc.label"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* label;
}
