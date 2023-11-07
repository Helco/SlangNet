using System;
using System.Collections.Generic;
using System.Text;
using SlangNet.Unsafe;
using static SlangNet.Unsafe.Slang;

namespace SlangNet;

public unsafe readonly struct VariableLayoutReflection : IEquatable<VariableLayoutReflection>
{
    private readonly Unsafe.VariableLayoutReflection* pointer;
    public Unsafe.VariableLayoutReflection* Pointer
    {
        get
        {
            ThrowIfNull();
            return pointer;
        }
    }
    private SlangReflectionVariableLayout* InternalPointer => (SlangReflectionVariableLayout*)Pointer;

    internal VariableLayoutReflection(SlangReflectionVariableLayout* pointer) : this((Unsafe.VariableLayoutReflection*)pointer) { }
    internal VariableLayoutReflection(Unsafe.VariableLayoutReflection* pointer)
    {
        this.pointer = pointer;
    }

    internal void ThrowIfNull()
    {
        if (pointer == null)
            throw new NullReferenceException("This instance of VariableLayoutReflection has a null pointer");
    }

    public bool Equals(VariableLayoutReflection other) => pointer == other.pointer;
    public override bool Equals(object obj) => obj is VariableLayoutReflection other && Equals(other);
    public static bool operator ==(VariableLayoutReflection a, VariableLayoutReflection b) => a.pointer == b.pointer;
    public static bool operator !=(VariableLayoutReflection a, VariableLayoutReflection b) => a.pointer != b.pointer;
    public override int GetHashCode() => new IntPtr(pointer).GetHashCode();

    public VariableReflection Variable
    {
        get
        {
            var ptr = ReflectionVariableLayout_GetVariable(InternalPointer);
            if (ptr == null)
                throw new SlangException($"{nameof(ReflectionVariableLayout_GetVariable)} returned a null pointer");
            return new VariableReflection(ptr);
        }
    }

    public TypeLayoutReflection Type
    {
        get
        {
            var ptr = ReflectionVariableLayout_GetTypeLayout(InternalPointer);
            if (ptr == null)
                throw new SlangException($"{nameof(ReflectionVariableLayout_GetTypeLayout)} returned a null pointer");
            return new TypeLayoutReflection(ptr);
        }
    }

    public ulong GetOffset(ParameterCategory category) =>
        ReflectionVariableLayout_GetOffset(InternalPointer, (SlangParameterCategory)category).ToUInt64();

    public ulong GetSpace(ParameterCategory category) =>
        ReflectionVariableLayout_GetSpace(InternalPointer, (SlangParameterCategory)category).ToUInt64();

    public string? SemanticName =>
        InteropUtils.PtrToStringUTF8(ReflectionVariableLayout_GetSemanticName(InternalPointer));

    public ulong SemanticIndex =>
        ReflectionVariableLayout_GetSemanticIndex(InternalPointer).ToUInt64();

    public Stage Stage =>
        (Stage)ReflectionVariableLayout_getStage(InternalPointer);

    public VariableLayoutReflection? PendingDataLayout
    {
        get
        {
            var ptr = ReflectionVariableLayout_getPendingDataLayout(InternalPointer);
            return ptr == null ? null : new(ptr);
        }
    }

    public uint BindingIndex => ReflectionParameter_GetBindingIndex(InternalPointer);
    public uint BindingSpace => ReflectionParameter_GetBindingSpace(InternalPointer);
}