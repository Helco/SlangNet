namespace SlangNet.Unsafe;

/// <include file='CompileStdLibFlag.xml' path='doc/member[@name="CompileStdLibFlag"]/*' />
public partial struct CompileStdLibFlag
{

    /// <include file='Enum.xml' path='doc/member[@name="Enum"]/*' />
    [NativeTypeName("slang::CompileStdLibFlags")]
    public enum Enum : uint
    {
        /// <include file='Enum.xml' path='doc/member[@name="Enum.WriteDocumentation"]/*' />
        WriteDocumentation = 0x1,
    }
}
