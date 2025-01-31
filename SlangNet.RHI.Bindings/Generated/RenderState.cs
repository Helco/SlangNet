using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='RenderState.xml' path='doc/member[@name="RenderState"]/*' />
public unsafe partial struct RenderState
{
    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.pipeline"]/*' />
    [NativeTypeName("rhi::IRenderPipeline *")]
    public IRenderPipeline* pipeline;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.rootObject"]/*' />
    [NativeTypeName("rhi::IShaderObject *")]
    public IShaderObject* rootObject;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.stencilRef"]/*' />
    [NativeTypeName("uint32_t")]
    public uint stencilRef;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.viewports"]/*' />
    [NativeTypeName("Viewport[16]")]
    public _viewports_e__FixedBuffer viewports;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.viewportCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint viewportCount;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.scissorRects"]/*' />
    [NativeTypeName("ScissorRect[16]")]
    public _scissorRects_e__FixedBuffer scissorRects;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.scissorRectCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint scissorRectCount;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.vertexBuffers"]/*' />
    [NativeTypeName("BufferWithOffset[16]")]
    public _vertexBuffers_e__FixedBuffer vertexBuffers;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.vertexBufferCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vertexBufferCount;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.indexBuffer"]/*' />
    [NativeTypeName("rhi::BufferWithOffset")]
    public BufferWithOffset indexBuffer;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.indexFormat"]/*' />
    [NativeTypeName("rhi::IndexFormat")]
    public IndexFormat indexFormat;

    /// <include file='_viewports_e__FixedBuffer.xml' path='doc/member[@name="_viewports_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _viewports_e__FixedBuffer
    {
        public Viewport e0;
    }

    /// <include file='_scissorRects_e__FixedBuffer.xml' path='doc/member[@name="_scissorRects_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _scissorRects_e__FixedBuffer
    {
        public ScissorRect e0;
    }

    /// <include file='_vertexBuffers_e__FixedBuffer.xml' path='doc/member[@name="_vertexBuffers_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _vertexBuffers_e__FixedBuffer
    {
        public BufferWithOffset e0;
    }
}
