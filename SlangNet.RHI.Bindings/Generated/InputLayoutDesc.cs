namespace SlangNet.RHI.Unsafe;

/// <include file='InputLayoutDesc.xml' path='doc/member[@name="InputLayoutDesc"]/*' />
public unsafe partial struct InputLayoutDesc
{
    /// <include file='InputLayoutDesc.xml' path='doc/member[@name="InputLayoutDesc.inputElements"]/*' />
    [NativeTypeName("const InputElementDesc *")]
    public InputElementDesc* inputElements;

    /// <include file='InputLayoutDesc.xml' path='doc/member[@name="InputLayoutDesc.inputElementCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int inputElementCount;

    /// <include file='InputLayoutDesc.xml' path='doc/member[@name="InputLayoutDesc.vertexStreams"]/*' />
    [NativeTypeName("const VertexStreamDesc *")]
    public VertexStreamDesc* vertexStreams;

    /// <include file='InputLayoutDesc.xml' path='doc/member[@name="InputLayoutDesc.vertexStreamCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int vertexStreamCount;
}
