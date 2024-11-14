namespace SlangNet.Unsafe;

/// <include file='CompilerOptionValue.xml' path='doc/member[@name="CompilerOptionValue"]/*' />
public unsafe partial struct CompilerOptionValue
{
    /// <include file='CompilerOptionValue.xml' path='doc/member[@name="CompilerOptionValue.kind"]/*' />
    [NativeTypeName("slang::CompilerOptionValueKind")]
    public CompilerOptionValueKind kind;

    /// <include file='CompilerOptionValue.xml' path='doc/member[@name="CompilerOptionValue.intValue0"]/*' />
    [NativeTypeName("int32_t")]
    public int intValue0;

    /// <include file='CompilerOptionValue.xml' path='doc/member[@name="CompilerOptionValue.intValue1"]/*' />
    [NativeTypeName("int32_t")]
    public int intValue1;

    /// <include file='CompilerOptionValue.xml' path='doc/member[@name="CompilerOptionValue.stringValue0"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* stringValue0;

    /// <include file='CompilerOptionValue.xml' path='doc/member[@name="CompilerOptionValue.stringValue1"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* stringValue1;
}
