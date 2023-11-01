using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using SlangNet.Unsafe;
using static SlangNet.Unsafe.Slang;

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

    // TODO: Missing members for GlobalSession
    // public object SharedLibraryLoader { get; set; }
    // public CompileRequest CreateCompileRequest();
    // ExtractRepro
    // LoadReproAsFileSystem


}
