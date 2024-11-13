namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureSizes.xml' path='doc/member[@name="AccelerationStructureSizes"]/*' />
public partial struct AccelerationStructureSizes
{
    /// <include file='AccelerationStructureSizes.xml' path='doc/member[@name="AccelerationStructureSizes.accelerationStructureSize"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong accelerationStructureSize;

    /// <include file='AccelerationStructureSizes.xml' path='doc/member[@name="AccelerationStructureSizes.scratchSize"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong scratchSize;

    /// <include file='AccelerationStructureSizes.xml' path='doc/member[@name="AccelerationStructureSizes.updateScratchSize"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong updateScratchSize;
}
