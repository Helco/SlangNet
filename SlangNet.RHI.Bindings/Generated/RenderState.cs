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
    [NativeTypeName("rhi::GfxCount")]
    public int viewportCount;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.scissorRects"]/*' />
    [NativeTypeName("ScissorRect[16]")]
    public _scissorRects_e__FixedBuffer scissorRects;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.scissorRectCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int scissorRectCount;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.vertexBuffers"]/*' />
    [NativeTypeName("BufferWithOffset[16]")]
    public _vertexBuffers_e__FixedBuffer vertexBuffers;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.vertexBufferCount"]/*' />
    [NativeTypeName("rhi::GfxCount")]
    public int vertexBufferCount;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.indexBuffer"]/*' />
    [NativeTypeName("rhi::BufferWithOffset")]
    public BufferWithOffset indexBuffer;

    /// <include file='RenderState.xml' path='doc/member[@name="RenderState.indexFormat"]/*' />
    [NativeTypeName("rhi::IndexFormat")]
    public IndexFormat indexFormat;

    /// <include file='_viewports_e__FixedBuffer.xml' path='doc/member[@name="_viewports_e__FixedBuffer"]/*' />
    public partial struct _viewports_e__FixedBuffer
    {
        public Viewport e0;
        public Viewport e1;
        public Viewport e2;
        public Viewport e3;
        public Viewport e4;
        public Viewport e5;
        public Viewport e6;
        public Viewport e7;
        public Viewport e8;
        public Viewport e9;
        public Viewport e10;
        public Viewport e11;
        public Viewport e12;
        public Viewport e13;
        public Viewport e14;
        public Viewport e15;

        public unsafe ref Viewport this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (Viewport* pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    /// <include file='_scissorRects_e__FixedBuffer.xml' path='doc/member[@name="_scissorRects_e__FixedBuffer"]/*' />
    public partial struct _scissorRects_e__FixedBuffer
    {
        public ScissorRect e0;
        public ScissorRect e1;
        public ScissorRect e2;
        public ScissorRect e3;
        public ScissorRect e4;
        public ScissorRect e5;
        public ScissorRect e6;
        public ScissorRect e7;
        public ScissorRect e8;
        public ScissorRect e9;
        public ScissorRect e10;
        public ScissorRect e11;
        public ScissorRect e12;
        public ScissorRect e13;
        public ScissorRect e14;
        public ScissorRect e15;

        public unsafe ref ScissorRect this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (ScissorRect* pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    /// <include file='_vertexBuffers_e__FixedBuffer.xml' path='doc/member[@name="_vertexBuffers_e__FixedBuffer"]/*' />
    public partial struct _vertexBuffers_e__FixedBuffer
    {
        public BufferWithOffset e0;
        public BufferWithOffset e1;
        public BufferWithOffset e2;
        public BufferWithOffset e3;
        public BufferWithOffset e4;
        public BufferWithOffset e5;
        public BufferWithOffset e6;
        public BufferWithOffset e7;
        public BufferWithOffset e8;
        public BufferWithOffset e9;
        public BufferWithOffset e10;
        public BufferWithOffset e11;
        public BufferWithOffset e12;
        public BufferWithOffset e13;
        public BufferWithOffset e14;
        public BufferWithOffset e15;

        public unsafe ref BufferWithOffset this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (BufferWithOffset* pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
