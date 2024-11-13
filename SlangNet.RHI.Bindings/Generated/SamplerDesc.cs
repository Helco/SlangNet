namespace SlangNet.RHI.Unsafe;

/// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc"]/*' />
public unsafe partial struct SamplerDesc
{
    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.minFilter"]/*' />
    [NativeTypeName("rhi::TextureFilteringMode")]
    public TextureFilteringMode minFilter;

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.magFilter"]/*' />
    [NativeTypeName("rhi::TextureFilteringMode")]
    public TextureFilteringMode magFilter;

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.mipFilter"]/*' />
    [NativeTypeName("rhi::TextureFilteringMode")]
    public TextureFilteringMode mipFilter;

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.reductionOp"]/*' />
    [NativeTypeName("rhi::TextureReductionOp")]
    public TextureReductionOp reductionOp;

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.addressU"]/*' />
    [NativeTypeName("rhi::TextureAddressingMode")]
    public TextureAddressingMode addressU;

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.addressV"]/*' />
    [NativeTypeName("rhi::TextureAddressingMode")]
    public TextureAddressingMode addressV;

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.addressW"]/*' />
    [NativeTypeName("rhi::TextureAddressingMode")]
    public TextureAddressingMode addressW;

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.mipLODBias"]/*' />
    public float mipLODBias;

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.maxAnisotropy"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxAnisotropy;

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.comparisonFunc"]/*' />
    [NativeTypeName("rhi::ComparisonFunc")]
    public ComparisonFunc comparisonFunc;

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.borderColor"]/*' />
    [NativeTypeName("float[4]")]
    public fixed float borderColor[4];

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.minLOD"]/*' />
    public float minLOD;

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.maxLOD"]/*' />
    public float maxLOD;

    /// <include file='SamplerDesc.xml' path='doc/member[@name="SamplerDesc.label"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* label;
}
