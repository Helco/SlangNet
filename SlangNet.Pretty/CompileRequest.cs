using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using SlangNet.Internal;
using SlangNet.Unsafe;

namespace SlangNet;

[GenerateThrowingMethods]
public unsafe sealed partial class CompileRequest : COMObject<ICompileRequest>
{
    internal CompileRequest(ICompileRequest* pointer) : base(pointer)
    {
        DependencyFilePaths = new NativeBoundedReadOnlyList<ICompileRequest, string>
        {
            Container = Pointer,
            GetCount = &GetDependencyFileCount,
            TryGetAt = &TryGetDependencyFileAt
        };
        TranslationUnits = new(pointer);
    }

    // IFileSystem FileSystem

    public CompileFlags CompileFlags
    {
        get => (CompileFlags)Pointer->getCompileFlags();
        set => Pointer->setCompileFlags((uint)value);
    }

    public bool DumpIntermediates
    {
        set => Pointer->setDumpIntermediates(value ? 1 : 0);
    }

    public string? DumpIntermediatePrefix
    {
        set
        {
            using var prefixStr = new Utf8String(value);
            Pointer->setDumpIntermediatePrefix(prefixStr);
        }
    }

    public LineDirectiveMode LineDirectiveMode
    {
        set => Pointer->setLineDirectiveMode((SlangLineDirectiveMode)value);
    }

    public void SetCodeGenTarget(CompileTarget target) =>
        Pointer->setCodeGenTarget((SlangCompileTarget)target);

    public void AddCodeGenTarget(CompileTarget target) =>
        Pointer->addCodeGenTarget((SlangCompileTarget)target);

    public void SetTargetProfile(int targetIndex, ProfileID profile) =>
        Pointer->setTargetProfile(targetIndex, (SlangProfileID)profile);

    public void SetTargetFlags(int targetIndex, TargetFlags flags) =>
        Pointer->setTargetFlags(targetIndex, (uint)flags);

    public void SetTargetFloatingPointMode(int targetIndex, FloatingPointMode mode) =>
        Pointer->setTargetFloatingPointMode(targetIndex, (SlangFloatingPointMode)mode);

    public void SetTargetMatrixLayoutMode(int targetIndex, MatrixLayoutMode mode) =>
        Pointer->setTargetMatrixLayoutMode(targetIndex, (SlangMatrixLayoutMode)mode);

    public MatrixLayoutMode MatrixLayoutMode
    {
        set => Pointer->setMatrixLayoutMode((SlangMatrixLayoutMode)value);
    }

    public DebugInfoLevel DebugInfoLevel
    {
        set => Pointer->setDebugInfoLevel((SlangDebugInfoLevel)value);
    }

    public OptimizationLevel OptimizationLevel
    {
        set => Pointer->setOptimizationLevel((SlangOptimizationLevel)value);
    }

    public ContainerFormat OutputContainerFormat
    {
        set => Pointer->setOutputContainerFormat((SlangContainerFormat)value);
    }

    public PassThrough PassThrough
    {
        set => Pointer->setPassThrough((SlangPassThrough)value);
    }

    //DiagnosticCallback
    //Writer...

    public void AddSearchPath(string searchPath)
    {
        using var searchPathStr = new Utf8String(searchPath);
        Pointer->addSearchPath(searchPathStr);
    }

    public void AddSearchPath(ReadOnlySpan<byte> searchPath)
    {
        fixed (byte* searchPathPtr = searchPath)
            Pointer->addSearchPath((sbyte*)searchPathPtr);
    }

    public void AddPreprocessorDefine(ReadOnlySpan<byte> key, ReadOnlySpan<byte> value)
    {
        fixed (byte* keyPtr = key)
        fixed (byte* valuePtr = value)
            Pointer->addPreprocessorDefine((sbyte*)keyPtr, (sbyte*)valuePtr);
    }

    public void AddPreprocessorDefine(string key, string value)
    {
        using var keyStr = new Utf8String(key);
        using var valueStr = new Utf8String(value);
        Pointer->addPreprocessorDefine(keyStr, valueStr);
    }

    public SlangResult TryProcessCommandLineArguments(IEnumerable<string> arguments)
    {
        using var argumentsArray = new Utf8StringArray(arguments);
        return new(Pointer->processCommandLineArguments(argumentsArray.Memory, argumentsArray.Count));
    }

