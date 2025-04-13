namespace SlangNet.RHI.Unsafe;

/// <include file='InputLayoutDesc.xml' path='doc/member[@name="InputLayoutDesc"]/*' />
public unsafe partial struct InputLayoutDesc
{
    /// <include file='InputLayoutDesc.xml' path='doc/member[@name="InputLayoutDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='InputLayoutDesc.xml' path='doc/member[@name="InputLayoutDesc.next"]/*' />
    [NativeTypeName("const void *")]
    public void* next;

    /// <include file='InputLayoutDesc.xml' path='doc/member[@name="InputLayoutDesc.inputElements"]/*' />
    [NativeTypeName("const InputElementDesc *")]
    public InputElementDesc* inputElements;

    /// <include file='InputLayoutDesc.xml' path='doc/member[@name="InputLayoutDesc.inputElementCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint inputElementCount;

    /// <include file='InputLayoutDesc.xml' path='doc/member[@name="InputLayoutDesc.vertexStreams"]/*' />
    [NativeTypeName("const VertexStreamDesc *")]
    public VertexStreamDesc* vertexStreams;

    /// <include file='InputLayoutDesc.xml' path='doc/member[@name="InputLayoutDesc.vertexStreamCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexStreamCount;
}
