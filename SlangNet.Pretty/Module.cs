using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe sealed class Module : ComponentType
{
    private readonly EntryPointList entryPoints;

    public new IModule* Pointer => (IModule*)base.Pointer;

    internal Module(IModule* pointer) : base((IComponentType*)pointer)
    {
        entryPoints = new(this);
    }

    public SlangResult FindEntryPointByName(ReadOnlySpan<byte> name, [NotNullWhen(true)] out EntryPoint? entryPoint)
    {
        IEntryPoint* entryPointPtr = null;
        SlangResult result;
        fixed (byte* namePtr = name)
            result = new(Pointer->findEntryPointByName((sbyte*)namePtr, &entryPointPtr));
        entryPoint = entryPointPtr == null ? null : new(entryPointPtr);
        return result;
    }

    public SlangResult FindEntryPointByName(string name, [NotNullWhen(true)] out EntryPoint? entryPoint)
    {
        using var nameStr = new Utf8String(name);
        IEntryPoint* entryPointPtr = null;
        var result = Pointer->findEntryPointByName(nameStr, &entryPointPtr);
        entryPoint = entryPointPtr == null ? null : new(entryPointPtr);
        return new(result);
    }

    public EntryPoint GetEntryPointByName(ReadOnlySpan<byte> name)
    {
        FindEntryPointByName(name, out var entryPoint).ThrowIfFailed();
        return entryPoint!;
    }

    public EntryPoint GetEntryPointByName(string name)
    {
        FindEntryPointByName(name, out var entryPoint).ThrowIfFailed();
        return entryPoint!;
    }

    private class EntryPointList : NativeResultReadOnlyList<EntryPoint>
    {
        private readonly Module module;

        public EntryPointList(Module module) => this.module = module;

        public override int Count => module.Pointer->getDefinedEntryPointCount();

        public override SlangResult TryGetAt(int index, [NotNullWhen(true)] out EntryPoint? entryPoint)
        {
            IEntryPoint* entryPointPtr = null;
            var result = module.Pointer->getDefinedEntryPoint(index, &entryPointPtr);
            entryPoint = entryPointPtr == null ? null : new(entryPointPtr);
            return new(result);
        }
    }

    public IReadOnlyList<EntryPoint> DefinedEntryPoints => entryPoints;

    public SlangResult TryGetDefinedEntryPoint(int index, out EntryPoint? entryPoint) =>
        entryPoints.TryGetAt(index, out entryPoint);

    public EntryPoint GetDefinedEntryPoint(int index) =>
        entryPoints[index];
}
