namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles"]/*' />
[NativeTypeName("struct AccelerationStructureBuildInputTriangles : rhi::AccelerationStructureBuildInput")]
public unsafe partial struct AccelerationStructureBuildInputTriangles
{
    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.type"]/*' />
    [NativeTypeName("const AccelerationStructureBuildInputType")]
    public AccelerationStructureBuildInputType type;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.vertexBuffers"]/*' />
    [NativeTypeName("rhi::BufferWithOffset *")]
    public BufferWithOffset* vertexBuffers;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.vertexBufferCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int vertexBufferCount;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.vertexFormat"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format vertexFormat;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.vertexCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int vertexCount;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.vertexStride"]/*' />
    [NativeTypeName("rhi::Size")]
    public ulong vertexStride;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.indexBuffer"]/*' />
    [NativeTypeName("rhi::BufferWithOffset")]
    public BufferWithOffset indexBuffer;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.indexFormat"]/*' />
    [NativeTypeName("rhi::IndexFormat")]
    public IndexFormat indexFormat;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.indexCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int indexCount;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.preTransformBuffer"]/*' />
    [NativeTypeName("rhi::BufferWithOffset")]
    public BufferWithOffset preTransformBuffer;

    /// <include file='AccelerationStructureBuildInputTriangles.xml' path='doc/member[@name="AccelerationStructureBuildInputTriangles.flags"]/*' />
    [NativeTypeName("rhi::AccelerationStructureGeometryFlags")]
    public AccelerationStructureGeometryFlags flags;
}
