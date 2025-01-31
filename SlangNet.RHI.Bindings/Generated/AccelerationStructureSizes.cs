namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureSizes.xml' path='doc/member[@name="AccelerationStructureSizes"]/*' />
public partial struct AccelerationStructureSizes
{
    /// <include file='AccelerationStructureSizes.xml' path='doc/member[@name="AccelerationStructureSizes.accelerationStructureSize"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong accelerationStructureSize;

    /// <include file='AccelerationStructureSizes.xml' path='doc/member[@name="AccelerationStructureSizes.scratchSize"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong scratchSize;

    /// <include file='AccelerationStructureSizes.xml' path='doc/member[@name="AccelerationStructureSizes.updateScratchSize"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong updateScratchSize;
}
