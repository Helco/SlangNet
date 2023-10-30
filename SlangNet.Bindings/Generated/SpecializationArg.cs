using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='SpecializationArg.xml' path='doc/member[@name="SpecializationArg"]/*' />
public unsafe partial struct SpecializationArg
{
    /// <include file='SpecializationArg.xml' path='doc/member[@name="SpecializationArg.kind"]/*' />
    [NativeTypeName("slang::SpecializationArg::Kind")]
    public Kind kind;

    /// <include file='SpecializationArg.xml' path='doc/member[@name="SpecializationArg.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_slang_L4685_C9")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.type"]/*' />
    public ref TypeReflection* type
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            fixed (_Anonymous_e__Union* pField = &Anonymous)
            {
                return ref pField->type;
            }
        }
    }

    /// <include file='Kind.xml' path='doc/member[@name="Kind"]/*' />
    [NativeTypeName("int32_t")]
    public enum Kind : uint
    {
        /// <include file='Kind.xml' path='doc/member[@name="Kind.Unknown"]/*' />
        Unknown,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Type"]/*' />
        Type,
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.type"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("slang::TypeReflection *")]
        public TypeReflection* type;
    }
}
