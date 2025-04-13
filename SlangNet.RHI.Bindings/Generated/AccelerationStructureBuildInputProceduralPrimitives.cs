using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives"]/*' />
public partial struct AccelerationStructureBuildInputProceduralPrimitives
{
    /// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives.aabbBuffers"]/*' />
    [NativeTypeName("BufferOffsetPair[2]")]
    public _aabbBuffers_e__FixedBuffer aabbBuffers;

    /// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives.aabbBufferCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint aabbBufferCount;

    /// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives.aabbStride"]/*' />
    [NativeTypeName("uint32_t")]
    public uint aabbStride;

    /// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives.primitiveCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint primitiveCount;

    /// <include file='AccelerationStructureBuildInputProceduralPrimitives.xml' path='doc/member[@name="AccelerationStructureBuildInputProceduralPrimitives.flags"]/*' />
    [NativeTypeName("rhi::AccelerationStructureGeometryFlags")]
    public AccelerationStructureGeometryFlags flags;

    /// <include file='_aabbBuffers_e__FixedBuffer.xml' path='doc/member[@name="_aabbBuffers_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _aabbBuffers_e__FixedBuffer
    {
        public BufferOffsetPair e0;
    }
}
