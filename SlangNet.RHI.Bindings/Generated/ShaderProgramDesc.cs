namespace SlangNet.RHI.Unsafe;

/// <include file='ShaderProgramDesc.xml' path='doc/member[@name="ShaderProgramDesc"]/*' />
public unsafe partial struct ShaderProgramDesc
{
    /// <include file='ShaderProgramDesc.xml' path='doc/member[@name="ShaderProgramDesc.linkingStyle"]/*' />
    [NativeTypeName("rhi::LinkingStyle")]
    public LinkingStyle linkingStyle;

    /// <include file='ShaderProgramDesc.xml' path='doc/member[@name="ShaderProgramDesc.slangGlobalScope"]/*' />
    [NativeTypeName("slang::IComponentType *")]
    public IComponentType* slangGlobalScope;

    /// <include file='ShaderProgramDesc.xml' path='doc/member[@name="ShaderProgramDesc.slangEntryPoints"]/*' />
    [NativeTypeName("slang::IComponentType **")]
    public IComponentType** slangEntryPoints;

    /// <include file='ShaderProgramDesc.xml' path='doc/member[@name="ShaderProgramDesc.slangEntryPointCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int slangEntryPointCount;
}
