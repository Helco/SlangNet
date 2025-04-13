namespace SlangNet.RHI.Unsafe;

/// <include file='CooperativeVectorProperties.xml' path='doc/member[@name="CooperativeVectorProperties"]/*' />
public partial struct CooperativeVectorProperties
{
    /// <include file='CooperativeVectorProperties.xml' path='doc/member[@name="CooperativeVectorProperties.inputType"]/*' />
    [NativeTypeName("rhi::CooperativeVectorComponentType")]
    public CooperativeVectorComponentType inputType;

    /// <include file='CooperativeVectorProperties.xml' path='doc/member[@name="CooperativeVectorProperties.inputInterpretation"]/*' />
    [NativeTypeName("rhi::CooperativeVectorComponentType")]
    public CooperativeVectorComponentType inputInterpretation;

    /// <include file='CooperativeVectorProperties.xml' path='doc/member[@name="CooperativeVectorProperties.matrixInterpretation"]/*' />
    [NativeTypeName("rhi::CooperativeVectorComponentType")]
    public CooperativeVectorComponentType matrixInterpretation;

    /// <include file='CooperativeVectorProperties.xml' path='doc/member[@name="CooperativeVectorProperties.biasInterpretation"]/*' />
    [NativeTypeName("rhi::CooperativeVectorComponentType")]
    public CooperativeVectorComponentType biasInterpretation;

    /// <include file='CooperativeVectorProperties.xml' path='doc/member[@name="CooperativeVectorProperties.resultType"]/*' />
    [NativeTypeName("rhi::CooperativeVectorComponentType")]
    public CooperativeVectorComponentType resultType;

    /// <include file='CooperativeVectorProperties.xml' path='doc/member[@name="CooperativeVectorProperties.transpose"]/*' />
    public bool transpose;
}
