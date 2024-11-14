namespace SlangNet.Unsafe;

/// <include file='SlangDeclKind.xml' path='doc/member[@name="SlangDeclKind"]/*' />
[NativeTypeName("SlangDeclKindIntegral")]
public enum SlangDeclKind : uint
{
    /// <include file='SlangDeclKind.xml' path='doc/member[@name="SlangDeclKind.SLANG_DECL_KIND_UNSUPPORTED_FOR_REFLECTION"]/*' />
    SLANG_DECL_KIND_UNSUPPORTED_FOR_REFLECTION,

    /// <include file='SlangDeclKind.xml' path='doc/member[@name="SlangDeclKind.SLANG_DECL_KIND_STRUCT"]/*' />
    SLANG_DECL_KIND_STRUCT,

    /// <include file='SlangDeclKind.xml' path='doc/member[@name="SlangDeclKind.SLANG_DECL_KIND_FUNC"]/*' />
    SLANG_DECL_KIND_FUNC,

    /// <include file='SlangDeclKind.xml' path='doc/member[@name="SlangDeclKind.SLANG_DECL_KIND_MODULE"]/*' />
    SLANG_DECL_KIND_MODULE,

    /// <include file='SlangDeclKind.xml' path='doc/member[@name="SlangDeclKind.SLANG_DECL_KIND_GENERIC"]/*' />
    SLANG_DECL_KIND_GENERIC,

    /// <include file='SlangDeclKind.xml' path='doc/member[@name="SlangDeclKind.SLANG_DECL_KIND_VARIABLE"]/*' />
    SLANG_DECL_KIND_VARIABLE,

    /// <include file='SlangDeclKind.xml' path='doc/member[@name="SlangDeclKind.SLANG_DECL_KIND_NAMESPACE"]/*' />
    SLANG_DECL_KIND_NAMESPACE,
}
