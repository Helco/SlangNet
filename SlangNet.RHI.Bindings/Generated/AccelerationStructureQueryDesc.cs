namespace SlangNet.RHI.Unsafe;

/// <include file='AccelerationStructureQueryDesc.xml' path='doc/member[@name="AccelerationStructureQueryDesc"]/*' />
public unsafe partial struct AccelerationStructureQueryDesc
{
    /// <include file='AccelerationStructureQueryDesc.xml' path='doc/member[@name="AccelerationStructureQueryDesc.queryType"]/*' />
    [NativeTypeName("rhi::QueryType")]
    public QueryType queryType;

    /// <include file='AccelerationStructureQueryDesc.xml' path='doc/member[@name="AccelerationStructureQueryDesc.queryPool"]/*' />
    [NativeTypeName("rhi::IQueryPool *")]
    public IQueryPool* queryPool;

    /// <include file='AccelerationStructureQueryDesc.xml' path='doc/member[@name="AccelerationStructureQueryDesc.firstQueryIndex"]/*' />
    [NativeTypeName("rhi::GfxIndex")]
    public int firstQueryIndex;
}
