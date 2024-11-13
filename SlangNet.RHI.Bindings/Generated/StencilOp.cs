namespace SlangNet.RHI.Unsafe;

/// <include file='StencilOp.xml' path='doc/member[@name="StencilOp"]/*' />
[NativeTypeName("uint8_t")]
public enum StencilOp : byte
{
    /// <include file='StencilOp.xml' path='doc/member[@name="StencilOp.Keep"]/*' />
    Keep,

    /// <include file='StencilOp.xml' path='doc/member[@name="StencilOp.Zero"]/*' />
    Zero,

    /// <include file='StencilOp.xml' path='doc/member[@name="StencilOp.Replace"]/*' />
    Replace,

    /// <include file='StencilOp.xml' path='doc/member[@name="StencilOp.IncrementSaturate"]/*' />
    IncrementSaturate,

    /// <include file='StencilOp.xml' path='doc/member[@name="StencilOp.DecrementSaturate"]/*' />
    DecrementSaturate,

    /// <include file='StencilOp.xml' path='doc/member[@name="StencilOp.Invert"]/*' />
    Invert,

    /// <include file='StencilOp.xml' path='doc/member[@name="StencilOp.IncrementWrap"]/*' />
    IncrementWrap,

    /// <include file='StencilOp.xml' path='doc/member[@name="StencilOp.DecrementWrap"]/*' />
    DecrementWrap,
}