    public string DefaultModuleName
    {
        set
        {
            using var nameStr = new Utf8String(value);
            Pointer->setDefaultModuleName(nameStr);
        }
    }

    public SlangResult TryAddLibraryReference(ReadOnlySpan<byte> libData)
    {
        fixed (byte* libDataPtr = libData)
            return new(Pointer->addLibraryReference(libDataPtr, new((uint)libData.Length)));
    }

    public SlangResult TrySetGlobalGenericArgs(IEnumerable<string> genericArgs)
    {
        using var genericArgsArray = new Utf8StringArray(genericArgs);
        return new(Pointer->setGlobalGenericArgs(genericArgsArray.Count, genericArgsArray.Memory));
    }

    public SlangResult TrySetTypeNameForGlobalExistentialTypeParam(int slotIndex, ReadOnlySpan<byte> typeName)
    {
        fixed (byte* typeNamePtr = typeName)
            return new(Pointer->setTypeNameForGlobalExistentialTypeParam(slotIndex, (sbyte*)typeNamePtr));
    }

    public SlangResult TrySetTypeNameForGlobalExistentialTypeParam(int slotIndex, string typeName)
    {
        using var typeNameStr = new Utf8String(typeName);
        return new(Pointer->setTypeNameForGlobalExistentialTypeParam(slotIndex, typeNameStr));
    }

    public SlangResult TrySetTypeNameForEntryPointExistentialTypeName(int entryPointIndex, int slotIndex, ReadOnlySpan<byte> typeName)
    {
        fixed (byte* typeNamePtr = typeName)
            return new(Pointer->setTypeNameForEntryPointExistentialTypeParam(entryPointIndex, slotIndex, (sbyte*)typeNamePtr));
    }

    public SlangResult TrySetTypeNameForEntryPointExistentialTypeName(int entryPointIndex, int slotIndex, string typeName)
    {
        using var typeNameStr = new Utf8String(typeName);
        return new(Pointer->setTypeNameForEntryPointExistentialTypeParam(entryPointIndex, slotIndex, typeNameStr));
    }

    public SlangResult TryCompile() =>
        new(Pointer->compile());

    public string? DiagnosticOutput =>
        InteropUtils.PtrToStringUTF8(Pointer->getDiagnosticOutput());

    // skipping getDiagnosticOutputBlob

    private static long GetDependencyFileCount(ICompileRequest* compileRequest) =>
        compileRequest->getDependencyFileCount();

    private static bool TryGetDependencyFileAt(ICompileRequest* compileRequest, long index, ref string result)
    {
        var ptr = compileRequest->getDependencyFilePath(checked((int)index));
        result = InteropUtils.PtrToStringUTF8(ptr) ?? "";
        return ptr != null;
    }

    public IReadOnlyList<string> DependencyFilePaths { get; }
    public TranslationUnitList TranslationUnits { get; }

    public string? GetEntryPointSource(int index) =>
        InteropUtils.PtrToStringUTF8(Pointer->getEntryPointSource(index));

    public ReadOnlySpan<byte> GetEntryPointCode(int index)
    {
        UIntPtr size = default;
        var ptr = Pointer->getEntryPointCode(index, &size);
        if (ptr == null)
            throw new NullReferenceException($"CompileRequest::getEntryPointCode returned a null pointer");
        return new ReadOnlySpan<byte>(ptr, checked((int)size.ToUInt64()));
    }

    public SlangResult TryGetEntryPointCodeBlob(int entryPointIndex, int targetIndex, [NotNullWhen(true)] out IMemoryOwner<byte>? blob)
    {
        ISlangBlob* blobPtr = null;
        var result = Pointer->getEntryPointCodeBlob(entryPointIndex, targetIndex, &blobPtr);
        blob = blobPtr == null ? null : new BlobMemoryManager(blobPtr);
        return new(result);
    }

    // TODO: Add CompileRequest::getEntryPointHostCallable
    // TODO: Add CompileRequest::getTargetHostCallable

    public SlangResult TryGetTargetCodeBlob(int targetIndex, [NotNullWhen(true)] out IMemoryOwner<byte>? blob)
    {
        ISlangBlob* blobPtr = null;
        var result = Pointer->getTargetCodeBlob(targetIndex, &blobPtr);
        blob = blobPtr == null ? null : new BlobMemoryManager(blobPtr);
        return new(result);
    }

