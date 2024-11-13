using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureInstanceDescD3D12.xml' path='doc/member[@name="AccelerationStructureInstanceDescD3D12"]/*' />
public unsafe partial struct AccelerationStructureInstanceDescD3D12
{
    /// <include file='AccelerationStructureInstanceDescD3D12.xml' path='doc/member[@name="AccelerationStructureInstanceDescD3D12.Transform"]/*' />
    [NativeTypeName("float[3][4]")]
    public fixed float Transform[3 * 4];

    public uint _bitfield1;

    /// <include file='AccelerationStructureInstanceDescD3D12.xml' path='doc/member[@name="AccelerationStructureInstanceDescD3D12.InstanceID"]/*' />
    [NativeTypeName("uint32_t : 24")]
    public uint InstanceID
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

    /// <include file='AccelerationStructureInstanceDescD3D12.xml' path='doc/member[@name="AccelerationStructureInstanceDescD3D12.InstanceMask"]/*' />
    [NativeTypeName("uint32_t : 8")]
    public uint InstanceMask
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

    /// <include file='AccelerationStructureInstanceDescD3D12.xml' path='doc/member[@name="AccelerationStructureInstanceDescD3D12.InstanceContributionToHitGroupIndex"]/*' />
    [NativeTypeName("uint32_t : 24")]
    public uint InstanceContributionToHitGroupIndex
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

    /// <include file='AccelerationStructureInstanceDescD3D12.xml' path='doc/member[@name="AccelerationStructureInstanceDescD3D12.Flags"]/*' />
    [NativeTypeName("uint32_t : 8")]
    public uint Flags
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

    /// <include file='AccelerationStructureInstanceDescD3D12.xml' path='doc/member[@name="AccelerationStructureInstanceDescD3D12.AccelerationStructure"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong AccelerationStructure;
}
