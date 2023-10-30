namespace SlangNet.Unsafe;

/// <include file='PreprocessorMacroDesc.xml' path='doc/member[@name="PreprocessorMacroDesc"]/*' />
public unsafe partial struct PreprocessorMacroDesc
{
    /// <include file='PreprocessorMacroDesc.xml' path='doc/member[@name="PreprocessorMacroDesc.name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* name;

    /// <include file='PreprocessorMacroDesc.xml' path='doc/member[@name="PreprocessorMacroDesc.value"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* value;
}
