namespace SlangNet.RHI.Unsafe;

/// <include file='TextureUsage.xml' path='doc/member[@name="TextureUsage"]/*' />
public enum TextureUsage
{
    /// <include file='TextureUsage.xml' path='doc/member[@name="TextureUsage.None"]/*' />
    None = 0,

    /// <include file='TextureUsage.xml' path='doc/member[@name="TextureUsage.ShaderResource"]/*' />
    ShaderResource = (1 << 0),

    /// <include file='TextureUsage.xml' path='doc/member[@name="TextureUsage.UnorderedAccess"]/*' />
    UnorderedAccess = (1 << 1),

    /// <include file='TextureUsage.xml' path='doc/member[@name="TextureUsage.RenderTarget"]/*' />
    RenderTarget = (1 << 2),

    /// <include file='TextureUsage.xml' path='doc/member[@name="TextureUsage.DepthRead"]/*' />
    DepthRead = (1 << 3),

    /// <include file='TextureUsage.xml' path='doc/member[@name="TextureUsage.DepthWrite"]/*' />
    DepthWrite = (1 << 4),

    /// <include file='TextureUsage.xml' path='doc/member[@name="TextureUsage.Present"]/*' />
    Present = (1 << 5),

    /// <include file='TextureUsage.xml' path='doc/member[@name="TextureUsage.CopySource"]/*' />
    CopySource = (1 << 6),

    /// <include file='TextureUsage.xml' path='doc/member[@name="TextureUsage.CopyDestination"]/*' />
    CopyDestination = (1 << 7),

    /// <include file='TextureUsage.xml' path='doc/member[@name="TextureUsage.ResolveSource"]/*' />
    ResolveSource = (1 << 8),

    /// <include file='TextureUsage.xml' path='doc/member[@name="TextureUsage.ResolveDestination"]/*' />
    ResolveDestination = (1 << 9),
}
