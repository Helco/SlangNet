namespace SlangNet.RHI.Unsafe;

/// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport"]/*' />
public enum FormatSupport
{
    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.None"]/*' />
    None = 0x0,

    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.Buffer"]/*' />
    Buffer = 0x1,

    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.IndexBuffer"]/*' />
    IndexBuffer = 0x2,

    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.VertexBuffer"]/*' />
    VertexBuffer = 0x4,

    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.Texture"]/*' />
    Texture = 0x8,

    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.DepthStencil"]/*' />
    DepthStencil = 0x10,

    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.RenderTarget"]/*' />
    RenderTarget = 0x20,

    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.Blendable"]/*' />
    Blendable = 0x40,

    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.ShaderLoad"]/*' />
    ShaderLoad = 0x80,

    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.ShaderSample"]/*' />
    ShaderSample = 0x100,

    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.ShaderUavLoad"]/*' />
    ShaderUavLoad = 0x200,

    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.ShaderUavStore"]/*' />
    ShaderUavStore = 0x400,

    /// <include file='FormatSupport.xml' path='doc/member[@name="FormatSupport.ShaderAtomic"]/*' />
    ShaderAtomic = 0x800,
}
