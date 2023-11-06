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
}