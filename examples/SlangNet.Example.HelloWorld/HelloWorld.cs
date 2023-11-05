using Veldrid;
using SlangNet;

namespace SlangNet.Example.HelloWorld.Unsafe;

internal unsafe class HelloWorldUnsafe
{
    private const int ElementCount = 16;
    private const int BufferSize = sizeof(float) * ElementCount;

    private static GraphicsDevice graphicsDevice;
    private static Shader shader;
    private static ResourceLayout resourceLayout;
    private static Pipeline pipeline;
    private static DeviceBuffer inputBuffer0, inputBuffer1, outputBuffer, stagingBuffer;

    private static ResourceFactory ResourceFactory => graphicsDevice.ResourceFactory;

    static void Main(string[] args)
    {
        try
        {
            graphicsDevice = GraphicsDevice.CreateVulkan(new()
            {
                Debug = false,
                HasMainSwapchain = false
            });

            LoadModuleAndCreatePipeline();
            CreateBuffers();
            DispatchCompute();
            PrintComputeResults();

        }
        finally
        {
            inputBuffer0?.Dispose();
            inputBuffer1?.Dispose();
            outputBuffer?.Dispose();
            shader?.Dispose();
            resourceLayout?.Dispose();
            pipeline?.Dispose();
            graphicsDevice?.Dispose();
        }
    }

    private static void LoadModuleAndCreatePipeline()
    {
        // First a global session is necessary
        using var globalSession = GlobalSession.Create();

        // Next a session to generate SPIRV code is created
        using var session = globalSession.CreateSession(new()
        {
            Targets =
            {
                new()
                {
                    Format = CompileTarget.SPIRV,
                    Flags = TargetFlags.GenerateSPIRVDirectly,
                    Profile = globalSession.FindProfile("glsl440"u8)
                }
            }
        });

        // Once the session has been obtained, we can start loading code into it.
        Environment.CurrentDirectory = Path.GetDirectoryName(typeof(HelloWorldUnsafe).Assembly.Location);
        using var module = session.LoadModule("hello-world"u8);

        // Now that the module is loaded we can look up those entry points by name.
        using var entryPoint = module.GetEntryPointByName("computeMain"u8);

        // A single Slang module could contain many different entry points (e.g.,
        // four vertex entry points, three fragment entry points, and two compute
        // shaders), and before we try to generate output code for our target API
        // we need to identify which entry points we plan to use together.
        var componentTypes = new ComponentType[] { module, entryPoint };

        // Actually creating the composite component type is a single operation
        // on the Slang session, but the operation could potentially fail if
        // something about the composite was invalid (e.g., you are trying to
        // combine multiple copies of the same module), so we need to deal
        // with the possibility of diagnostic output.
        using var composedProgram = session.CreateCompositeComponentType(componentTypes);

        // Now we can call `composedProgram->getEntryPointCode()` to retrieve the
        // compiled SPIRV code that we will use to create a vulkan compute pipeline.
        // This will trigger the final Slang compilation and spirv code generation.
        using var spirvCode = composedProgram.GetEntryPointCode(0, 0);

        CreatePipelineFromSpirv(spirvCode.Memory.Span);
    }

    private static void CreatePipelineFromSpirv(ReadOnlySpan<byte> spirvCode)
    {
        shader = ResourceFactory.CreateShader(new()
        {
            Debug = true,
            EntryPoint = "main",
            Stage = ShaderStages.Compute,
            ShaderBytes = spirvCode.ToArray()
        });

        resourceLayout = ResourceFactory.CreateResourceLayout(new(
            new ResourceLayoutElementDescription("buffer0", ResourceKind.StructuredBufferReadOnly, ShaderStages.Compute),
            new ResourceLayoutElementDescription("buffer1", ResourceKind.StructuredBufferReadOnly, ShaderStages.Compute),
            new ResourceLayoutElementDescription("result", ResourceKind.StructuredBufferReadOnly, ShaderStages.Compute)));

        pipeline = ResourceFactory.CreateComputePipeline(new()
        {
            ComputeShader = shader,
            ResourceLayouts = new[] { resourceLayout },
            ThreadGroupSizeX = 1,
            ThreadGroupSizeY = 1,
            ThreadGroupSizeZ = 1,
        });
    }

    private static void CreateBuffers()
    {
        var description = new BufferDescription(BufferSize, BufferUsage.StructuredBufferReadOnly, sizeof(float));
        inputBuffer0 = ResourceFactory.CreateBuffer(description);
        inputBuffer1 = ResourceFactory.CreateBuffer(description);
        outputBuffer = ResourceFactory.CreateBuffer(description with { Usage = BufferUsage.StructuredBufferReadWrite });
        stagingBuffer = ResourceFactory.CreateBuffer(description with { Usage = BufferUsage.Staging, StructureByteStride = 0 });

        var mapped = graphicsDevice.Map<float>(stagingBuffer, MapMode.Write);
        for (int i = 0; i < ElementCount; i++)
            mapped[i] = i;
        graphicsDevice.Unmap(stagingBuffer);
    }

    private static void DispatchCompute()
    {
        using var commandList = ResourceFactory.CreateCommandList();
        using var resourceSet = ResourceFactory.CreateResourceSet(new(resourceLayout, inputBuffer0, inputBuffer1, outputBuffer));
        commandList.Begin();
        commandList.CopyBuffer(stagingBuffer, 0, inputBuffer0, 0, BufferSize);
        commandList.CopyBuffer(stagingBuffer, 0, inputBuffer1, 0, BufferSize);
        commandList.SetPipeline(pipeline);
        commandList.SetComputeResourceSet(0, resourceSet);
        commandList.Dispatch(ElementCount, 1, 1);
        commandList.CopyBuffer(outputBuffer, 0, stagingBuffer, 0, BufferSize);
        commandList.End();
        graphicsDevice.SubmitCommands(commandList);
        graphicsDevice.WaitForIdle();
    }

    private static void PrintComputeResults()
    {
        var mapped = graphicsDevice.Map<float>(stagingBuffer, MapMode.Write);
        for (int i = 0; i < ElementCount; i++)
            Console.WriteLine(mapped[i]);
        graphicsDevice.Unmap(stagingBuffer);
    }
}