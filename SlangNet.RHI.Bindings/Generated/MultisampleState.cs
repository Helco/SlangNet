namespace SlangNet.RHI.Unsafe;

/// <include file='MultisampleState.xml' path='doc/member[@name="MultisampleState"]/*' />
public partial struct MultisampleState
{
    /// <include file='MultisampleState.xml' path='doc/member[@name="MultisampleState.sampleCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int sampleCount;

    /// <include file='MultisampleState.xml' path='doc/member[@name="MultisampleState.sampleMask"]/*' />
    [NativeTypeName("uint32_t")]
    public uint sampleMask;

    /// <include file='MultisampleState.xml' path='doc/member[@name="MultisampleState.alphaToCoverageEnable"]/*' />
    public bool alphaToCoverageEnable;

    /// <include file='MultisampleState.xml' path='doc/member[@name="MultisampleState.alphaToOneEnable"]/*' />
    public bool alphaToOneEnable;
}
