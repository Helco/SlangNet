namespace SlangNet.RHI.Unsafe;

/// <include file='MultisampleDesc.xml' path='doc/member[@name="MultisampleDesc"]/*' />
public partial struct MultisampleDesc
{
    /// <include file='MultisampleDesc.xml' path='doc/member[@name="MultisampleDesc.sampleCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint sampleCount;

    /// <include file='MultisampleDesc.xml' path='doc/member[@name="MultisampleDesc.sampleMask"]/*' />
    [NativeTypeName("uint32_t")]
    public uint sampleMask;

    /// <include file='MultisampleDesc.xml' path='doc/member[@name="MultisampleDesc.alphaToCoverageEnable"]/*' />
    public bool alphaToCoverageEnable;

    /// <include file='MultisampleDesc.xml' path='doc/member[@name="MultisampleDesc.alphaToOneEnable"]/*' />
    public bool alphaToOneEnable;
}
