namespace SlangNet.RHI.Unsafe;

/// <include file='RayTracingPipelineFlags.xml' path='doc/member[@name="RayTracingPipelineFlags"]/*' />
public enum RayTracingPipelineFlags
{
    /// <include file='RayTracingPipelineFlags.xml' path='doc/member[@name="RayTracingPipelineFlags.None"]/*' />
    None = 0,

    /// <include file='RayTracingPipelineFlags.xml' path='doc/member[@name="RayTracingPipelineFlags.SkipTriangles"]/*' />
    SkipTriangles = (1 << 0),

    /// <include file='RayTracingPipelineFlags.xml' path='doc/member[@name="RayTracingPipelineFlags.SkipProcedurals"]/*' />
    SkipProcedurals = (1 << 1),
}
