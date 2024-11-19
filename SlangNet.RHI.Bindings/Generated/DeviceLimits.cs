using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits"]/*' />
public partial struct DeviceLimits
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
    public _maxComputeThreadGroupSize_e__FixedBuffer maxComputeThreadGroupSize;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxComputeDispatchThreadGroups"]/*' />
    [NativeTypeName("uint32_t[3]")]
    public _maxComputeDispatchThreadGroups_e__FixedBuffer maxComputeDispatchThreadGroups;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxViewports"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxViewports;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxViewportDimensions"]/*' />
    [NativeTypeName("uint32_t[2]")]
    public _maxViewportDimensions_e__FixedBuffer maxViewportDimensions;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxFramebufferDimensions"]/*' />
    [NativeTypeName("uint32_t[3]")]
    public _maxFramebufferDimensions_e__FixedBuffer maxFramebufferDimensions;

    /// <include file='DeviceLimits.xml' path='doc/member[@name="DeviceLimits.maxShaderVisibleSamplers"]/*' />
    [NativeTypeName("uint32_t")]
    public uint maxShaderVisibleSamplers;

    /// <include file='_maxComputeThreadGroupSize_e__FixedBuffer.xml' path='doc/member[@name="_maxComputeThreadGroupSize_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _maxComputeThreadGroupSize_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_maxComputeDispatchThreadGroups_e__FixedBuffer.xml' path='doc/member[@name="_maxComputeDispatchThreadGroups_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _maxComputeDispatchThreadGroups_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_maxViewportDimensions_e__FixedBuffer.xml' path='doc/member[@name="_maxViewportDimensions_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _maxViewportDimensions_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_maxFramebufferDimensions_e__FixedBuffer.xml' path='doc/member[@name="_maxFramebufferDimensions_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _maxFramebufferDimensions_e__FixedBuffer
    {
        public uint e0;
    }
}
