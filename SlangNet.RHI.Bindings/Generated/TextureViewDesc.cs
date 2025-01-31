namespace SlangNet.RHI.Unsafe;

/// <include file='TextureViewDesc.xml' path='doc/member[@name="TextureViewDesc"]/*' />
public unsafe partial struct TextureViewDesc
{
    /// <include file='TextureViewDesc.xml' path='doc/member[@name="TextureViewDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='TextureViewDesc.xml' path='doc/member[@name="TextureViewDesc.next"]/*' />
    public void* next;

    /// <include file='TextureViewDesc.xml' path='doc/member[@name="TextureViewDesc.format"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format format;

    /// <include file='TextureViewDesc.xml' path='doc/member[@name="TextureViewDesc.aspect"]/*' />
    [NativeTypeName("rhi::TextureAspect")]
    public TextureAspect aspect;

    /// <include file='TextureViewDesc.xml' path='doc/member[@name="TextureViewDesc.subresourceRange"]/*' />
    [NativeTypeName("rhi::SubresourceRange")]
    public SubresourceRange subresourceRange;

    /// <include file='TextureViewDesc.xml' path='doc/member[@name="TextureViewDesc.label"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* label;
}
