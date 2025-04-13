namespace SlangNet.RHI.Unsafe;

/// <include file='SubmitDesc.xml' path='doc/member[@name="SubmitDesc"]/*' />
public unsafe partial struct SubmitDesc
{
    /// <include file='SubmitDesc.xml' path='doc/member[@name="SubmitDesc.commandBuffers"]/*' />
    public ICommandBuffer** commandBuffers;

    /// <include file='SubmitDesc.xml' path='doc/member[@name="SubmitDesc.commandBufferCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint commandBufferCount;

    /// <include file='SubmitDesc.xml' path='doc/member[@name="SubmitDesc.waitFences"]/*' />
    public IFence** waitFences;

    /// <include file='SubmitDesc.xml' path='doc/member[@name="SubmitDesc.waitFenceValues"]/*' />
    [NativeTypeName("const uint64_t *")]
    public ulong* waitFenceValues;

    /// <include file='SubmitDesc.xml' path='doc/member[@name="SubmitDesc.waitFenceCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint waitFenceCount;

    /// <include file='SubmitDesc.xml' path='doc/member[@name="SubmitDesc.signalFences"]/*' />
    public IFence** signalFences;

    /// <include file='SubmitDesc.xml' path='doc/member[@name="SubmitDesc.signalFenceValues"]/*' />
    [NativeTypeName("const uint64_t *")]
    public ulong* signalFenceValues;

    /// <include file='SubmitDesc.xml' path='doc/member[@name="SubmitDesc.signalFenceCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint signalFenceCount;
}
