using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='FormatInfo.xml' path='doc/member[@name="FormatInfo"]/*' />
public unsafe partial struct FormatInfo
{
    /// <include file='FormatInfo.xml' path='doc/member[@name="FormatInfo.name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* name;

    /// <include file='FormatInfo.xml' path='doc/member[@name="FormatInfo.channelCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int channelCount;

    /// <include file='FormatInfo.xml' path='doc/member[@name="FormatInfo.channelType"]/*' />
    [NativeTypeName("uint8_t")]
    public byte channelType;

    /// <include file='FormatInfo.xml' path='doc/member[@name="FormatInfo.blockSizeInBytes"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong blockSizeInBytes;

    /// <include file='FormatInfo.xml' path='doc/member[@name="FormatInfo.pixelsPerBlock"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int pixelsPerBlock;

    /// <include file='FormatInfo.xml' path='doc/member[@name="FormatInfo.blockWidth"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int blockWidth;

    /// <include file='FormatInfo.xml' path='doc/member[@name="FormatInfo.blockHeight"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int blockHeight;

    public bool _bitfield;

    /// <include file='FormatInfo.xml' path='doc/member[@name="FormatInfo.isTypeless"]/*' />
    [NativeTypeName("bool : 1")]
    public bool isTypeless
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (bool)(_bitfield & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (bool)((_bitfield & ~0x1) | (value & 0x1));
        }
    }

    /// <include file='FormatInfo.xml' path='doc/member[@name="FormatInfo.isCompressed"]/*' />
    [NativeTypeName("bool : 1")]
    public bool isCompressed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (bool)((_bitfield >> 1) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (bool)((_bitfield & ~(0x1 << 1)) | ((value & 0x1) << 1));
        }
    }
}
