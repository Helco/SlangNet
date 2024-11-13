namespace SlangNet.RHI.Unsafe;

/// <include file='DrawArguments.xml' path='doc/member[@name="DrawArguments"]/*' />
public partial struct DrawArguments
{
    /// <include file='DrawArguments.xml' path='doc/member[@name="DrawArguments.vertexCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int vertexCount;

    /// <include file='DrawArguments.xml' path='doc/member[@name="DrawArguments.instanceCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int instanceCount;

    /// <include file='DrawArguments.xml' path='doc/member[@name="DrawArguments.startVertexLocation"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int startVertexLocation;

    /// <include file='DrawArguments.xml' path='doc/member[@name="DrawArguments.startInstanceLocation"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int startInstanceLocation;

    /// <include file='DrawArguments.xml' path='doc/member[@name="DrawArguments.startIndexLocation"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int startIndexLocation;
}
