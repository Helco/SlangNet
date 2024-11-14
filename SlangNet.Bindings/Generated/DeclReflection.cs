using static SlangNet.Unsafe.SlangDeclKind;

namespace SlangNet.Unsafe;

/// <include file='DeclReflection.xml' path='doc/member[@name="DeclReflection"]/*' />
public partial struct DeclReflection
{

    /// <include file='Kind.xml' path='doc/member[@name="Kind"]/*' />
    [NativeTypeName("int")]
    public enum Kind : uint
    {
        /// <include file='Kind.xml' path='doc/member[@name="Kind.Unsupported"]/*' />
        Unsupported = SLANG_DECL_KIND_UNSUPPORTED_FOR_REFLECTION,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Struct"]/*' />
        Struct = SLANG_DECL_KIND_STRUCT,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Func"]/*' />
        Func = SLANG_DECL_KIND_FUNC,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Module"]/*' />
        Module = SLANG_DECL_KIND_MODULE,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Generic"]/*' />
        Generic = SLANG_DECL_KIND_GENERIC,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Variable"]/*' />
        Variable = SLANG_DECL_KIND_VARIABLE,

        /// <include file='Kind.xml' path='doc/member[@name="Kind.Namespace"]/*' />
        Namespace = SLANG_DECL_KIND_NAMESPACE,
    }

    /// <include file='IteratedList.xml' path='doc/member[@name="IteratedList"]/*' />
    public unsafe partial struct IteratedList
    {
        /// <include file='IteratedList.xml' path='doc/member[@name="IteratedList.count"]/*' />
        [NativeTypeName("unsigned int")]
        public uint count;

        /// <include file='IteratedList.xml' path='doc/member[@name="IteratedList.parent"]/*' />
        [NativeTypeName("slang::DeclReflection *")]
        public DeclReflection* parent;

        /// <include file='Iterator.xml' path='doc/member[@name="Iterator"]/*' />
        public unsafe partial struct Iterator
        {
            /// <include file='Iterator.xml' path='doc/member[@name="Iterator.parent"]/*' />
            [NativeTypeName("slang::DeclReflection *")]
            public DeclReflection* parent;

            /// <include file='Iterator.xml' path='doc/member[@name="Iterator.count"]/*' />
            [NativeTypeName("unsigned int")]
            public uint count;

            /// <include file='Iterator.xml' path='doc/member[@name="Iterator.index"]/*' />
            [NativeTypeName("unsigned int")]
            public uint index;
        }
    }
}
