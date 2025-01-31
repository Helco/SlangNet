namespace SlangNet.RHI.Unsafe;

/// <include file='IndirectDrawIndexedArguments.xml' path='doc/member[@name="IndirectDrawIndexedArguments"]/*' />
public partial struct IndirectDrawIndexedArguments
{
    /// <include file='IndirectDrawIndexedArguments.xml' path='doc/member[@name="IndirectDrawIndexedArguments.indexCountPerInstance"]/*' />
    [NativeTypeName("uint32_t")]
    public uint indexCountPerInstance;

    /// <include file='IndirectDrawIndexedArguments.xml' path='doc/member[@name="IndirectDrawIndexedArguments.instanceCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint instanceCount;

    /// <include file='IndirectDrawIndexedArguments.xml' path='doc/member[@name="IndirectDrawIndexedArguments.startIndexLocation"]/*' />
    [NativeTypeName("uint32_t")]
    public uint startIndexLocation;

    /// <include file='IndirectDrawIndexedArguments.xml' path='doc/member[@name="IndirectDrawIndexedArguments.baseVertexLocation"]/*' />
    [NativeTypeName("int32_t")]
    public int baseVertexLocation;

    /// <include file='IndirectDrawIndexedArguments.xml' path='doc/member[@name="IndirectDrawIndexedArguments.startInstanceLocation"]/*' />
    [NativeTypeName("uint32_t")]
    public uint startInstanceLocation;
}
