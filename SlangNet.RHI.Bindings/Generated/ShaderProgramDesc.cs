using SlangNet.Unsafe;

namespace SlangNet.RHI.Unsafe;

/// <include file='ShaderProgramDesc.xml' path='doc/member[@name="ShaderProgramDesc"]/*' />
public unsafe partial struct ShaderProgramDesc
{
    /// <include file='ShaderProgramDesc.xml' path='doc/member[@name="ShaderProgramDesc.type"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType type;

    /// <include file='ShaderProgramDesc.xml' path='doc/member[@name="ShaderProgramDesc.next"]/*' />
    public void* next;

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
    [NativeTypeName("uint32_t")]
    public uint slangEntryPointCount;
}
