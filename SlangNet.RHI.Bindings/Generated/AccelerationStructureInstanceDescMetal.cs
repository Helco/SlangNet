namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureInstanceDescMetal.xml' path='doc/member[@name="AccelerationStructureInstanceDescMetal"]/*' />
public unsafe partial struct AccelerationStructureInstanceDescMetal
{
    /// <include file='AccelerationStructureInstanceDescMetal.xml' path='doc/member[@name="AccelerationStructureInstanceDescMetal.transform"]/*' />
    [NativeTypeName("float[4][3]")]
    public fixed float transform[4 * 3];

    /// <include file='AccelerationStructureInstanceDescMetal.xml' path='doc/member[@name="AccelerationStructureInstanceDescMetal.options"]/*' />
    [NativeTypeName("uint32_t")]
    public uint options;

    /// <include file='AccelerationStructureInstanceDescMetal.xml' path='doc/member[@name="AccelerationStructureInstanceDescMetal.mask"]/*' />
    [NativeTypeName("uint32_t")]
    public uint mask;

    /// <include file='AccelerationStructureInstanceDescMetal.xml' path='doc/member[@name="AccelerationStructureInstanceDescMetal.intersectionFunctionTableOffset"]/*' />
    [NativeTypeName("uint32_t")]
    public uint intersectionFunctionTableOffset;

    /// <include file='AccelerationStructureInstanceDescMetal.xml' path='doc/member[@name="AccelerationStructureInstanceDescMetal.accelerationStructureIndex"]/*' />
    [NativeTypeName("uint32_t")]
    public uint accelerationStructureIndex;

    /// <include file='AccelerationStructureInstanceDescMetal.xml' path='doc/member[@name="AccelerationStructureInstanceDescMetal.userID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint userID;
}
