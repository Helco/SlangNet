namespace SlangNet.RHI.Unsafe;

/// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage"]/*' />
public enum BufferUsage
{
    /// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage.None"]/*' />
    None = 0,

    /// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage.VertexBuffer"]/*' />
    VertexBuffer = (1 << 0),

    /// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage.IndexBuffer"]/*' />
    IndexBuffer = (1 << 1),

    /// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage.ConstantBuffer"]/*' />
    ConstantBuffer = (1 << 2),

    /// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage.ShaderResource"]/*' />
    ShaderResource = (1 << 3),

    /// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage.UnorderedAccess"]/*' />
    UnorderedAccess = (1 << 4),

    /// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage.IndirectArgument"]/*' />
    IndirectArgument = (1 << 5),

    /// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage.CopySource"]/*' />
    CopySource = (1 << 6),

    /// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage.CopyDestination"]/*' />
    CopyDestination = (1 << 7),

    /// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage.AccelerationStructure"]/*' />
    AccelerationStructure = (1 << 8),

    /// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage.AccelerationStructureBuildInput"]/*' />
    AccelerationStructureBuildInput = (1 << 9),

    /// <include file='BufferUsage.xml' path='doc/member[@name="BufferUsage.ShaderTable"]/*' />
    ShaderTable = (1 << 10),
}
