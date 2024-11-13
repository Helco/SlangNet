namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureInstanceDescOptix.xml' path='doc/member[@name="AccelerationStructureInstanceDescOptix"]/*' />
public unsafe partial struct AccelerationStructureInstanceDescOptix
{
    /// <include file='AccelerationStructureInstanceDescOptix.xml' path='doc/member[@name="AccelerationStructureInstanceDescOptix.transform"]/*' />
    [NativeTypeName("float[3][4]")]
    public fixed float transform[3 * 4];

    /// <include file='AccelerationStructureInstanceDescOptix.xml' path='doc/member[@name="AccelerationStructureInstanceDescOptix.instanceId"]/*' />
    [NativeTypeName("uint32_t")]
    public uint instanceId;

    /// <include file='AccelerationStructureInstanceDescOptix.xml' path='doc/member[@name="AccelerationStructureInstanceDescOptix.sbtOffset"]/*' />
    [NativeTypeName("uint32_t")]
    public uint sbtOffset;

    /// <include file='AccelerationStructureInstanceDescOptix.xml' path='doc/member[@name="AccelerationStructureInstanceDescOptix.visibilityMask"]/*' />
    [NativeTypeName("uint32_t")]
    public uint visibilityMask;

    /// <include file='AccelerationStructureInstanceDescOptix.xml' path='doc/member[@name="AccelerationStructureInstanceDescOptix.flags"]/*' />
    [NativeTypeName("uint32_t")]
    public uint flags;

    /// <include file='AccelerationStructureInstanceDescOptix.xml' path='doc/member[@name="AccelerationStructureInstanceDescOptix.traversableHandle"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong traversableHandle;

    /// <include file='AccelerationStructureInstanceDescOptix.xml' path='doc/member[@name="AccelerationStructureInstanceDescOptix.pad"]/*' />
    [NativeTypeName("uint32_t[2]")]
    public fixed uint pad[2];
}
