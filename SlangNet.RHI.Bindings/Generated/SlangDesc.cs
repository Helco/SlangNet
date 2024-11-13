namespace SlangNet.RHI.Unsafe;

/// <include file='SlangDesc.xml' path='doc/member[@name="SlangDesc"]/*' />
public unsafe partial struct SlangDesc
{
    /// <include file='SlangDesc.xml' path='doc/member[@name="SlangDesc.slangGlobalSession"]/*' />
    [NativeTypeName("slang::IGlobalSession *")]
    public IGlobalSession* slangGlobalSession;

    /// <include file='SlangDesc.xml' path='doc/member[@name="SlangDesc.defaultMatrixLayoutMode"]/*' />
    public SlangMatrixLayoutMode defaultMatrixLayoutMode;

    /// <include file='SlangDesc.xml' path='doc/member[@name="SlangDesc.searchPaths"]/*' />
    [NativeTypeName("const char *const *")]
    public sbyte** searchPaths;

    /// <include file='SlangDesc.xml' path='doc/member[@name="SlangDesc.searchPathCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int searchPathCount;

    /// <include file='SlangDesc.xml' path='doc/member[@name="SlangDesc.preprocessorMacros"]/*' />
    [NativeTypeName("const slang::PreprocessorMacroDesc *")]
    public PreprocessorMacroDesc* preprocessorMacros;

    /// <include file='SlangDesc.xml' path='doc/member[@name="SlangDesc.preprocessorMacroCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int preprocessorMacroCount;

    /// <include file='SlangDesc.xml' path='doc/member[@name="SlangDesc.targetProfile"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* targetProfile;

    /// <include file='SlangDesc.xml' path='doc/member[@name="SlangDesc.floatingPointMode"]/*' />
    public SlangFloatingPointMode floatingPointMode;

    /// <include file='SlangDesc.xml' path='doc/member[@name="SlangDesc.optimizationLevel"]/*' />
    public SlangOptimizationLevel optimizationLevel;

    /// <include file='SlangDesc.xml' path='doc/member[@name="SlangDesc.targetFlags"]/*' />
    [NativeTypeName("SlangTargetFlags")]
    public uint targetFlags;

    /// <include file='SlangDesc.xml' path='doc/member[@name="SlangDesc.lineDirectiveMode"]/*' />
    public SlangLineDirectiveMode lineDirectiveMode;
}
