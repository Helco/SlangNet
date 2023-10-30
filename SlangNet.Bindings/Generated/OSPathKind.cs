using SlangNet.Unsafe;

namespace SlangNet;

/// <include file='OSPathKind.xml' path='doc/member[@name="OSPathKind"]/*' />
[NativeTypeName("uint8_t")]
public enum OSPathKind : byte
{
    /// <include file='OSPathKind.xml' path='doc/member[@name="OSPathKind.None"]/*' />
    None,

    /// <include file='OSPathKind.xml' path='doc/member[@name="OSPathKind.Direct"]/*' />
    Direct,

    /// <include file='OSPathKind.xml' path='doc/member[@name="OSPathKind.OperatingSystem"]/*' />
    OperatingSystem,
}
