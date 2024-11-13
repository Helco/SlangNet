namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureBuildInputInstances.xml' path='doc/member[@name="AccelerationStructureBuildInputInstances"]/*' />
[NativeTypeName("struct AccelerationStructureBuildInputInstances : rhi::AccelerationStructureBuildInput")]
public partial struct AccelerationStructureBuildInputInstances
{
    /// <include file='AccelerationStructureBuildInputInstances.xml' path='doc/member[@name="AccelerationStructureBuildInputInstances.type"]/*' />
    [NativeTypeName("const AccelerationStructureBuildInputType")]
    public AccelerationStructureBuildInputType type;

    /// <include file='AccelerationStructureBuildInputInstances.xml' path='doc/member[@name="AccelerationStructureBuildInputInstances.instanceBuffer"]/*' />
    [NativeTypeName("rhi::BufferWithOffset")]
    public BufferWithOffset instanceBuffer;

    /// <include file='AccelerationStructureBuildInputInstances.xml' path='doc/member[@name="AccelerationStructureBuildInputInstances.instanceStride"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong instanceStride;

    /// <include file='AccelerationStructureBuildInputInstances.xml' path='doc/member[@name="AccelerationStructureBuildInputInstances.instanceCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int instanceCount;
}
