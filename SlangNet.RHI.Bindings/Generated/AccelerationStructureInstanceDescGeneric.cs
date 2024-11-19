using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureInstanceDescGeneric.xml' path='doc/member[@name="AccelerationStructureInstanceDescGeneric"]/*' />
public partial struct AccelerationStructureInstanceDescGeneric
{
    /// <include file='AccelerationStructureInstanceDescGeneric.xml' path='doc/member[@name="AccelerationStructureInstanceDescGeneric.transform"]/*' />
    [NativeTypeName("float[3][4]")]
    public _transform_e__FixedBuffer transform;

    public uint _bitfield1;

    /// <include file='AccelerationStructureInstanceDescGeneric.xml' path='doc/member[@name="AccelerationStructureInstanceDescGeneric.instanceID"]/*' />
    [NativeTypeName("uint32_t : 24")]
    public uint instanceID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return _bitfield1 & 0xFFFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~0xFFFFFFu) | (value & 0xFFFFFFu);
        }
    }

    /// <include file='AccelerationStructureInstanceDescGeneric.xml' path='doc/member[@name="AccelerationStructureInstanceDescGeneric.instanceMask"]/*' />
    [NativeTypeName("uint32_t : 8")]
    public uint instanceMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (_bitfield1 >> 24) & 0xFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
        }
    }

    public uint _bitfield2;

    /// <include file='AccelerationStructureInstanceDescGeneric.xml' path='doc/member[@name="AccelerationStructureInstanceDescGeneric.instanceContributionToHitGroupIndex"]/*' />
    [NativeTypeName("uint32_t : 24")]
    public uint instanceContributionToHitGroupIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return _bitfield2 & 0xFFFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~0xFFFFFFu) | (value & 0xFFFFFFu);
        }
    }

    /// <include file='AccelerationStructureInstanceDescGeneric.xml' path='doc/member[@name="AccelerationStructureInstanceDescGeneric.flags"]/*' />
    [NativeTypeName("rhi::AccelerationStructureInstanceFlags : 8")]
    public AccelerationStructureInstanceFlags flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (AccelerationStructureInstanceFlags)((_bitfield2 >> 24) & 0xFFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0xFFu << 24)) | (((uint)(value) & 0xFFu) << 24);
        }
    }

    /// <include file='AccelerationStructureInstanceDescGeneric.xml' path='doc/member[@name="AccelerationStructureInstanceDescGeneric.accelerationStructure"]/*' />
    [NativeTypeName("rhi::AccelerationStructureHandle")]
    public AccelerationStructureHandle accelerationStructure;

    /// <include file='_transform_e__FixedBuffer.xml' path='doc/member[@name="_transform_e__FixedBuffer"]/*' />
    [InlineArray(3 * 4)]
    public partial struct _transform_e__FixedBuffer
    {
        public float e0_0;
    }
}
