namespace SlangNet.RHI.Unsafe;

/// <include file='ResourceState.xml' path='doc/member[@name="ResourceState"]/*' />
public enum ResourceState
{
    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.Undefined"]/*' />
    Undefined,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.General"]/*' />
    General,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.VertexBuffer"]/*' />
    VertexBuffer,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.IndexBuffer"]/*' />
    IndexBuffer,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.ConstantBuffer"]/*' />
    ConstantBuffer,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.StreamOutput"]/*' />
    StreamOutput,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.ShaderResource"]/*' />
    ShaderResource,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.UnorderedAccess"]/*' />
    UnorderedAccess,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.RenderTarget"]/*' />
    RenderTarget,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.DepthRead"]/*' />
    DepthRead,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.DepthWrite"]/*' />
    DepthWrite,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.Present"]/*' />
    Present,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.IndirectArgument"]/*' />
    IndirectArgument,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.CopySource"]/*' />
    CopySource,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.CopyDestination"]/*' />
    CopyDestination,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.ResolveSource"]/*' />
    ResolveSource,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.ResolveDestination"]/*' />
    ResolveDestination,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.AccelerationStructure"]/*' />
    AccelerationStructure,

    /// <include file='ResourceState.xml' path='doc/member[@name="ResourceState.AccelerationStructureBuildInput"]/*' />
    AccelerationStructureBuildInput,
}
