using System;

namespace SlangNet.Unsafe;

/// <include file='TargetDesc.xml' path='doc/member[@name="TargetDesc"]/*' />
public partial struct TargetDesc
{
    /// <include file='TargetDesc.xml' path='doc/member[@name="TargetDesc.structureSize"]/*' />
    [NativeTypeName("size_t")]
    public UIntPtr structureSize;

    /// <include file='TargetDesc.xml' path='doc/member[@name="TargetDesc.format"]/*' />
    public SlangCompileTarget format;

    /// <include file='TargetDesc.xml' path='doc/member[@name="TargetDesc.profile"]/*' />
    public SlangProfileID profile;

    /// <include file='TargetDesc.xml' path='doc/member[@name="TargetDesc.flags"]/*' />
    [NativeTypeName("SlangTargetFlags")]
    public uint flags;

    /// <include file='TargetDesc.xml' path='doc/member[@name="TargetDesc.floatingPointMode"]/*' />
    public SlangFloatingPointMode floatingPointMode;

    /// <include file='TargetDesc.xml' path='doc/member[@name="TargetDesc.lineDirectiveMode"]/*' />
    public SlangLineDirectiveMode lineDirectiveMode;

    /// <include file='TargetDesc.xml' path='doc/member[@name="TargetDesc.forceGLSLScalarBufferLayout"]/*' />
    [NativeTypeName("bool")]
    public byte forceGLSLScalarBufferLayout;
}
