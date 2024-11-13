namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureGeometryFlags.xml' path='doc/member[@name="AccelerationStructureGeometryFlags"]/*' />
public enum AccelerationStructureGeometryFlags
{
    /// <include file='AccelerationStructureGeometryFlags.xml' path='doc/member[@name="AccelerationStructureGeometryFlags.None"]/*' />
    None = 0,

    /// <include file='AccelerationStructureGeometryFlags.xml' path='doc/member[@name="AccelerationStructureGeometryFlags.Opaque"]/*' />
    Opaque = (1 << 0),

    /// <include file='AccelerationStructureGeometryFlags.xml' path='doc/member[@name="AccelerationStructureGeometryFlags.NoDuplicateAnyHitInvocation"]/*' />
    NoDuplicateAnyHitInvocation = (1 << 1),
}
