using Veldrid;
using SlangNet.Unsafe;
using static SlangNet.Unsafe.Slang;
using System.Runtime.InteropServices;

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

    private static void ThrowOnFail(int error)
    {
        if (error != SLANG_OK)
            throw new Exception($"Slang error: {error}");
    }

    private static void DiagnoseIfNeeded(ISlangBlob* diagnosticBlob)
    {
        if (diagnosticBlob == null)
            return;
        Console.Error.WriteLine(Marshal.PtrToStringUTF8(new(diagnosticBlob->getBufferPointer())));
    }

    private static void LoadModuleAndCreatePipeline()
    {
        IGlobalSession* globalSession = null;
        ISession* session = null;
        IModule* module = null;
        ISlangBlob* diagnosticsBlob = null;
        IEntryPoint* entryPoint = null;
        IComponentType* composedProgram = null;
        ISlangBlob* spirvCode = null;

        try
        {
            // First a global session is necessary
            ThrowOnFail(slang_createGlobalSession(SLANG_API_VERSION, &globalSession));

            // Next a session to generate SPIRV code is created
            SlangProfileID profile;
            fixed (byte* profileName = "glsl440"u8)
                profile = globalSession->findProfile((sbyte*)profileName);
            TargetDesc targetDesc = new()
            {
                structureSize = (nuint)sizeof(TargetDesc),
                format = SlangCompileTarget.SLANG_SPIRV,
                profile = profile,
                flags = SLANG_TARGET_FLAG_GENERATE_SPIRV_DIRECTLY
            };
            SessionDesc sessionDesc = new()
            {
                structureSize = (nuint)sizeof(SessionDesc),
                defaultMatrixLayoutMode = SlangMatrixLayoutMode.SLANG_MATRIX_LAYOUT_ROW_MAJOR,
                targetCount = 1,
                targets = &targetDesc
            };
            globalSession->createSession(&sessionDesc, &session);

            // Once the session has been obtained, we can start loading code into it.
            Environment.CurrentDirectory = Path.GetDirectoryName(typeof(HelloWorldUnsafe).Assembly.Location);
            fixed (byte* moduleName = "hello-world"u8)
                module = session->loadModule((sbyte*)moduleName, &diagnosticsBlob);
            DiagnoseIfNeeded(diagnosticsBlob);
            if (module == null)
                throw new Exception("Module was not loaded");
            module->addRef();

            // Now that the module is loaded we can look up those entry points by name.
            fixed (byte* entryPointName = "computeMain"u8)
                ThrowOnFail(module->findEntryPointByName((sbyte*)entryPointName, &entryPoint));

            // A single Slang module could contain many different entry points (e.g.,
            // four vertex entry points, three fragment entry points, and two compute
            // shaders), and before we try to generate output code for our target API
            // we need to identify which entry points we plan to use together.
            var componentTypes = stackalloc IComponentType*[2];
            componentTypes[0] = (IComponentType*)module;
            componentTypes[1] = (IComponentType*)entryPoint;

            // Actually creating the composite component type is a single operation
            // on the Slang session, but the operation could potentially fail if
            // something about the composite was invalid (e.g., you are trying to
            // combine multiple copies of the same module), so we need to deal
            // with the possibility of diagnostic output.
            if (diagnosticsBlob != null) diagnosticsBlob->release();
            var result = session->createCompositeComponentType(componentTypes, 2, &composedProgram, &diagnosticsBlob);
            DiagnoseIfNeeded(diagnosticsBlob);
            ThrowOnFail(result);

            // Now we can call `composedProgram->getEntryPointCode()` to retrieve the
            // compiled SPIRV code that we will use to create a vulkan compute pipeline.
            // This will trigger the final Slang compilation and spirv code generation.
            result = composedProgram->getEntryPointCode(0, 0, &spirvCode, &diagnosticsBlob);
            DiagnoseIfNeeded(diagnosticsBlob);
            ThrowOnFail(result);

            CreatePipelineFromSpirv(spirvCode);
        }
        finally
        {
            if (spirvCode != null) spirvCode->release();
            if (composedProgram != null) composedProgram->release();
            if (entryPoint != null) entryPoint->release();
            if (diagnosticsBlob != null) diagnosticsBlob->release();
            if (module != null) module->release();
            if (session != null) session->release();
            if (globalSession != null) globalSession->release();
        }
    }

    private static void CreatePipelineFromSpirv(ISlangBlob* spirvCode)
    {
        ReadOnlySpan<byte> spirvSpan = new(spirvCode->getBufferPointer(), checked((int)spirvCode->getBufferSize()));
        shader = ResourceFactory.CreateShader(new()
        {
            Debug = true,
            EntryPoint = "main",
            Stage = ShaderStages.Compute,
            ShaderBytes = spirvSpan.ToArray()
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