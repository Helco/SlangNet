using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureInstanceDescOptix.xml' path='doc/member[@name="AccelerationStructureInstanceDescOptix"]/*' />
public partial struct AccelerationStructureInstanceDescOptix
{
    /// <include file='AccelerationStructureInstanceDescOptix.xml' path='doc/member[@name="AccelerationStructureInstanceDescOptix.transform"]/*' />
    [NativeTypeName("float[3][4]")]
    public _transform_e__FixedBuffer transform;

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
    public _pad_e__FixedBuffer pad;

    /// <include file='_transform_e__FixedBuffer.xml' path='doc/member[@name="_transform_e__FixedBuffer"]/*' />
    [InlineArray(3 * 4)]
    public partial struct _transform_e__FixedBuffer
    {
        public float e0_0;
    }

    /// <include file='_pad_e__FixedBuffer.xml' path='doc/member[@name="_pad_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _pad_e__FixedBuffer
    {
        public uint e0;
    }
}
