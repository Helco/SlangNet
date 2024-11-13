namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureBuildFlags.xml' path='doc/member[@name="AccelerationStructureBuildFlags"]/*' />
public enum AccelerationStructureBuildFlags
{
    /// <include file='AccelerationStructureBuildFlags.xml' path='doc/member[@name="AccelerationStructureBuildFlags.None"]/*' />
    None = 0,

    /// <include file='AccelerationStructureBuildFlags.xml' path='doc/member[@name="AccelerationStructureBuildFlags.AllowUpdate"]/*' />
    AllowUpdate = (1 << 0),

    /// <include file='AccelerationStructureBuildFlags.xml' path='doc/member[@name="AccelerationStructureBuildFlags.AllowCompaction"]/*' />
    AllowCompaction = (1 << 1),

    /// <include file='AccelerationStructureBuildFlags.xml' path='doc/member[@name="AccelerationStructureBuildFlags.PreferFastTrace"]/*' />
    PreferFastTrace = (1 << 2),

    /// <include file='AccelerationStructureBuildFlags.xml' path='doc/member[@name="AccelerationStructureBuildFlags.PreferFastBuild"]/*' />
    PreferFastBuild = (1 << 3),

    /// <include file='AccelerationStructureBuildFlags.xml' path='doc/member[@name="AccelerationStructureBuildFlags.MinimizeMemory"]/*' />
    MinimizeMemory = (1 << 4),
}
