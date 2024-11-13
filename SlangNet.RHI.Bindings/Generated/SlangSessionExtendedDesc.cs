namespace SlangNet.RHI.Unsafe;

/// <include file='SlangSessionExtendedDesc.xml' path='doc/member[@name="SlangSessionExtendedDesc"]/*' />
public unsafe partial struct SlangSessionExtendedDesc
{
    /// <include file='SlangSessionExtendedDesc.xml' path='doc/member[@name="SlangSessionExtendedDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='SlangSessionExtendedDesc.xml' path='doc/member[@name="SlangSessionExtendedDesc.compilerOptionEntryCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint compilerOptionEntryCount;

    /// <include file='SlangSessionExtendedDesc.xml' path='doc/member[@name="SlangSessionExtendedDesc.compilerOptionEntries"]/*' />
    [NativeTypeName("slang::CompilerOptionEntry *")]
    public CompilerOptionEntry* compilerOptionEntries;
}
