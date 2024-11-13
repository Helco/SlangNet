namespace SlangNet.RHI.Unsafe;

/// <include file='HitGroupDesc.xml' path='doc/member[@name="HitGroupDesc"]/*' />
public unsafe partial struct HitGroupDesc
{
    /// <include file='HitGroupDesc.xml' path='doc/member[@name="HitGroupDesc.hitGroupName"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* hitGroupName;

    /// <include file='HitGroupDesc.xml' path='doc/member[@name="HitGroupDesc.closestHitEntryPoint"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* closestHitEntryPoint;

    /// <include file='HitGroupDesc.xml' path='doc/member[@name="HitGroupDesc.anyHitEntryPoint"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* anyHitEntryPoint;

    /// <include file='HitGroupDesc.xml' path='doc/member[@name="HitGroupDesc.intersectionEntryPoint"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* intersectionEntryPoint;
}
