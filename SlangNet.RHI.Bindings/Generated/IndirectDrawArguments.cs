namespace SlangNet.RHI.Unsafe;

/// <include file='IndirectDrawArguments.xml' path='doc/member[@name="IndirectDrawArguments"]/*' />
public partial struct IndirectDrawArguments
{
    /// <include file='IndirectDrawArguments.xml' path='doc/member[@name="IndirectDrawArguments.vertexCountPerInstance"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexCountPerInstance;

    /// <include file='IndirectDrawArguments.xml' path='doc/member[@name="IndirectDrawArguments.instanceCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint instanceCount;

    /// <include file='IndirectDrawArguments.xml' path='doc/member[@name="IndirectDrawArguments.startVertexLocation"]/*' />
    [NativeTypeName("uint32_t")]
    public uint startVertexLocation;

    /// <include file='IndirectDrawArguments.xml' path='doc/member[@name="IndirectDrawArguments.startInstanceLocation"]/*' />
    [NativeTypeName("uint32_t")]
    public uint startInstanceLocation;
}
