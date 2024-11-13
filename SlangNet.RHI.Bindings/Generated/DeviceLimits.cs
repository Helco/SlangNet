namespace SlangNet.RHI.Unsafe;

/// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits"]/*' />
public unsafe partial struct DeviceLimits
{
    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxTextureDimension1D"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxTextureDimension1D;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxTextureDimension2D"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxTextureDimension2D;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxTextureDimension3D"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxTextureDimension3D;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxTextureDimensionCube"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxTextureDimensionCube;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxTextureArrayLayers"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxTextureArrayLayers;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxVertexInputElements"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxVertexInputElements;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxVertexInputElementOffset"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxVertexInputElementOffset;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxVertexStreams"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxVertexStreams;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxVertexStreamStride"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxVertexStreamStride;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxComputeThreadsPerGroup"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxComputeThreadsPerGroup;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxComputeThreadGroupSize"]/*' />
    [NativeTypeName("uint32_t[3]")]
    public fixed uint maxComputeThreadGroupSize[3];

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxComputeDispatchThreadGroups"]/*' />
    [NativeTypeName("uint32_t[3]")]
    public fixed uint maxComputeDispatchThreadGroups[3];

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxViewports"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxViewports;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxViewportDimensions"]/*' />
    [NativeTypeName("uint32_t[2]")]
    public fixed uint maxViewportDimensions[2];

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxFramebufferDimensions"]/*' />
    [NativeTypeName("uint32_t[3]")]
    public fixed uint maxFramebufferDimensions[3];

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxShaderVisibleSamplers"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxShaderVisibleSamplers;
}
