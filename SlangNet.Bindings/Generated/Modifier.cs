using static SlangNet.Unsafe.SlangModifierID;

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

        /// <include file='ID.xml' path='doc/member[@name="ID.NoDiff"]/*' />
        NoDiff = SLANG_MODIFIER_NO_DIFF,

        /// <include file='ID.xml' path='doc/member[@name="ID.Static"]/*' />
        Static = SLANG_MODIFIER_STATIC,

        /// <include file='ID.xml' path='doc/member[@name="ID.Const"]/*' />
        Const = SLANG_MODIFIER_CONST,

        /// <include file='ID.xml' path='doc/member[@name="ID.Export"]/*' />
        Export = SLANG_MODIFIER_EXPORT,

        /// <include file='ID.xml' path='doc/member[@name="ID.Extern"]/*' />
        Extern = SLANG_MODIFIER_EXTERN,

        /// <include file='ID.xml' path='doc/member[@name="ID.Differentiable"]/*' />
        Differentiable = SLANG_MODIFIER_DIFFERENTIABLE,

        /// <include file='ID.xml' path='doc/member[@name="ID.Mutating"]/*' />
        Mutating = SLANG_MODIFIER_MUTATING,

        /// <include file='ID.xml' path='doc/member[@name="ID.In"]/*' />
        In = SLANG_MODIFIER_IN,

        /// <include file='ID.xml' path='doc/member[@name="ID.Out"]/*' />
        Out = SLANG_MODIFIER_OUT,

        /// <include file='ID.xml' path='doc/member[@name="ID.InOut"]/*' />
        InOut = SLANG_MODIFIER_INOUT,
    }
}