    public ReadOnlySpan<byte> CompileRequestCode
    {
        get
        {
            UIntPtr size = default;
            var ptr = Pointer->getCompileRequestCode(&size);
            if (ptr == null)
                throw new NullReferenceException($"CompileRequest::getCompileRequestCode returned a null pointer");
            return new ReadOnlySpan<byte>(ptr, checked((int)size.ToUInt64()));
        }
    }

    // TODO: Add CompileRequest::loadRepro

    public SlangResult TrySaveRepro([NotNullWhen(true)] out IMemoryOwner<byte>? blob)
    {
        ISlangBlob* blobPtr = null;
        var result = Pointer->saveRepro(&blobPtr);
        blob = blobPtr == null ? null : new BlobMemoryManager(blobPtr);
        return new(result);
    }

    public SlangResult TryEnableReproCapture() =>
        new(Pointer->enableReproCapture());

    public SlangResult TryGetProgram([NotNullWhen(true)] out ComponentType? program)
    {
        IComponentType* programPtr = null;
        var result = Pointer->getProgram(&programPtr);
        program = ComponentType.CreateFromPointer(programPtr);
        return new(result);
    }

    public SlangResult TryGetEntryPoint(long entryPointIndex, [NotNullWhen(true)] out ComponentType? entryPoint)
    {
        IComponentType* entryPointPtr = null;
        var result = Pointer->getEntryPoint(entryPointIndex, &entryPointPtr);
        entryPoint = ComponentType.CreateFromPointer(entryPointPtr);
        return new(result);
    }

    public SlangResult TryGetSession([NotNullWhen(true)] out Session? session)
    {
        ISession* sessionPtr = null;
        var result = Pointer->getSession(&sessionPtr);
        session = sessionPtr == null ? null : new(sessionPtr);
        return new(result);
    }

    public ShaderReflection? Reflection
    {
        get
        {
            var ptr = Pointer->getReflection();
            return ptr == null ? null : new(ptr);
        }
    }

    public void SetCommandLineCompilerMode() =>
        Pointer->setCommandLineCompilerMode();

    public SlangResult TryAddTargetCapability(long targetIndex, SlangCapabilityID capability) =>
        new(Pointer->addTargetCapability(targetIndex, capability));

    public SlangResult TryGetProgramWithEntryPoints([NotNullWhen(true)] out ComponentType? program)
    {
        IComponentType* programPtr = null;
        var result = Pointer->getProgramWithEntryPoints(&programPtr);
        program = ComponentType.CreateFromPointer(programPtr);
        return new(result);
    }

    public SlangResult TryIsParameterLocationUsed(
        long entryPointIndex,
        long targetIndex,
        SlangParameterCategory category,
        ulong spaceIndex,
        ulong registerIndex,
        out bool used)
    {
        fixed (bool* usedPtr = &used)
            return new(Pointer->isParameterLocationUsed(entryPointIndex, targetIndex, category, spaceIndex, registerIndex, usedPtr));
    }

    public void SetTargetLineDirectiveMode(long targetIndex, LineDirectiveMode mode) =>
        Pointer->setTargetLineDirectiveMode(targetIndex, (SlangLineDirectiveMode)mode);

    public void SetTargetForceGLSLScalarBufferLayout(int targetIndex, bool forceScalarLayout) =>
        Pointer->setTargetForceGLSLScalarBufferLayout(targetIndex, forceScalarLayout ? (byte)1 : (byte)0);

    public void OverrideDiagnosticSeverity(long messageID, Severity overrideSeverity) =>
        Pointer->overrideDiagnosticSeverity(messageID, (SlangSeverity)overrideSeverity);

    public DiagnosticFlags DiagnosticFlags
    {
        get => (DiagnosticFlags)Pointer->getDiagnosticFlags();
        set => Pointer->setDiagnosticFlags((int)value);
    }

    public DebugInfoFormat DebugInfoFormat
    {
        set => Pointer->setDebugInfoFormat((SlangDebugInfoFormat)value);
    }

    public bool EnableEffectAnnotations
    {
        set => Pointer->setEnableEffectAnnotations((byte)(value ? 1 : 0));
    }

    public bool ReportDownstreamTime
    {
        set => Pointer->setReportDownstreamTime((byte)(value ? 1 : 0));
    }

    public bool ReportPerfBenchmark
    {
        set => Pointer->setReportPerfBenchmark((byte)(value ? 1 : 0));
    }
}
