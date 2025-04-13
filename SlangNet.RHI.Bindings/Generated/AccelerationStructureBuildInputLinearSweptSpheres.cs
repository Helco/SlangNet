using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres"]/*' />
public partial struct AccelerationStructureBuildInputLinearSweptSpheres
{
    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.vertexBufferCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexBufferCount;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.vertexCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexCount;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.primitiveCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint primitiveCount;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.vertexPositionBuffers"]/*' />
    [NativeTypeName("BufferOffsetPair[2]")]
    public _vertexPositionBuffers_e__FixedBuffer vertexPositionBuffers;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.vertexPositionFormat"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format vertexPositionFormat;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.vertexPositionStride"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexPositionStride;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.vertexRadiusBuffers"]/*' />
    [NativeTypeName("BufferOffsetPair[2]")]
    public _vertexRadiusBuffers_e__FixedBuffer vertexRadiusBuffers;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.vertexRadiusFormat"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format vertexRadiusFormat;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.vertexRadiusStride"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexRadiusStride;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.indexBuffer"]/*' />
    [NativeTypeName("rhi::BufferOffsetPair")]
    public BufferOffsetPair indexBuffer;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.indexFormat"]/*' />
    [NativeTypeName("rhi::IndexFormat")]
    public IndexFormat indexFormat;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.indexCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint indexCount;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.indexingMode"]/*' />
    [NativeTypeName("rhi::LinearSweptSpheresIndexingMode")]
    public LinearSweptSpheresIndexingMode indexingMode;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.endCapsMode"]/*' />
    [NativeTypeName("rhi::LinearSweptSpheresEndCapsMode")]
    public LinearSweptSpheresEndCapsMode endCapsMode;

    /// <include file='AccelerationStructureBuildInputLinearSweptSpheres.xml' path='doc/member[@name="AccelerationStructureBuildInputLinearSweptSpheres.flags"]/*' />
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
