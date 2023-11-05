using System;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe readonly struct VariableReflection : IEquatable<VariableReflection>
{
    private readonly Unsafe.VariableReflection* pointer;
    public Unsafe.VariableReflection* Pointer
    {
        get
        {
            ThrowIfNull();
            return pointer;
        }
    }

    internal VariableReflection(SlangReflectionVariable* pointer) : this((Unsafe.VariableReflection*)pointer) { }
    internal VariableReflection(Unsafe.VariableReflection* pointer) => this.pointer = pointer;

    internal void ThrowIfNull()
    {
        if (pointer == null)
            throw new NullReferenceException("This instance of VariableReflection has a null pointer");
    }

    public bool Equals(VariableReflection other) => pointer == other.pointer;
    public override bool Equals(object obj) => obj is VariableReflection other && Equals(other);
    public static bool operator ==(VariableReflection a, VariableReflection b) => a.pointer == b.pointer;
    public static bool operator !=(VariableReflection a, VariableReflection b) => a.pointer != b.pointer;
    public override int GetHashCode() => new IntPtr(pointer).GetHashCode();
}