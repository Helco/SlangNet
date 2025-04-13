namespace SlangNet.RHI.Unsafe;

/// <include file='ShaderOffset.xml' path='doc/member[@name="ShaderOffset"]/*' />
public partial struct ShaderOffset
{
    /// <include file='ShaderOffset.xml' path='doc/member[@name="ShaderOffset.uniformOffset"]/*' />
    [NativeTypeName("uint32_t")]
    public uint uniformOffset;

    /// <include file='ShaderOffset.xml' path='doc/member[@name="ShaderOffset.bindingRangeIndex"]/*' />
    [NativeTypeName("uint32_t")]
    public uint bindingRangeIndex;

    /// <include file='ShaderOffset.xml' path='doc/member[@name="ShaderOffset.bindingArrayIndex"]/*' />
    [NativeTypeName("uint32_t")]
    public uint bindingArrayIndex;
}
