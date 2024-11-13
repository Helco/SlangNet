namespace SlangNet.RHI.Unsafe;

/// <include file='BindingType.xml' path='doc/member[@name="BindingType"]/*' />
public enum BindingType
{
    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.Unknown"]/*' />
    Unknown,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.Buffer"]/*' />
    Buffer,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.BufferWithCounter"]/*' />
    BufferWithCounter,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.Texture"]/*' />
    Texture,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.TextureView"]/*' />
    TextureView,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.Sampler"]/*' />
    Sampler,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.CombinedTextureSampler"]/*' />
    CombinedTextureSampler,

    /// <include file='BindingType.xml' path='doc/member[@name="BindingType.AccelerationStructure"]/*' />
    AccelerationStructure,
}
