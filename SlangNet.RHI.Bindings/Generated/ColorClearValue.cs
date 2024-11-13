using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='ColorClearValue.xml' path='doc/member[@name="ColorClearValue"]/*' />
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct ColorClearValue
{
    /// <include file='ColorClearValue.xml' path='doc/member[@name="ColorClearValue.floatValues"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("float[4]")]
    public fixed float floatValues[4];

    /// <include file='ColorClearValue.xml' path='doc/member[@name="ColorClearValue.uintValues"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("uint32_t[4]")]
    public fixed uint uintValues[4];

    /// <include file='ColorClearValue.xml' path='doc/member[@name="ColorClearValue.intValues"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("int32_t[4]")]
    public fixed int intValues[4];
}
