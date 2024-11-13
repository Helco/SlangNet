namespace SlangNet.RHI.Unsafe;

/// <include file='InputElementDesc.xml' path='doc/member[@name="InputElementDesc"]/*' />
public unsafe partial struct InputElementDesc
{
    /// <include file='InputElementDesc.xml' path='doc/member[@name="InputElementDesc.semanticName"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* semanticName;

    /// <include file='InputElementDesc.xml' path='doc/member[@name="InputElementDesc.semanticIndex"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int semanticIndex;

    /// <include file='InputElementDesc.xml' path='doc/member[@name="InputElementDesc.format"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format format;

    /// <include file='InputElementDesc.xml' path='doc/member[@name="InputElementDesc.offset"]/*' />
    [NativeTypeName("rhi::Offset")]
    public nuint offset;

    /// <include file='InputElementDesc.xml' path='doc/member[@name="InputElementDesc.bufferSlotIndex"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int bufferSlotIndex;
}
