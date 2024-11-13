namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureBuildDesc.xml' path='doc/member[@name="AccelerationStructureBuildDesc"]/*' />
public unsafe partial struct AccelerationStructureBuildDesc
{
    /// <include file='AccelerationStructureBuildDesc.xml' path='doc/member[@name="AccelerationStructureBuildDesc.inputs"]/*' />
    [NativeTypeName("rhi::AccelerationStructureBuildInput *")]
    public AccelerationStructureBuildInput* inputs;

    /// <include file='AccelerationStructureBuildDesc.xml' path='doc/member[@name="AccelerationStructureBuildDesc.inputCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int inputCount;

    /// <include file='AccelerationStructureBuildDesc.xml' path='doc/member[@name="AccelerationStructureBuildDesc.motionOptions"]/*' />
    [NativeTypeName("rhi::AccelerationStructureBuildInputMotionOptions")]
    public AccelerationStructureBuildInputMotionOptions motionOptions;

    /// <include file='AccelerationStructureBuildDesc.xml' path='doc/member[@name="AccelerationStructureBuildDesc.mode"]/*' />
    [NativeTypeName("rhi::AccelerationStructureBuildMode")]
    public AccelerationStructureBuildMode mode;

    /// <include file='AccelerationStructureBuildDesc.xml' path='doc/member[@name="AccelerationStructureBuildDesc.flags"]/*' />
    [NativeTypeName("rhi::AccelerationStructureBuildFlags")]
    public AccelerationStructureBuildFlags flags;
}
