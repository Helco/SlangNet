namespace SlangNet.Unsafe;

/// <include file='CompilerOptionEntry.xml' path='doc/member[@name="CompilerOptionEntry"]/*' />
public partial struct CompilerOptionEntry
{
    /// <include file='CompilerOptionEntry.xml' path='doc/member[@name="CompilerOptionEntry.name"]/*' />
    [NativeTypeName("slang::CompilerOptionName")]
    public CompilerOptionName name;

    /// <include file='CompilerOptionEntry.xml' path='doc/member[@name="CompilerOptionEntry.value"]/*' />
    [NativeTypeName("slang::CompilerOptionValue")]
    public CompilerOptionValue value;
}
