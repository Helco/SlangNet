namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureBuildInputMotionOptions.xml' path='doc/member[@name="AccelerationStructureBuildInputMotionOptions"]/*' />
public partial struct AccelerationStructureBuildInputMotionOptions
{
    /// <include file='AccelerationStructureBuildInputMotionOptions.xml' path='doc/member[@name="AccelerationStructureBuildInputMotionOptions.keyCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int keyCount;

    /// <include file='AccelerationStructureBuildInputMotionOptions.xml' path='doc/member[@name="AccelerationStructureBuildInputMotionOptions.timeStart"]/*' />
    public float timeStart;

    /// <include file='AccelerationStructureBuildInputMotionOptions.xml' path='doc/member[@name="AccelerationStructureBuildInputMotionOptions.timeEnd"]/*' />
    public float timeEnd;
}
