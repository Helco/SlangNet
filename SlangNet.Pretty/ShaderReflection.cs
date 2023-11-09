using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SlangNet.Unsafe;
using static SlangNet.Unsafe.Slang;

namespace SlangNet;

public unsafe readonly struct ShaderReflection : IEquatable<ShaderReflection>
{
    private readonly Unsafe.ShaderReflection* pointer;
    public Unsafe.ShaderReflection* Pointer
    {
        get
        {
            ThrowIfNull();
            return pointer;
        }
    }
    internal SlangProgramLayout* InternalPointer => (SlangProgramLayout*)Pointer;

    internal ShaderReflection(SlangProgramLayout* pointer) : this((Unsafe.ShaderReflection*)pointer) {}
    internal ShaderReflection(Unsafe.ShaderReflection* pointer)
    {
        this.pointer = pointer;
        Parameters = new NativeBoundedReadOnlyList<SlangProgramLayout, VariableLayoutReflection>
        {
            Container = InternalPointer,
            GetCount = &GetParameterCount,
            TryGetAt = &TryGetParameterAt
        };
        TypeParameters = new NativeBoundedReadOnlyList<SlangProgramLayout, TypeParameterReflection>
        {
            Container = InternalPointer,
            GetCount = &GetTypeParameterCount,
            TryGetAt = &TryGetTypeParameterAt
        };
        EntryPoints = new NativeBoundedReadOnlyList<SlangProgramLayout, EntryPointReflection>
        {
            Container = InternalPointer,
            GetCount = &GetEntryPointCount,
            TryGetAt = &TryGetEntryPointAt
        };
        HashedStrings = new NativeBoundedReadOnlyList<SlangProgramLayout, string>
        {
            Container = InternalPointer,
            GetCount = &GetHashedStringCount,
            TryGetAt = &TryGetHashedStringAt
        };
    }

    internal void ThrowIfNull()
    {
        if (pointer == null)
            throw new NullReferenceException("This instance of ShaderReflection has a null pointer");
    }

    public bool Equals(ShaderReflection other) => pointer == other.pointer;
    public override bool Equals(object obj) => obj is ShaderReflection other && Equals(other);
    public static bool operator ==(ShaderReflection a, ShaderReflection b) => a.pointer == b.pointer;
    public static bool operator !=(ShaderReflection a, ShaderReflection b) => a.pointer != b.pointer;
    public override int GetHashCode() => new IntPtr(pointer).GetHashCode();

    private static long GetParameterCount(SlangProgramLayout* program) =>
        Reflection_GetParameterCount(program);

    private static bool TryGetParameterAt(SlangProgramLayout* program, long index, ref VariableLayoutReflection variable)
    {
        var ptr = Reflection_GetParameterByIndex(program, checked((uint)index));
        variable = ptr == null ? default : new(ptr);
        return ptr != null;
    }

    public IReadOnlyList<VariableLayoutReflection> Parameters { get; }

    private static long GetTypeParameterCount(SlangProgramLayout* program) =>
        Reflection_GetTypeParameterCount(program);
    
    private static bool TryGetTypeParameterAt(SlangProgramLayout* program, long index, ref TypeParameterReflection typeParam)
    {
        var ptr = Reflection_GetTypeParameterByIndex(program, checked((uint)index));
        typeParam = ptr == null ? default : new(ptr);
        return ptr != null;
    }

    public IReadOnlyList<TypeParameterReflection> TypeParameters { get; }

    public TypeParameterReflection? FindTypeParameter(ReadOnlySpan<byte> name)
    {
        SlangReflectionTypeParameter* paramPtr;
        fixed (byte* namePtr = name)
            paramPtr = Reflection_FindTypeParameter(InternalPointer, (sbyte*)namePtr);
        return paramPtr == null ? null : new(paramPtr);
    }

    public TypeParameterReflection? FindTypeParameter(string name)
    {
        using var nameStr = new Utf8String(name);
        var paramPtr = Reflection_FindTypeParameter(InternalPointer, nameStr);
        return paramPtr == null ? null : new(paramPtr);
    }

    public TypeReflection? FindTypeByName(ReadOnlySpan<byte> name)
    {
        SlangReflectionType* typePtr;
        fixed (byte* namePtr = name)
            typePtr = Reflection_FindTypeByName(InternalPointer, (sbyte*)namePtr);
        return typePtr == null ? null : new(typePtr);
    }

    public TypeReflection? FindTypeByName(string name)
    {
        using var nameStr = new Utf8String(name);
        var typePtr = Reflection_FindTypeByName(InternalPointer, nameStr);
        return typePtr == null ? null : new(typePtr);
    }

    public TypeLayoutReflection? GetTypeLayout(TypeReflection type, LayoutRules rules)
    {
        var layoutPtr = Reflection_GetTypeLayout(InternalPointer, type.InternalPointer, (SlangLayoutRules)rules);
        return layoutPtr == null ? null : new(layoutPtr);
    }

    private static long GetEntryPointCount(SlangProgramLayout* program) =>
        checked((long)Reflection_getEntryPointCount(program));

    private static bool TryGetEntryPointAt(SlangProgramLayout* program, long index, ref EntryPointReflection entryPoint)
    {
        var ptr = Reflection_getEntryPointByIndex(program, checked((ulong)index));
        entryPoint = ptr == null ? default : new(ptr);
        return ptr != null;
    }

    public IReadOnlyList<EntryPointReflection> EntryPoints { get; }

    public EntryPointReflection? FindEntryPointByName(ReadOnlySpan<byte> name)
    {
        SlangEntryPointLayout* entryPointPtr;
        fixed (byte* namePtr = name)
            entryPointPtr = Reflection_findEntryPointByName(InternalPointer, (sbyte*)namePtr);
        return entryPointPtr == null ? null : new(entryPointPtr);
    }

    public EntryPointReflection? FindEntryPointByName(string name)
    {
        using var nameStr = new Utf8String(name);
        var entryPointPtr = Reflection_findEntryPointByName(InternalPointer, nameStr);
        return entryPointPtr == null ? null : new(entryPointPtr);
    }

    public ulong GlobalConstantBufferBinding =>
        Reflection_getGlobalConstantBufferBinding(InternalPointer);

    public ulong GlobalConstantBufferSize =>
        Reflection_getGlobalConstantBufferSize(InternalPointer).ToUInt64();

    public TypeReflection? SpecializeType(TypeReflection type, IEnumerable<TypeReflection> specializationArgs, out string? diagnostics)
    {
        var specializationArray = new SlangReflectionType*[specializationArgs.Count()];
        int i = 0;
        foreach (var arg in specializationArgs)
            specializationArray[i++] = arg.InternalPointer;

        using var diagnosticsBlob = new COMPointer<ISlangBlob>();
        SlangReflectionType* specializedTypePtr;
        fixed (SlangReflectionType** specializationPtrs = specializationArray)
            specializedTypePtr = Reflection_specializeType(InternalPointer, type.InternalPointer, specializationArray.Length, specializationPtrs, &diagnosticsBlob.Pointer);
        diagnostics = diagnosticsBlob.AsString();
        return specializedTypePtr == null ? null : new(specializedTypePtr);
    }

    private static long GetHashedStringCount(SlangProgramLayout* program) =>
        checked((long)Reflection_getHashedStringCount(program));

    private static bool TryGetHashedStringAt(SlangProgramLayout* program, long index, ref string hashedString)
    {
        UIntPtr countPtr;
        var ptr = Reflection_getHashedString(program, checked((ulong)index), &countPtr);
        if (ptr != null)
            hashedString = Encoding.UTF8.GetString((byte*)ptr, checked((int)countPtr.ToUInt64()));
        return ptr != null;
    }

    public IReadOnlyList<string> HashedStrings { get; }

    public static uint ComputeStringHash(ReadOnlySpan<byte> chars)
    {
        fixed(byte* charsPtr = chars)
        return Slang.ComputeStringHash((sbyte*)charsPtr, new((uint)chars.Length));
    }

    public static uint ComputeStringHash(string chars)
    {
        using var charsStr = new Utf8String(chars);
        return Slang.ComputeStringHash(charsStr, new((ulong)(charsStr.MemoryEnd - charsStr.Memory)));
    }

    public TypeLayoutReflection? GlobalParamsTypeLayout
    {
        get
        {
            var ptr = Reflection_getGlobalParamsTypeLayout(InternalPointer);
            return ptr == null ? null : new(ptr);
        }
    }

    public VariableLayoutReflection? GlobalParamsVarLayout
    {
        get
        {
            var ptr = Reflection_getGlobalParamsVarLayout(InternalPointer);
            return ptr == null ? null : new(ptr);
        }
    }
}
