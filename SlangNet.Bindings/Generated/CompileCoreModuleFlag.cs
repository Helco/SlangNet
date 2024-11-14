namespace SlangNet.Unsafe;

/// <include file='CompileCoreModuleFlag.xml' path='doc/member[@name="CompileCoreModuleFlag"]/*' />
public partial struct CompileCoreModuleFlag
{

    /// <include file='Enum.xml' path='doc/member[@name="Enum"]/*' />
    [NativeTypeName("slang::CompileCoreModuleFlags")]
    public enum Enum : uint
    {
        /// <include file='Enum.xml' path='doc/member[@name="Enum.WriteDocumentation"]/*' />
        WriteDocumentation = 0x1,
    }
}
