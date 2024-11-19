using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='AdapterLUID.xml' path='doc/member[@name="AdapterLUID"]/*' />
public partial struct AdapterLUID
{
    /// <include file='AdapterLUID.xml' path='doc/member[@name="AdapterLUID.luid"]/*' />
    [NativeTypeName("uint8_t[16]")]
    public _luid_e__FixedBuffer luid;

    /// <include file='_luid_e__FixedBuffer.xml' path='doc/member[@name="_luid_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _luid_e__FixedBuffer
    {
        public byte e0;
    }
}
