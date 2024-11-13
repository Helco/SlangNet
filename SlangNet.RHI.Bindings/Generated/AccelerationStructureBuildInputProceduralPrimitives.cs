using System;

namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives"]/*' />
[NativeTypeName("struct AccelerationStructureBuildInputProceduralPrimitives : rhi::AccelerationStructureBuildInput")]
public unsafe partial struct AccelerationStructureBuildInputProceduralPrimitives
{
    /// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives.type"]/*' />
    [NativeTypeName("const AccelerationStructureBuildInputType")]
    public AccelerationStructureBuildInputType type;

    /// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives.aabbBuffers"]/*' />
    [NativeTypeName("rhi::BufferWithOffset *")]
    public BufferWithOffset* aabbBuffers;

    /// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives.aabbBufferCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int aabbBufferCount;

    /// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives.aabbStride"]/*' />
    [NativeTypeName("rhi::Size")]
    public UIntPtr aabbStride;

    /// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives.primitiveCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int primitiveCount;

    /// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives.flags"]/*' />
    [NativeTypeName("rhi::AccelerationStructureGeometryFlags")]
    public AccelerationStructureGeometryFlags flags;
}
