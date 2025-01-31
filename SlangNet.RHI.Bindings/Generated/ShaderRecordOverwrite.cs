using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='ShaderRecordOverwrite.xml' path='doc/member[@name="ShaderRecordOverwrite"]/*' />
public partial struct ShaderRecordOverwrite
{
    /// <include file='ShaderRecordOverwrite.xml' path='doc/member[@name="ShaderRecordOverwrite.offset"]/*' />
    [NativeTypeName("uint8_t")]
    public byte offset;

    /// <include file='ShaderRecordOverwrite.xml' path='doc/member[@name="ShaderRecordOverwrite.size"]/*' />
    [NativeTypeName("uint8_t")]
    public byte size;

    /// <include file='ShaderRecordOverwrite.xml' path='doc/member[@name="ShaderRecordOverwrite.data"]/*' />
    [NativeTypeName("uint8_t[8]")]
    public _data_e__FixedBuffer data;

    /// <include file='_data_e__FixedBuffer.xml' path='doc/member[@name="_data_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _data_e__FixedBuffer
    {
        public byte e0;
    }
}
