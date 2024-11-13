using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureInstanceDescVulkan.xml' path='doc/member[@name="AccelerationStructureInstanceDescVulkan"]/*' />
public unsafe partial struct AccelerationStructureInstanceDescVulkan
{
    /// <include file='AccelerationStructureInstanceDescVulkan.xml' path='doc/member[@name="AccelerationStructureInstanceDescVulkan.transform"]/*' />
    [NativeTypeName("float[4][3]")]
    public fixed float transform[4 * 3];

    public uint _bitfield1;

    /// <include file='AccelerationStructureInstanceDescVulkan.xml' path='doc/member[@name="AccelerationStructureInstanceDescVulkan.instanceCustomIndex"]/*' />
    [NativeTypeName("uint32_t : 24")]
    public uint instanceCustomIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _bitfield1 & 0xFFFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~0xFFFFFFu) | (value & 0xFFFFFFu);
        }
    }

    /// <include file='AccelerationStructureInstanceDescVulkan.xml' path='doc/member[@name="AccelerationStructureInstanceDescVulkan.mask"]/*' />
    [NativeTypeName("uint32_t : 8")]
    public uint mask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
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

    /// <include file='AccelerationStructureInstanceDescVulkan.xml' path='doc/member[@name="AccelerationStructureInstanceDescVulkan.instanceShaderBindingTableRecordOffset"]/*' />
    [NativeTypeName("uint32_t : 24")]
    public uint instanceShaderBindingTableRecordOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _bitfield2 & 0xFFFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~0xFFFFFFu) | (value & 0xFFFFFFu);
        }
    }

    /// <include file='AccelerationStructureInstanceDescVulkan.xml' path='doc/member[@name="AccelerationStructureInstanceDescVulkan.flags"]/*' />
    [NativeTypeName("uint32_t : 8")]
    public uint flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield2 >> 24) & 0xFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
        }
    }

    /// <include file='AccelerationStructureInstanceDescVulkan.xml' path='doc/member[@name="AccelerationStructureInstanceDescVulkan.accelerationStructureReference"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong accelerationStructureReference;
}
