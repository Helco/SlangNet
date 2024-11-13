namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureInstanceFlags.xml' path='doc/member[@name="AccelerationStructureInstanceFlags"]/*' />
[NativeTypeName("uint32_t")]
public enum AccelerationStructureInstanceFlags : uint
{
    /// <include file='AccelerationStructureInstanceFlags.xml' path='doc/member[@name="AccelerationStructureInstanceFlags.None"]/*' />
    None = 0,

    /// <include file='AccelerationStructureInstanceFlags.xml' path='doc/member[@name="AccelerationStructureInstanceFlags.TriangleFacingCullDisable"]/*' />
    TriangleFacingCullDisable = (1 << 0),

    /// <include file='AccelerationStructureInstanceFlags.xml' path='doc/member[@name="AccelerationStructureInstanceFlags.TriangleFrontCounterClockwise"]/*' />
    TriangleFrontCounterClockwise = (1 << 1),

    /// <include file='AccelerationStructureInstanceFlags.xml' path='doc/member[@name="AccelerationStructureInstanceFlags.ForceOpaque"]/*' />
    ForceOpaque = (1 << 2),

    /// <include file='AccelerationStructureInstanceFlags.xml' path='doc/member[@name="AccelerationStructureInstanceFlags.NoOpaque"]/*' />
    NoOpaque = (1 << 3),
}
