namespace SlangNet.RHI.Unsafe;

/// <include file='TextureAspect.xml' path='doc/member[@name="TextureAspect"]/*' />
[NativeTypeName("uint32_t")]
public enum TextureAspect : uint
{
    /// <include file='TextureAspect.xml' path='doc/member[@name="TextureAspect.All"]/*' />
    All = 0,

    /// <include file='TextureAspect.xml' path='doc/member[@name="TextureAspect.DepthOnly"]/*' />
    DepthOnly = 1,

    /// <include file='TextureAspect.xml' path='doc/member[@name="TextureAspect.StencilOnly"]/*' />
    StencilOnly = 2,
}
