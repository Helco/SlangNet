namespace SlangNet.RHI.Unsafe;

/// <include file='IndirectDrawIndexedArguments.xml' path='doc/member[@name="IndirectDrawIndexedArguments"]/*' />
public partial struct IndirectDrawIndexedArguments
{
    /// <include file='IndirectDrawIndexedArguments.xml' path='doc/member[@name="IndirectDrawIndexedArguments.IndexCountPerInstance"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int IndexCountPerInstance;

    /// <include file='IndirectDrawIndexedArguments.xml' path='doc/member[@name="IndirectDrawIndexedArguments.InstanceCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int InstanceCount;

    /// <include file='IndirectDrawIndexedArguments.xml' path='doc/member[@name="IndirectDrawIndexedArguments.StartIndexLocation"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int StartIndexLocation;

    /// <include file='IndirectDrawIndexedArguments.xml' path='doc/member[@name="IndirectDrawIndexedArguments.BaseVertexLocation"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int BaseVertexLocation;

    /// <include file='IndirectDrawIndexedArguments.xml' path='doc/member[@name="IndirectDrawIndexedArguments.StartInstanceLocation"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int StartInstanceLocation;
}
