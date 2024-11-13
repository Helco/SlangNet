namespace SlangNet.RHI.Unsafe;

/// <include file='IndirectDrawArguments.xml' path='doc/member[@name="IndirectDrawArguments"]/*' />
public partial struct IndirectDrawArguments
{
    /// <include file='IndirectDrawArguments.xml' path='doc/member[@name="IndirectDrawArguments.VertexCountPerInstance"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int VertexCountPerInstance;

    /// <include file='IndirectDrawArguments.xml' path='doc/member[@name="IndirectDrawArguments.InstanceCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int InstanceCount;

    /// <include file='IndirectDrawArguments.xml' path='doc/member[@name="IndirectDrawArguments.StartVertexLocation"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int StartVertexLocation;

    /// <include file='IndirectDrawArguments.xml' path='doc/member[@name="IndirectDrawArguments.StartInstanceLocation"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int StartInstanceLocation;
}
