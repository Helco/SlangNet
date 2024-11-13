using System;

namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureSizes.xml' path='doc/member[@name="AccelerationStructureSizes"]/*' />
public partial struct AccelerationStructureSizes
{
    /// <include file='AccelerationStructureSizes.xml' path='doc/member[@name="AccelerationStructureSizes.accelerationStructureSize"]/*' />
    [NativeTypeName("rhi::Size")]
    public UIntPtr accelerationStructureSize;

    /// <include file='AccelerationStructureSizes.xml' path='doc/member[@name="AccelerationStructureSizes.scratchSize"]/*' />
    [NativeTypeName("rhi::Size")]
    public UIntPtr scratchSize;

    /// <include file='AccelerationStructureSizes.xml' path='doc/member[@name="AccelerationStructureSizes.updateScratchSize"]/*' />
    [NativeTypeName("rhi::Size")]
    public UIntPtr updateScratchSize;
}
