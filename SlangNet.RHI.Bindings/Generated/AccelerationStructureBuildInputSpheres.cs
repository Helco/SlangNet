using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres"]/*' />
public partial struct AccelerationStructureBuildInputSpheres
{
    /// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres.vertexBufferCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexBufferCount;

    /// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres.vertexCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexCount;

    /// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres.vertexPositionBuffers"]/*' />
    [NativeTypeName("BufferOffsetPair[2]")]
    public _vertexPositionBuffers_e__FixedBuffer vertexPositionBuffers;

    /// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres.vertexPositionFormat"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format vertexPositionFormat;

    /// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres.vertexPositionStride"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexPositionStride;

    /// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres.vertexRadiusBuffers"]/*' />
    [NativeTypeName("BufferOffsetPair[2]")]
    public _vertexRadiusBuffers_e__FixedBuffer vertexRadiusBuffers;

    /// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres.vertexRadiusFormat"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format vertexRadiusFormat;

    /// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres.vertexRadiusStride"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexRadiusStride;

    /// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres.indexBuffer"]/*' />
    [NativeTypeName("rhi::BufferOffsetPair")]
    public BufferOffsetPair indexBuffer;

    /// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres.indexFormat"]/*' />
    [NativeTypeName("rhi::IndexFormat")]
    public IndexFormat indexFormat;

    /// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres.indexCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint indexCount;

    /// <include file='AccelerationStructureBuildInputSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputSpheres.flags"]/*' />
    [NativeTypeName("rhi::AccelerationStructureGeometryFlags")]
    public AccelerationStructureGeometryFlags flags;

    /// <include file='_vertexPositionBuffers_e__FixedBuffer.xml' path='doc/member[@name="_vertexPositionBuffers_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _vertexPositionBuffers_e__FixedBuffer
    {
        public BufferOffsetPair e0;
    }

    /// <include file='_vertexRadiusBuffers_e__FixedBuffer.xml' path='doc/member[@name="_vertexRadiusBuffers_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _vertexRadiusBuffers_e__FixedBuffer
    {
        public BufferOffsetPair e0;
    }
}
