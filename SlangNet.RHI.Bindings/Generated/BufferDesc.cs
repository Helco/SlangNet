using System;

namespace SlangNet.RHI.Unsafe;

/// <include file='BufferDesc.xml' path='doc/member[@name="BufferDesc"]/*' />
public unsafe partial struct BufferDesc
{
    /// <include file='BufferDesc.xml' path='doc/member[@name="BufferDesc.size"]/*' />
    [NativeTypeName("rhi::Size")]
    public UIntPtr size;

    /// <include file='BufferDesc.xml' path='doc/member[@name="BufferDesc.elementSize"]/*' />
    [NativeTypeName("rhi::Size")]
    public UIntPtr elementSize;

    /// <include file='BufferDesc.xml' path='doc/member[@name="BufferDesc.format"]/*' />
    [NativeTypeName("rhi::Format")]
    public Format format;

    /// <include file='BufferDesc.xml' path='doc/member[@name="BufferDesc.memoryType"]/*' />
    [NativeTypeName("rhi::MemoryType")]
    public MemoryType memoryType;

    /// <include file='BufferDesc.xml' path='doc/member[@name="BufferDesc.usage"]/*' />
    [NativeTypeName("rhi::BufferUsage")]
    public BufferUsage usage;

    /// <include file='BufferDesc.xml' path='doc/member[@name="BufferDesc.defaultState"]/*' />
    [NativeTypeName("rhi::ResourceState")]
    public ResourceState defaultState;

    /// <include file='BufferDesc.xml' path='doc/member[@name="BufferDesc.isShared"]/*' />
    public bool isShared;

    /// <include file='BufferDesc.xml' path='doc/member[@name="BufferDesc.label"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* label;
}
