using System;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe readonly struct TypeLayoutReflection : IEquatable<TypeLayoutReflection>
{
    private readonly Unsafe.TypeLayoutReflection* pointer;
    public Unsafe.TypeLayoutReflection* Pointer
    {
        get
        {
            ThrowIfNull();
            return pointer;
        }
    }

    internal TypeLayoutReflection(Unsafe.TypeLayoutReflection* pointer) => this.pointer = pointer;

    internal void ThrowIfNull()
    {
        if (pointer == null)
            throw new NullReferenceException("This instance of TypeLayoutReflection has a null pointer");
    }

    public bool Equals(TypeLayoutReflection other) => pointer == other.pointer;
    public override bool Equals(object obj) => obj is TypeLayoutReflection other && Equals(other);
    public static bool operator == (TypeLayoutReflection a, TypeLayoutReflection b) => a.pointer == b.pointer;
    public static bool operator != (TypeLayoutReflection a, TypeLayoutReflection b) => a.pointer != b.pointer;
    public override int GetHashCode() => new IntPtr(pointer).GetHashCode();
}