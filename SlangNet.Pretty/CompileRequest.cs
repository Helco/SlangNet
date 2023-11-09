using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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


}
