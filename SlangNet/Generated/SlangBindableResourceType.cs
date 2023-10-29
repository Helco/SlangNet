namespace SlangNet;

/// <include file='SlangBindableResourceType.xml' path='doc/member[@name="SlangBindableResourceType"]/*' />
[NativeTypeName("SlangBindableResourceIntegral")]
public enum SlangBindableResourceType
{
    /// <include file='SlangBindableResourceType.xml' path='doc/member[@name="SlangBindableResourceType.SLANG_NON_BINDABLE"]/*' />
    SLANG_NON_BINDABLE = 0,

    /// <include file='SlangBindableResourceType.xml' path='doc/member[@name="SlangBindableResourceType.SLANG_TEXTURE"]/*' />
    SLANG_TEXTURE,

    /// <include file='SlangBindableResourceType.xml' path='doc/member[@name="SlangBindableResourceType.SLANG_SAMPLER"]/*' />
    SLANG_SAMPLER,

    /// <include file='SlangBindableResourceType.xml' path='doc/member[@name="SlangBindableResourceType.SLANG_UNIFORM_BUFFER"]/*' />
    SLANG_UNIFORM_BUFFER,

    /// <include file='SlangBindableResourceType.xml' path='doc/member[@name="SlangBindableResourceType.SLANG_STORAGE_BUFFER"]/*' />
    SLANG_STORAGE_BUFFER,
}
