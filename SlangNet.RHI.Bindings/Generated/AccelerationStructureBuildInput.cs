using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureBuildInput.xml' path='doc/member[@name="AccelerationStructureBuildInput"]/*' />
public partial struct AccelerationStructureBuildInput
{
    /// <include file='AccelerationStructureBuildInput.xml' path='doc/member[@name="AccelerationStructureBuildInput.type"]/*' />
    [NativeTypeName("rhi::AccelerationStructureBuildInputType")]
    public AccelerationStructureBuildInputType type;

    /// <include file='AccelerationStructureBuildInput.xml' path='doc/member[@name="AccelerationStructureBuildInput.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_slang-rhi_L1183_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.instances"]/*' />
    [UnscopedRef]
    public ref AccelerationStructureBuildInputInstances instances
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.instances;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.triangles"]/*' />
    [UnscopedRef]
    public ref AccelerationStructureBuildInputTriangles triangles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.triangles;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.proceduralPrimitives"]/*' />
    [UnscopedRef]
    public ref AccelerationStructureBuildInputProceduralPrimitives proceduralPrimitives
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.proceduralPrimitives;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.spheres"]/*' />
    [UnscopedRef]
    public ref AccelerationStructureBuildInputSpheres spheres
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.spheres;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.linearSweptSpheres"]/*' />
    [UnscopedRef]
    public ref AccelerationStructureBuildInputLinearSweptSpheres linearSweptSpheres
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.linearSweptSpheres;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.instances"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("rhi::AccelerationStructureBuildInputInstances")]
        public AccelerationStructureBuildInputInstances instances;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.triangles"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("rhi::AccelerationStructureBuildInputTriangles")]
        public AccelerationStructureBuildInputTriangles triangles;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.proceduralPrimitives"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("rhi::AccelerationStructureBuildInputProceduralPrimitives")]
        public AccelerationStructureBuildInputProceduralPrimitives proceduralPrimitives;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.spheres"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("rhi::AccelerationStructureBuildInputSpheres")]
        public AccelerationStructureBuildInputSpheres spheres;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.linearSweptSpheres"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("rhi::AccelerationStructureBuildInputLinearSweptSpheres")]
        public AccelerationStructureBuildInputLinearSweptSpheres linearSweptSpheres;
    }
}
