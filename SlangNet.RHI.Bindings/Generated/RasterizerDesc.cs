namespace SlangNet.RHI.Unsafe;

/// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc"]/*' />
public partial struct RasterizerDesc
{
    /// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc.fillMode"]/*' />
    [NativeTypeName("rhi::FillMode")]
    public FillMode fillMode;

    /// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc.cullMode"]/*' />
    [NativeTypeName("rhi::CullMode")]
    public CullMode cullMode;

    /// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc.frontFace"]/*' />
    [NativeTypeName("rhi::FrontFaceMode")]
    public FrontFaceMode frontFace;

    /// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc.depthBias"]/*' />
    [NativeTypeName("int32_t")]
    public int depthBias;

    /// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc.depthBiasClamp"]/*' />
    public float depthBiasClamp;

    /// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc.slopeScaledDepthBias"]/*' />
    public float slopeScaledDepthBias;

    /// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc.depthClipEnable"]/*' />
    public bool depthClipEnable;

    /// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc.scissorEnable"]/*' />
    public bool scissorEnable;

    /// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc.multisampleEnable"]/*' />
    public bool multisampleEnable;

    /// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc.antialiasedLineEnable"]/*' />
    public bool antialiasedLineEnable;

    /// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc.enableConservativeRasterization"]/*' />
    public bool enableConservativeRasterization;

    /// <include file='RasterizerDesc.xml' path='doc/member[@name="RasterizerDesc.forcedSampleCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint forcedSampleCount;
}
