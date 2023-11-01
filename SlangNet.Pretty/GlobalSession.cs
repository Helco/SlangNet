using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using SlangNet.Unsafe;
using static SlangNet.Unsafe.Slang;
using static SlangNet.InteropUtils;
using System.Buffers;

namespace SlangNet;

[GenerateThrowingMethods]
public unsafe sealed partial class GlobalSession : Internal.COMObject<IGlobalSession>
{
    private GlobalSession(IGlobalSession* pointer) : base(pointer) { }

    public static SlangResult TryCreate([NotNullWhen(true)] out GlobalSession? session)
        => TryCreate(SLANG_API_VERSION, out session);

    public static SlangResult TryCreate(long apiVersion, [NotNullWhen(true)] out GlobalSession? session)
    {
        IGlobalSession* pointer;
        var result = new SlangResult(slang_createGlobalSession(apiVersion, &pointer));
        session = result.Succeeded ? new(pointer) : null;
        return result;
    }

    public SlangResult CheckCompileTargetSupport(CompileTarget target) =>
        new(Pointer->checkCompileTargetSupport((SlangCompileTarget)target));

    public SlangResult CheckPassThroughSupport(PassThrough passThrough) =>
        new(Pointer->checkPassThroughSupport((SlangPassThrough)passThrough));

    public void AddBuiltins(ReadOnlySpan<byte> sourcePath, ReadOnlySpan<byte> sourceString)
    {
        fixed(byte* sourcePathPtr = sourcePath)
        fixed(byte* sourceStringPtr = sourceString)
            Pointer->addBuiltins((sbyte*)sourcePathPtr, (sbyte*)sourceStringPtr);
    }

    public void AddBuiltins(string sourcePath, string sourceString)
    {
        using var sourcePathStr = new Utf8String(sourcePath);
        using var sourceStringStr = new Utf8String(sourceString);
        Pointer->addBuiltins(sourcePathStr, sourceStringStr);
    }

    public ProfileID FindProfile(ReadOnlySpan<byte> name)
    {
        fixed (byte* namePtr = name)
            return (ProfileID)Pointer->findProfile((sbyte*)namePtr);
    }

    public ProfileID FindProfile(string name)
    {
        using var nameStr = new Utf8String(name);
        return (ProfileID)Pointer->findProfile(nameStr);
    }

    public CapabilityID FindCapability(ReadOnlySpan<byte> name)
    {
        fixed (byte* namePtr = name)
            return (CapabilityID)Pointer->findCapability((sbyte*)namePtr);
    }

    public CapabilityID FindCapability(string name)
    {
        using var nameStr = new Utf8String(name);
        return (CapabilityID)Pointer->findCapability(nameStr);
    }

    public void GetCompilerElapsedTime(out double totalTime, out double downstreamTime)
    {
        fixed (double* totalTimePtr = &totalTime)
        fixed (double* downstreamTimePtr = &downstreamTime)
            Pointer->getCompilerElapsedTime(totalTimePtr, downstreamTimePtr);
    }

    public void SetDownstreamCompilerPath(PassThrough passThrough, string path)
    {
        using var pathStr = new Utf8String(path);
        Pointer->setDownstreamCompilerPath((SlangPassThrough)passThrough, pathStr);
    }

    public void SetDownstreamCompilerPath(PassThrough passThrough, ReadOnlySpan<byte> path)
    {
        fixed (byte* pathPtr = path)
            Pointer->setDownstreamCompilerPath((SlangPassThrough)passThrough, (sbyte*)pathPtr);
    }

    public PassThrough GetDefaultDownstreamCompiler(SourceLanguage sourceLanguage) =>
        (PassThrough)Pointer->getDefaultDownstreamCompiler((SlangSourceLanguage)sourceLanguage);

    public SlangResult TrySetDefaultDownstreamCompiler(SourceLanguage sourceLanguage, PassThrough defaultCompiler) =>
        new(Pointer->setDefaultDownstreamCompiler((SlangSourceLanguage)sourceLanguage, (SlangPassThrough)defaultCompiler));

    public PassThrough GetDownstreamCompilerForTransition(CompileTarget source, CompileTarget target) =>
        (PassThrough)Pointer->getDownstreamCompilerForTransition((SlangCompileTarget)source, (SlangCompileTarget)target);

    public void SetDownstreamCompilerForTransition(CompileTarget source, CompileTarget target, PassThrough compiler) =>
        Pointer->setDownstreamCompilerForTransition((SlangCompileTarget)source, (SlangCompileTarget)target, (SlangPassThrough)compiler);

    public string? GetLanguagePrelude(SourceLanguage sourceLanguage)
    {
        using var preludeBlob = new COMPointer<ISlangBlob>();
        Pointer->getLanguagePrelude((SlangSourceLanguage)sourceLanguage, &preludeBlob.Pointer);
        return preludeBlob.GetAsString();
    }

    public void SetLanguagePrelude(SourceLanguage sourceLanguage, string? prelude)
    {
        using var preludeStr = new Utf8String(prelude);
        Pointer->setLanguagePrelude((SlangSourceLanguage)sourceLanguage, preludeStr.Memory);
    }

    public void SetLanguagePrelude(SourceLanguage sourceLanguage, ReadOnlySpan<byte> prelude)
    {
        fixed (byte* preludePtr = prelude)
            Pointer->setLanguagePrelude((SlangSourceLanguage)sourceLanguage, (sbyte*)preludePtr);
    }

    public string? BuildTagString => PtrToStringUTF8(Pointer->getBuildTagString());

    public SlangResult TryCompileStdLib(CompileStdLibFlags flags) =>
        new(Pointer->compileStdLib((uint)flags));

    public SlangResult TryLoadStdLib(ReadOnlySpan<byte> stdLib)
    {
        fixed (byte* stdLibPtr = stdLib)
            return new(Pointer->loadStdLib(stdLibPtr, new((uint)stdLib.Length)));
    }

    public SlangResult TrySaveStdLib(ArchiveType archiveType, [NotNullWhen(true)] out IMemoryOwner<byte>? stdlib)
    {
        stdlib = null;
        ISlangBlob* blob;
        var result = Pointer->saveStdLib((SlangArchiveType)archiveType, &blob);
        if (blob != null)
            stdlib = new BlobMemoryManager(blob);
        return new(result);
    }


    public SlangResult TrySetSPIRVCoreGrammar(string jsonPath)
    {
        using var jsonPathStr = new Utf8String(jsonPath);
        return new(Pointer->setSPIRVCoreGrammar(jsonPathStr));
    }

    public SlangResult TrySetSPIRVCoreGrammar(ReadOnlySpan<byte> jsonPath)
    {
        fixed (byte* jsonPathPtr = jsonPath)
            return new(Pointer->setSPIRVCoreGrammar((sbyte*)jsonPathPtr));
    }

    /*public ISharedLibraryLoader? SharedLibraryLoader
    {
        get;
        set;
    }*/

    //public SlangResult TryCreateSession(in SessionDescription desc, [NotNullWhen(true)] out Session? session);
    //public SlangResult TryCreateCompileRequest([NotNullWhen(true)] out CompileRequest? request);
}
