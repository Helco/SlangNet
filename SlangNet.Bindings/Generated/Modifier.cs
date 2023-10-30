using static SlangNet.SlangModifierID;

namespace SlangNet.Unsafe;

/// <include file='Modifier.xml' path='doc/member[@name="Modifier"]/*' />
public partial struct Modifier
{

    /// <include file='ID.xml' path='doc/member[@name="ID"]/*' />
    [NativeTypeName("SlangModifierIDIntegral")]
    public enum ID : uint
    {
        /// <include file='ID.xml' path='doc/member[@name="ID.Shared"]/*' />
        Shared = SLANG_MODIFIER_SHARED,
    }
}
