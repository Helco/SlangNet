using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using SlangNet.Internal;
using SlangNet.Unsafe;

namespace SlangNet;

[GenerateThrowingMethods]
public unsafe partial class ComponentType : COMObject<IComponentType>
{
    internal static ComponentType? CreateFromPointer(IComponentType* pointer) =>
        pointer == null ? null
        : IsSubClass(pointer, IEntryPoint.TypeGuid) ? new EntryPoint((IEntryPoint*)pointer)
        : IsSubClass(pointer, IModule.TypeGuid) ? new Module((IModule*)pointer)
        : IsSubClass(pointer, ITypeConformance.TypeGuid) ? new TypeConformance((ITypeConformance*)pointer)
        : new ComponentType(pointer);

    private static bool IsSubClass(IComponentType* pointer, in SlangUUID uuid)
    {
        void* testPtr = null;
        fixed (SlangUUID* uuidPtr = &uuid)
        {
            var result = new SlangResult(pointer->queryInterface(uuidPtr, &testPtr));
            if (result.Failed)
                return false;
            pointer->release(); // queryInterface adds another reference
            return true;
        }
    }

    private protected ComponentType(IComponentType* pointer) : base(pointer) {}

    public Session Session => new Session(Pointer->getSession());

    public ShaderReflection? TryGetLayout(long targetIndex, out string? diagnostics)
    {
        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        var reflectionPtr = Pointer->getLayout(targetIndex, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        return reflectionPtr == null ? null : new ShaderReflection(reflectionPtr);
    }

    public ShaderReflection? TryGetLayout(out string? diagnostics) =>
        TryGetLayout(targetIndex: 0, out diagnostics);

    public ShaderReflection GetLayout(long targetIndex = 0) =>
        TryGetLayout(targetIndex, out var diagnostics) ??
        throw new SlangException(diagnostics ?? "Unknown error");

    public long SpecializationParamCount => Pointer->getSpecializationParamCount();

    public SlangResult TryGetEntryPointCode(long entryPointIndex, long targetIndex, out string? diagnostics, [NotNullWhen(true)] out IMemoryOwner<byte>? code)
    {
        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        ISlangBlob* codePtr = null;
        var result = Pointer->getEntryPointCode(entryPointIndex, targetIndex, &codePtr, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        code = codePtr == null ? null : new BlobMemoryManager(codePtr);
        return new(result);
    }

    // TODO: Missing ComponentType.GetResultAsFileSystem
    // TODO: Missing ComponentType.GetEntryPointHostCallable

    public IMemoryOwner<byte>? TryGetEntryPointHash(long entryPointIndex, long targetIndex)
    {
        ISlangBlob* codePtr = null;
        Pointer->getEntryPointHash(entryPointIndex, targetIndex, &codePtr);
        return codePtr == null ? null : new BlobMemoryManager(codePtr);
    }

    public IMemoryOwner<byte> GetEntryPointHash(long entryPointIndex, long targetIndex) =>
        TryGetEntryPointHash(entryPointIndex, targetIndex) ??
        throw new SlangException("GetEntryPointHash returned a null pointer");

    // this would actually use SpecializationArg, but this currently only supports TypeReflection args
    // if this changes we can keep this API non-breaking as a shortcut and add a more complex one later
    public SlangResult TrySpecialize(IEnumerable<TypeReflection> specializationArgs, out string? diagnostics, [NotNullWhen(true)] out ComponentType? specializedType)
    {
        var argsArray = new SpecializationArg[specializationArgs.Count()];
        var i = 0;
        foreach (var specArg in specializationArgs)
        {
            specArg.ThrowIfNull();
            argsArray[i].kind = SpecializationArg.Kind.Type;
            argsArray[i].type = specArg.Pointer;
        }

        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        SlangResult result;
        IComponentType* specializedTypePtr = null;
        fixed (SpecializationArg* argsPtr = argsArray)
            result = new(Pointer->specialize(argsPtr, argsArray.LongLength, &specializedTypePtr, & diagnosticsBlob.Pointer));
        diagnostics = diagnosticsBlob.AsString();
        specializedType = specializedTypePtr == null ? null : CreateFromPointer(specializedTypePtr);
        return result;
    }

    public SlangResult TryLink(out string? diagnostics, [NotNullWhen(true)] out ComponentType? linkedType)
    {
        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        IComponentType* linkedTypePtr = null;
        var result = Pointer->link(&linkedTypePtr, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        linkedType = linkedTypePtr == null ? null : CreateFromPointer(linkedTypePtr);
        return new(result);
    }


    public SlangResult TryRenameEntryPoint(ReadOnlySpan<byte> newName, [NotNullWhen(true)] out ComponentType? entryPoint)
    {
        SlangResult result;
        IComponentType* entryPointPtr = null;
        fixed (byte* newNamePtr = newName)
            result = new(Pointer->renameEntryPoint((sbyte*)newNamePtr, &entryPointPtr));
        entryPoint = entryPointPtr == null ? null : CreateFromPointer(entryPointPtr);
        return result;
    }

    public SlangResult TryRenameEntryPoint(string newName, [NotNullWhen(true)] out ComponentType? entryPoint)
    {
        using var newNameStr = new Utf8String(newName);
        IComponentType* entryPointPtr = null;
        var result = Pointer->renameEntryPoint(newNameStr, &entryPointPtr);
        entryPoint = entryPointPtr == null ? null : CreateFromPointer(entryPointPtr);
        return new(result);
    }
}
