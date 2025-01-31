namespace SlangNet.RHI.Unsafe;

/// <include file='VertexStreamDesc.xml' path='doc/member[@name="VertexStreamDesc"]/*' />
public partial struct VertexStreamDesc
{
    /// <include file='VertexStreamDesc.xml' path='doc/member[@name="VertexStreamDesc.stride"]/*' />
    [NativeTypeName("uint32_t")]
    public uint stride;

    /// <include file='VertexStreamDesc.xml' path='doc/member[@name="VertexStreamDesc.slotClass"]/*' />
    [NativeTypeName("rhi::InputSlotClass")]
    public InputSlotClass slotClass;

    /// <include file='VertexStreamDesc.xml' path='doc/member[@name="VertexStreamDesc.instanceDataStepRate"]/*' />
    [NativeTypeName("uint32_t")]
    public uint instanceDataStepRate;
}
