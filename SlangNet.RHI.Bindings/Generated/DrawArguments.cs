namespace SlangNet.RHI.Unsafe;

/// <include file='DrawArguments.xml' path='doc/member[@name="DrawArguments"]/*' />
public partial struct DrawArguments
{
    /// <include file='DrawArguments.xml' path='doc/member[@name="DrawArguments.vertexCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexCount;

    /// <include file='DrawArguments.xml' path='doc/member[@name="DrawArguments.instanceCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint instanceCount;

    /// <include file='DrawArguments.xml' path='doc/member[@name="DrawArguments.startVertexLocation"]/*' />
    [NativeTypeName("uint32_t")]
    public uint startVertexLocation;

    /// <include file='DrawArguments.xml' path='doc/member[@name="DrawArguments.startInstanceLocation"]/*' />
    [NativeTypeName("uint32_t")]
    public uint startInstanceLocation;

    /// <include file='DrawArguments.xml' path='doc/member[@name="DrawArguments.startIndexLocation"]/*' />
    [NativeTypeName("uint32_t")]
    public uint startIndexLocation;
}
