namespace SlangNet.RHI.Unsafe;

/// <include file='InputElementDesc.xml' path='doc/member[@name="InputElementDesc"]/*' />
public unsafe partial struct InputElementDesc
{
    /// <include file='InputElementDesc.xml' path='doc/member[@name="InputElementDesc.semanticName"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* semanticName;

    /// <include file='InputElementDesc.xml' path='doc/member[@name="InputElementDesc.semanticIndex"]/*' />
    [NativeTypeName("uint32_t")]
    public uint semanticIndex;

    /// <include file='InputElementDesc.xml' path='doc/member[@name="InputElementDesc.format"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format format;

    /// <include file='InputElementDesc.xml' path='doc/member[@name="InputElementDesc.offset"]/*' />
    [NativeTypeName("uint32_t")]
    public uint offset;

    /// <include file='InputElementDesc.xml' path='doc/member[@name="InputElementDesc.bufferSlotIndex"]/*' />
    [NativeTypeName("uint32_t")]
    public uint bufferSlotIndex;
}
