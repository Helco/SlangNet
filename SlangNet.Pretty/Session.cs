using System;
using System.Text;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe sealed class Session : Internal.COMObject<ISession>
{
    internal Session(ISession* pointer) : base(pointer)
    {
    }

    public GlobalSession GlobalSession
    {
        get
        {
            var globalSession = Pointer->getGlobalSession();
            globalSession->addRef();
            return new GlobalSession(globalSession);
        }
    }

    public Module? LoadModule(ReadOnlySpan<byte> moduleName, out string? diagnostics)
    {
        using var diagnosticsBlob = new COMPointer<ISlangBlob>(); 
        IModule* modulePtr;
        fixed (byte* moduleNamePtr = moduleName)
            modulePtr = Pointer->loadModule((sbyte*)moduleNamePtr, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        return modulePtr == null ? null : new Module(modulePtr);
    }

    public Module? LoadModule(string moduleName, out string? diagnostics)
    {
        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        using var moduleNameStr = new Utf8String(moduleName);
        var modulePtr = Pointer->loadModule(moduleNameStr, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        return modulePtr == null ? null : new Module(modulePtr);
    }

    public Module? LoadModuleFromSource(ReadOnlySpan<byte> moduleName, ReadOnlySpan<byte> modulePath, byte[] source, out string? diagnostics)
    {
        var sourceBlob = new ArrayBlob(source);
        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        IModule* modulePtr;
        fixed (byte* moduleNamePtr = moduleName)
        fixed (byte* modulePathPtr = modulePath)
            modulePtr = Pointer->loadModuleFromSource((sbyte*)moduleNamePtr, (sbyte*)modulePathPtr, sourceBlob, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        return modulePtr == null ? null : new Module(modulePtr);
    }

    public Module? LoadModuleFromSource(string moduleName, string modulePath, byte[] source, out string? diagnostics)
    {
        using var moduleNameStr = new Utf8String(moduleName);
        using var modulePathStr = new Utf8String(modulePath);
        var sourceBlob = new ArrayBlob(source);
        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        var modulePtr = Pointer->loadModuleFromSource(moduleNameStr, modulePathStr, sourceBlob, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        return modulePtr == null ? null : new Module(modulePtr);
    }

    public Module? LoadModuleFromSource(ReadOnlySpan<byte> moduleName, ReadOnlySpan<byte> modulePath, ReadOnlySpan<byte> source, out string? diagnostics) =>
        LoadModuleFromSource(moduleName, modulePath, source.ToArray(), out diagnostics);

    public Module? LoadModuleFromSource(string moduleName, string modulePath, string source, out string? diagnostics) =>
        LoadModuleFromSource(moduleName, modulePath, Encoding.UTF8.GetBytes(source), out diagnostics);
}
