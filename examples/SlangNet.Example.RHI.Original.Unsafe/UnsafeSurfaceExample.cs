using System;
using SlangNet.RHI.Unsafe;
using Silk.NET.GLFW;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using GlfwWindowHandle = Silk.NET.GLFW.WindowHandle;
using SlangWindowHandle = SlangNet.RHI.Unsafe.WindowHandle;
using System.Windows.Input;

namespace SlangNet.Example.RHI.Original.Unsafe;

public unsafe class UnsafeSurfaceExample : UnsafeExampleBase
{
    private float grey = 0.5f;
    private ICommandQueue* queue = null;

    public override string Name => "Surface";

    public override bool Init(DeviceType deviceType)
    {
        CreateDevice(deviceType);
        CreateWindow();
        CreateSurface();

        ICommandQueue* queue_ = null;
        var result = new SlangResult(device->getQueue(QueueType.Graphics, &queue_));
        if (result.Succeeded && queue_ == null)
            result = SlangResult.GotNullPointer;
        result.ThrowIfFailed();
        queue = queue_;
        
        return true;
    }

    public override void Shutdown()
    {
        Debug.Assert(queue != null);
        queue->waitOnHost();
        queue->release();
        queue = null;
    }

    public override void Update()
    {
    }

    public override void Draw()
    {
        ITexture* texture = null;
        surface->acquireNextImage(&texture);
        if (texture == null)
            return;
        
        ITextureView* view = null;
        TextureViewDesc desc = new()
        {
            structType = StructType.TextureViewDesc,
            next = null,
            format = Format.Undefined,
            aspect = TextureAspect.All,
            subresourceRange = new()
            {
                mipLevel = 0,
                mipLevelCount = 0x7fffffff,
                baseArrayLayer = 0,
                layerCount = 0x7fffffff
            }
        };
        var result = new SlangResult(device->createTextureView(texture, &desc, &view));
        if (result.Succeeded && view == null)
            result = SlangResult.GotNullPointer;
        result.ThrowIfFailed();

        ICommandEncoder* encoder = null;
        result = new SlangResult(queue->createCommandEncoder(&encoder));
        if (result.Succeeded && encoder == null)
            result = SlangResult.GotNullPointer;
        result.ThrowIfFailed();

        var colorAttachment = new RenderPassColorAttachment
        {
            view = view,
            loadOp = LoadOp.Clear,
            storeOp = StoreOp.Store,
            resolveTarget = null
        };
        colorAttachment.clearValue[0] = 
            colorAttachment.clearValue[1] = 
            colorAttachment.clearValue[2] = grey;
        colorAttachment.clearValue[3] = 1f;

        var renderPass = new RenderPassDesc
        {
            depthStencilAttachment = null,
            colorAttachments = &colorAttachment,
            colorAttachmentCount = 1
        };
        var passEncoder = encoder->beginRenderPass(&renderPass);
        if (passEncoder == null) SlangResult.GotNullPointer.ThrowIfFailed();
        passEncoder->end();
        
        ICommandBuffer* commandBuffer = null;
        result = new(encoder->finish(&commandBuffer));
        if (result.Succeeded && commandBuffer == null)
            result = SlangResult.GotNullPointer;
        result.ThrowIfFailed();
        SubmitDesc submitDesc = new()
        {
            commandBufferCount = 1,
            commandBuffers = &commandBuffer,
            signalFenceCount = 0,
            waitFenceCount = 0,
        };
        queue->submit(&submitDesc);

        result = new(surface->present());
        result.ThrowIfFailed();

        grey = (grey + (1f / 60f)) > 1f ? 0f : grey + (1f / 60f);

            passEncoder->release();
            encoder->release();
            commandBuffer->release();
            view->release();
            texture->release();
    }

    public static void Main(string[] args) =>
        Run<UnsafeSurfaceExample>(args);
}
