namespace SlangNet.RHI.Unsafe;

/// <include file='ShaderOffset.xml' path='doc/member[@name="ShaderOffset"]/*' />
public partial struct ShaderOffset
{
    /// <include file='ShaderOffset.xml' path='doc/member[@name="ShaderOffset.uniformOffset"]/*' />
    [NativeTypeName("SlangInt")]
    public long uniformOffset;

    /// <include file='ShaderOffset.xml' path='doc/member[@name="ShaderOffset.bindingRangeIndex"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int bindingRangeIndex;

    /// <include file='ShaderOffset.xml' path='doc/member[@name="ShaderOffset.bindingArrayIndex"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int bindingArrayIndex;
}
