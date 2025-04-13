using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles"]/*' />
public partial struct AccelerationStructureBuildInputTriangles
{
    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.vertexBuffers"]/*' />
    [NativeTypeName("BufferOffsetPair[2]")]
    public _vertexBuffers_e__FixedBuffer vertexBuffers;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.vertexBufferCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexBufferCount;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.vertexFormat"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format vertexFormat;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.vertexCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexCount;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.vertexStride"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexStride;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.indexBuffer"]/*' />
    [NativeTypeName("rhi::BufferOffsetPair")]
    public BufferOffsetPair indexBuffer;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.indexFormat"]/*' />
    [NativeTypeName("rhi::IndexFormat")]
    public IndexFormat indexFormat;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.indexCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint indexCount;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.preTransformBuffer"]/*' />
    [NativeTypeName("rhi::BufferOffsetPair")]
    public BufferOffsetPair preTransformBuffer;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.flags"]/*' />
    [NativeTypeName("rhi::AccelerationStructureGeometryFlags")]
    public AccelerationStructureGeometryFlags flags;

    /// <include file='_vertexBuffers_e__FixedBuffer.xml' path='doc/member[@name="_vertexBuffers_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _vertexBuffers_e__FixedBuffer
    {
        public BufferOffsetPair e0;
    }
}
