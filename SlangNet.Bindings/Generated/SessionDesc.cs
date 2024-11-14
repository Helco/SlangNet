using System;

namespace SlangNet.Unsafe;

/// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc"]/*' />
public unsafe partial struct SessionDesc
{
    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.structureSize"]/*' />
    [NativeTypeName("size_t")]
    public UIntPtr structureSize;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.targets"]/*' />
    [NativeTypeName("const TargetDesc *")]
    public TargetDesc* targets;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.targetCount"]/*' />
    [NativeTypeName("SlangInt")]
    public long targetCount;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.flags"]/*' />
    [NativeTypeName("slang::SessionFlags")]
    public uint flags;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.defaultMatrixLayoutMode"]/*' />
    public SlangMatrixLayoutMode defaultMatrixLayoutMode;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.searchPaths"]/*' />
    [NativeTypeName("const char *const *")]
    public sbyte** searchPaths;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.searchPathCount"]/*' />
    [NativeTypeName("SlangInt")]
    public long searchPathCount;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.preprocessorMacros"]/*' />
    [NativeTypeName("const PreprocessorMacroDesc *")]
    public PreprocessorMacroDesc* preprocessorMacros;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.preprocessorMacroCount"]/*' />
    [NativeTypeName("SlangInt")]
    public long preprocessorMacroCount;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.fileSystem"]/*' />
    public ISlangFileSystem* fileSystem;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.enableEffectAnnotations"]/*' />
    [NativeTypeName("bool")]
    public byte enableEffectAnnotations;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.allowGLSLSyntax"]/*' />
    [NativeTypeName("bool")]
    public byte allowGLSLSyntax;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.compilerOptionEntries"]/*' />
    [NativeTypeName("slang::CompilerOptionEntry *")]
    public CompilerOptionEntry* compilerOptionEntries;

    /// <include file='SessionDesc.xml' path='doc/member[@name="SessionDesc.compilerOptionEntryCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint compilerOptionEntryCount;
}
