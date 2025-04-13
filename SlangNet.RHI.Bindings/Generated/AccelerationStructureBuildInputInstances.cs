namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureBuildInputInstances.xml' path='doc/member[@name="AccelerationStructureBuildInputInstances"]/*' />
public partial struct AccelerationStructureBuildInputInstances
{
    /// <include file='AccelerationStructureBuildInputInstances.xml' path='doc/member[@name="AccelerationStructureBuildInputInstances.instanceBuffer"]/*' />
    [NativeTypeName("rhi::BufferOffsetPair")]
    public BufferOffsetPair instanceBuffer;

    /// <include file='AccelerationStructureBuildInputInstances.xml' path='doc/member[@name="AccelerationStructureBuildInputInstances.instanceStride"]/*' />
    [NativeTypeName("uint32_t")]
    public uint instanceStride;

    /// <include file='AccelerationStructureBuildInputInstances.xml' path='doc/member[@name="AccelerationStructureBuildInputInstances.instanceCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint instanceCount;
}
