namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureInstanceDescType.xml' path='doc/member[@name="AccelerationStructureInstanceDescType"]/*' />
public enum AccelerationStructureInstanceDescType
{
    /// <include file='AccelerationStructureInstanceDescType.xml' path='doc/member[@name="AccelerationStructureInstanceDescType.Generic"]/*' />
    Generic,

    /// <include file='AccelerationStructureInstanceDescType.xml' path='doc/member[@name="AccelerationStructureInstanceDescType.D3D12"]/*' />
    D3D12,

    /// <include file='AccelerationStructureInstanceDescType.xml' path='doc/member[@name="AccelerationStructureInstanceDescType.Vulkan"]/*' />
    Vulkan,

    /// <include file='AccelerationStructureInstanceDescType.xml' path='doc/member[@name="AccelerationStructureInstanceDescType.Optix"]/*' />
    Optix,

    /// <include file='AccelerationStructureInstanceDescType.xml' path='doc/member[@name="AccelerationStructureInstanceDescType.Metal"]/*' />
    Metal,
}
