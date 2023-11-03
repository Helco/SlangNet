using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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

    public Module? TryLoadModule(ReadOnlySpan<byte> moduleName, out string? diagnostics)
    {
        using var diagnosticsBlob = new COMPointer<ISlangBlob>(); 
        IModule* modulePtr;
        fixed (byte* moduleNamePtr = moduleName)
            modulePtr = Pointer->loadModule((sbyte*)moduleNamePtr, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        return modulePtr == null ? null : new Module(modulePtr);
    }

    public Module? TryLoadModule(string moduleName, out string? diagnostics)
    {
        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        using var moduleNameStr = new Utf8String(moduleName);
        var modulePtr = Pointer->loadModule(moduleNameStr, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        return modulePtr == null ? null : new Module(modulePtr);
    }

    public Module? TryLoadModuleFromSource(ReadOnlySpan<byte> moduleName, ReadOnlySpan<byte> modulePath, byte[] source, out string? diagnostics)
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

    public Module? TryLoadModuleFromSource(string moduleName, string modulePath, byte[] source, out string? diagnostics)
    {
        using var moduleNameStr = new Utf8String(moduleName);
        using var modulePathStr = new Utf8String(modulePath);
        var sourceBlob = new ArrayBlob(source);
        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        var modulePtr = Pointer->loadModuleFromSource(moduleNameStr, modulePathStr, sourceBlob, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        return modulePtr == null ? null : new Module(modulePtr);
    }

    public Module? TryLoadModuleFromSource(ReadOnlySpan<byte> moduleName, ReadOnlySpan<byte> modulePath, ReadOnlySpan<byte> source, out string? diagnostics) =>
        TryLoadModuleFromSource(moduleName, modulePath, source.ToArray(), out diagnostics);

    public Module? TryLoadModuleFromSource(string moduleName, string modulePath, string source, out string? diagnostics) =>
        TryLoadModuleFromSource(moduleName, modulePath, Encoding.UTF8.GetBytes(source), out diagnostics);

    public Module LoadModule(ReadOnlySpan<byte> moduleName) =>
        TryLoadModule(moduleName, out var diagnostics) ??
        throw new SlangException(diagnostics ?? "Unknown error");

    public Module LoadModule(string moduleName) =>
        TryLoadModule(moduleName, out var diagnostics) ??
        throw new SlangException(diagnostics ?? "Unknown error");

    public Module LoadModuleFromSource(ReadOnlySpan<byte> moduleName, ReadOnlySpan<byte> modulePath, byte[] source) =>
        TryLoadModuleFromSource(moduleName, modulePath, source, out var diagnostics) ??
        throw new SlangException(diagnostics ?? "Unknown error");

    public Module LoadModuleFromSource(string moduleName, string modulePath, byte[] source) =>
        TryLoadModuleFromSource(moduleName, modulePath, source, out var diagnostics) ??
        throw new SlangException(diagnostics ?? "Unknown error");

    public Module LoadModuleFromSource(ReadOnlySpan<byte> moduleName, ReadOnlySpan<byte> modulePath, ReadOnlySpan<byte> source) =>
        TryLoadModuleFromSource(moduleName, modulePath, source, out var diagnostics) ??
        throw new SlangException(diagnostics ?? "Unknown error");

    public Module LoadModuleFromSource(string moduleName, string modulePath, string source) =>
        TryLoadModuleFromSource(moduleName, modulePath, source, out var diagnostics) ??
        throw new SlangException(diagnostics ?? "Unknown error");

    public SlangResult TryCreateCompositeComponentType(IEnumerable<ComponentType> componentTypes, out string? diagnostics, [NotNullWhen(true)] out ComponentType? compositeComponentType)
    {
        var componentTypeArray = new IComponentType*[componentTypes.Count()];
        var i = 0;
        foreach (var componentType in componentTypes)
            componentTypeArray[i++] = componentType.Pointer;

        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        IComponentType* compositeComponentTypePtr = null;
        int result;
        fixed(IComponentType** componentTypePtrs = componentTypeArray)
            result = Pointer->createCompositeComponentType(componentTypePtrs, componentTypeArray.LongLength, &compositeComponentTypePtr, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        compositeComponentType = ComponentType.CreateFromPointer(compositeComponentTypePtr);
        return new(result);
    }

    // this would actually use SpecializationArg, but this currently only supports TypeReflection args
    // if this changes we can keep this API non-breaking as a shortcut and add a more complex one later
    public TypeReflection? TrySpecializeType(TypeReflection type, IEnumerable<TypeReflection> specializationArgs, out string? diagnostics)
    {
        type.ThrowIfNull();
        var argsArray = new SpecializationArg[specializationArgs.Count()];
        var i = 0;
        foreach (var specArg in specializationArgs)
        {
            specArg.ThrowIfNull();
            argsArray[i].kind = SpecializationArg.Kind.Type;
            argsArray[i].type = specArg.Pointer;
        }

        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        Unsafe.TypeReflection* specializedTypePtr;
        fixed (SpecializationArg* argsPtr = argsArray)
            specializedTypePtr = Pointer->specializeType(type.Pointer, argsPtr, argsArray.LongLength, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        return specializedTypePtr == null ? null : new(specializedTypePtr);
    }

    public TypeReflection SpecializeType(TypeReflection type, IEnumerable<TypeReflection> specializationArgs) =>
        TrySpecializeType(type, specializationArgs, out var diagnostics) ??
        throw new SlangException(diagnostics ?? "Unknown error");

    public TypeLayoutReflection? TryGetTypeLayout(TypeReflection type, long targetIndex, LayoutRules rules, out string? diagnostics)
    {
        type.ThrowIfNull();
        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        var layoutPtr = Pointer->getTypeLayout(type.Pointer, targetIndex, rules, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        return layoutPtr == null ? null : new(layoutPtr);
    }

    public TypeLayoutReflection? TryGetTypeLayout(TypeReflection type, long targetIndex, out string? diagnostics) =>
        TryGetTypeLayout(type, targetIndex, LayoutRules.Default, out diagnostics);

    public TypeLayoutReflection? TryGetTypeLayout(TypeReflection type, out string? diagnostics) =>
        TryGetTypeLayout(type, targetIndex: 0, LayoutRules.Default, out diagnostics);

    public TypeLayoutReflection GetTypeLayout(TypeReflection type, long targetIndex = 0, LayoutRules rules = LayoutRules.Default) =>
        TryGetTypeLayout(type, targetIndex, rules, out var diagnostics) ??
        throw new SlangException(diagnostics ?? "Unknown error");

    public TypeReflection? TryGetContainerType(TypeReflection elementType, ContainerType containerType, out string? diagnostics)
    {
        elementType.ThrowIfNull();
        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        var containerTypePtr = Pointer->getContainerType(elementType.Pointer, containerType, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        return containerTypePtr == null ? null : new(containerTypePtr);
    }

    public TypeReflection GetContainerType(TypeReflection elementType, ContainerType containerType) =>
        TryGetContainerType(elementType, containerType, out var diagnostics) ??
        throw new SlangException(diagnostics ?? "Unknown error");

    // the dynamic type is always created, so we assume no null is returned here ever 
    public TypeReflection DynamicType => new(Pointer->getDynamicType());

    public SlangResult TryGetTypeRTTIMangledName(TypeReflection type, out string? name)
    {
        name = null;
        if (type.Pointer == null)
            return SlangResult.InvalidArg;
        using var nameBlob = new COMPointer<ISlangBlob>();
        var result = Pointer->getTypeRTTIMangledName(type.Pointer, &nameBlob.Pointer);
        name = nameBlob.AsString();
        return new(result);
    }

    public SlangResult TryGetTypeConformanceWitnessMangledName(TypeReflection type, TypeReflection interfaceType, out string? name)
    {
        name = null;
        if (type.Pointer == null || interfaceType.Pointer == null)
            return SlangResult.InvalidArg;
        using var nameBlob = new COMPointer<ISlangBlob>();
        var result = Pointer->getTypeConformanceWitnessMangledName(type.Pointer, interfaceType.Pointer, &nameBlob.Pointer);
        name = nameBlob.AsString();
        return new(result);
    }

    public SlangResult TryGetTypeConformanceWitnessSequentialID(TypeReflection type, TypeReflection interfaceType, out uint id)
    {
        id = 0;
        if (type.Pointer == null || interfaceType.Pointer == null)
            return SlangResult.InvalidArg;
        fixed(uint* idPtr = &id)
            return new(Pointer->getTypeConformanceWitnessSequentialID(type.Pointer, interfaceType.Pointer, idPtr));
    }

    public SlangResult TryCreateCompileRequest(out CompileRequest? request)
    {
        ICompileRequest* requestPtr = null;
        var result = Pointer->createCompileRequest(&requestPtr);
        request = requestPtr == null ? null : new(requestPtr);
        return new(result);
    }

    public SlangResult TryCreateTypeConformanceComponentType(
        TypeReflection type,
        TypeReflection interfaceType,
        long conformanceIdOverride,
        out string? diagnostics,
        out TypeConformance? conformance)
    {
        diagnostics = null;
        conformance = null;
        if (type.Pointer == null || interfaceType.Pointer == null)
            return SlangResult.InvalidArg;
        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        ITypeConformance* conformancePtr = null;
        var result = Pointer->createTypeConformanceComponentType(
            type.Pointer,
            interfaceType.Pointer,
            &conformancePtr,
            conformanceIdOverride,
            &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        conformance = conformancePtr == null ? null : new(conformancePtr);
        return new(result);
    }
}
