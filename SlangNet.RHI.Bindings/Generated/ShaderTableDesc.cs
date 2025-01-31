namespace SlangNet.RHI.Unsafe;

/// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc"]/*' />
public unsafe partial struct ShaderTableDesc
{
    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.structType"]/*' />
    [NativeTypeName("rhi::StructType")]
    public StructType structType;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.next"]/*' />
    public void* next;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.rayGenShaderCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint rayGenShaderCount;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.rayGenShaderEntryPointNames"]/*' />
    [NativeTypeName("const char **")]
    public sbyte** rayGenShaderEntryPointNames;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.rayGenShaderRecordOverwrites"]/*' />
    [NativeTypeName("const ShaderRecordOverwrite *")]
    public ShaderRecordOverwrite* rayGenShaderRecordOverwrites;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.missShaderCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint missShaderCount;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.missShaderEntryPointNames"]/*' />
    [NativeTypeName("const char **")]
    public sbyte** missShaderEntryPointNames;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.missShaderRecordOverwrites"]/*' />
    [NativeTypeName("const ShaderRecordOverwrite *")]
    public ShaderRecordOverwrite* missShaderRecordOverwrites;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.hitGroupCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint hitGroupCount;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.hitGroupNames"]/*' />
    [NativeTypeName("const char **")]
    public sbyte** hitGroupNames;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.hitGroupRecordOverwrites"]/*' />
    [NativeTypeName("const ShaderRecordOverwrite *")]
    public ShaderRecordOverwrite* hitGroupRecordOverwrites;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.callableShaderCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint callableShaderCount;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.callableShaderEntryPointNames"]/*' />
    [NativeTypeName("const char **")]
    public sbyte** callableShaderEntryPointNames;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.callableShaderRecordOverwrites"]/*' />
    [NativeTypeName("const ShaderRecordOverwrite *")]
    public ShaderRecordOverwrite* callableShaderRecordOverwrites;

    /// <include file='ShaderTableDesc.xml' path='doc/member[@name="ShaderTableDesc.program"]/*' />
    [NativeTypeName("rhi::IShaderProgram *")]
    public IShaderProgram* program;
}
