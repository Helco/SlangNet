using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='AdapterInfo.xml' path='doc/member[@name="AdapterInfo"]/*' />
public partial struct AdapterInfo
{
    /// <include file='AdapterInfo.xml' path='doc/member[@name="AdapterInfo.name"]/*' />
    [NativeTypeName("char[128]")]
    public _name_e__FixedBuffer name;

    /// <include file='AdapterInfo.xml' path='doc/member[@name="AdapterInfo.vendorID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vendorID;

    /// <include file='AdapterInfo.xml' path='doc/member[@name="AdapterInfo.deviceID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint deviceID;

    /// <include file='AdapterInfo.xml' path='doc/member[@name="AdapterInfo.luid"]/*' />
    [NativeTypeName("rhi::AdapterLUID")]
    public AdapterLUID luid;

    /// <include file='_name_e__FixedBuffer.xml' path='doc/member[@name="_name_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _name_e__FixedBuffer
    {
        public sbyte e0;
    }
}
