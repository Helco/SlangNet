using System;
using SlangNet.RHI.Unsafe;
using Silk.NET.GLFW;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using GlfwWindowHandle = Silk.NET.GLFW.WindowHandle;
using SlangWindowHandle = SlangNet.RHI.Unsafe.WindowHandle;

namespace SlangNet.Example.RHI.Original.Unsafe;

public static unsafe class DebugPrinter
{
    public static IDebugCallback* Pointer { get; }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)])]
    private static void HandleMessage(
        IDebugCallback* callback,
        DebugMessageType type,
        DebugMessageSource source,
        sbyte* message)
    {
        Console.WriteLine($"[{type}] ({source}): {Marshal.PtrToStringUTF8((nint)message)}");
    }

    static DebugPrinter()
    {
        var memory = Marshal.AllocHGlobal(sizeof(IDebugCallback) + sizeof(IDebugCallback.Vtbl));
        Pointer = (IDebugCallback*)memory;
        Pointer->lpVtbl = (IDebugCallback.Vtbl*)(Pointer + 1);
        Pointer->lpVtbl->handleMessage = &HandleMessage;
    }
}

public abstract unsafe class UnsafeExampleBase : IDisposable
{
    private static readonly Glfw glfw = Glfw.GetApi();

    public abstract string Name { get; }
    public abstract bool Init(DeviceType deviceType);
    public abstract void Shutdown();
    public abstract void Update();
    public abstract void Draw();
    public virtual void OnMousePosition(float x, float y) {}
    public virtual void OnMouseButton(MouseButton button, InputAction action, KeyModifiers mods) {}
    public virtual void OnScroll(float x, float y) {}

    public virtual void OnResize(int width, int height)
    {

    }

    private bool disposedValue;
    private GCHandle myHandle;
    protected GlfwWindowHandle* window = null;
    protected IDevice* device = null;
    protected ISurface* surface = null;
    protected float mousePosX, mousePosY;

    public UnsafeExampleBase()
    {
        myHandle = GCHandle.Alloc(this, GCHandleType.Pinned);
    }
    private UnsafeExampleBase GetMe(nint handle)
    {
        return (UnsafeExampleBase)GCHandle.FromIntPtr(handle).Target;
    }

    protected void CreateDevice(DeviceType deviceType)
    {
        var deviceDesc = new DeviceDesc
        {
            structType = StructType.DeviceDesc,
            next = null,
            slang = new()
            {
                defaultMatrixLayoutMode = SlangNet.Unsafe.SlangMatrixLayoutMode.SLANG_MATRIX_LAYOUT_ROW_MAJOR,
                floatingPointMode = SlangNet.Unsafe.SlangFloatingPointMode.SLANG_FLOATING_POINT_MODE_DEFAULT,
                optimizationLevel = SlangNet.Unsafe.SlangOptimizationLevel.SLANG_OPTIMIZATION_LEVEL_DEFAULT,
                lineDirectiveMode = SlangNet.Unsafe.SlangLineDirectiveMode.SLANG_LINE_DIRECTIVE_MODE_DEFAULT,
                targetFlags = 1u << 10 // default = Generate spirv directly
            },
            nvapiExtUavSlot = uint.MaxValue,
            deviceType = deviceType,
            enableValidation = true,
            enableBackendValidation = true,
            debugCallback = DebugPrinter.Pointer
        };
        IDevice* device_ = null;
        var result = new SlangResult(SlangRHI.getRHI()->createDevice(&deviceDesc, &device_));
        if (!result.Failed && device_ == null)
            result = SlangResult.GotNullPointer;
        result.ThrowIfFailed();
        device = device_;
    }

    protected void CreateWindow(int width = 640, int height = 480)
    {
        Debug.Assert(device != null);
        var deviceInfo = device->getDeviceInfo();
        var title = $"{Name} | {Marshal.PtrToStringUTF8((nint)deviceInfo->adapterName)} ({Marshal.PtrToStringUTF8((nint)SlangRHI.getRHI()->getDeviceTypeName(deviceInfo->deviceType))})";

        window = glfw.CreateWindow(width, height, title, null, null);
        if (window == null)
            throw new InvalidOperationException("Failed to create window");
        nint glfwSetWindowUserPointer = glfw.Context.GetProcAddress("glfwSetWindowUserPointer");
        ((delegate* unmanaged[Cdecl]<GlfwWindowHandle*, nint, void>)glfwSetWindowUserPointer)(window, (nint)myHandle);
        glfw.SetCursorPosCallback(window, (_, x, y) =>
        {
            foreach (var example in examples)
            {
                example.mousePosX = (float)x;
                example.mousePosY = (float)y;
                example.OnMousePosition((float)x, (float)y);
            }
        });
        glfw.SetMouseButtonCallback(window, (_, button, action, mods) =>
        {
            foreach (var example in examples)
                example.OnMouseButton(button, action, mods);
        });
        glfw.SetScrollCallback(window, (_, xoffset, yoffset) =>
        {
            foreach (var example in examples)
                example.OnScroll((float)xoffset, (float)yoffset);
        });
        glfw.SetFramebufferSizeCallback(window, (window, width, height) =>
        {
            glfw.GetWindowSize(window, out var windowWidth, out var windowHeight);
            // I refuse. this is stupid.
            OnResize(width, height);
        });
    }

    protected void CreateSurface(Format format = Format.Unknown)
    {
        Debug.Assert(device != null && window != null);
        glfw.GetFramebufferSize(window, out var width, out var height);

        SlangWindowHandle windowHandle = default;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            var glfwGetWin32Window = (delegate* unmanaged[Cdecl]<GlfwWindowHandle*, nint>)
                glfw.Context.GetProcAddress("glfwGetWin32Window");
            var hwnd = glfwGetWin32Window(window);
            windowHandle.type = WindowHandleType.HWND;
            windowHandle.handleValues[0] = (ulong)hwnd;
        }
        else
            throw new PlatformNotSupportedException();

        ISurface* surface_ = null;
        var result = new SlangResult(device->createSurface(windowHandle, &surface_));
        if (!result.Failed && surface_ == null)
            result = SlangResult.GotNullPointer;
        result.ThrowIfFailed();

        SurfaceConfig surfaceConfig = new()
        {
            desiredImageCount = 3,
            vsync = true,
            usage = TextureUsage.RenderTarget,
            width = (uint)width,
            height = (uint)height,
            format = format
        };
        result = new SlangResult(surface_->configure(&surfaceConfig));
        result.ThrowIfFailed();
        surface = surface_;
    }

    private static readonly List<UnsafeExampleBase> examples = [];
    public static void Main<TExample>(string[] args) where TExample : UnsafeExampleBase, new()
    {
        glfw.Init();
        glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.NoApi);

        foreach (var deviceType in new[] { DeviceType.Default })
        {
            var example = new TExample();
            examples.Add(example);
            if (!example.Init(deviceType))
            {
                Console.WriteLine($"Could not initialize {example.GetType().Name} for {deviceType}");
                return;
            }
        }

        // TODO: Add layout windows

        while(true)
        {
            if (examples.Any(e => glfw.WindowShouldClose(e.window)))
                break;
            glfw.PollEvents();

            foreach (var example in examples)
                example.Update();
            foreach (var example in examples)
                example.Draw();
        }

        foreach (var example in examples)
        {
            example.Shutdown();
            example.Dispose();
        }
        examples.Clear();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (surface != null)
            {
                surface->release();
                surface = null;
            }
            if (device != null)
            {
                device->release();
                device = null;
            }
            disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
