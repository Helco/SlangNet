using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureInstanceDescMetal.xml' path='doc/member[@name="AccelerationStructureInstanceDescMetal"]/*' />
public partial struct AccelerationStructureInstanceDescMetal
{
    /// <include file='AccelerationStructureInstanceDescMetal.xml' path='doc/member[@name="AccelerationStructureInstanceDescMetal.transform"]/*' />
    [NativeTypeName("float[4][3]")]
    public _transform_e__FixedBuffer transform;

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

    /// <include file='_transform_e__FixedBuffer.xml' path='doc/member[@name="_transform_e__FixedBuffer"]/*' />
    [InlineArray(4 * 3)]
    public partial struct _transform_e__FixedBuffer
    {
        public float e0_0;
    }
}
