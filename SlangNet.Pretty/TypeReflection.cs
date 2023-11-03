using System;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe readonly struct TypeReflection : IEquatable<TypeReflection>
{
    private readonly Unsafe.TypeReflection* pointer;
    public Unsafe.TypeReflection* Pointer
    {
        get
        {
            ThrowIfNull();
            return pointer;
        }
    }

    internal TypeReflection(Unsafe.TypeReflection* pointer) => this.pointer = pointer;

    internal void ThrowIfNull()
    {
        if (pointer == null)
            throw new NullReferenceException("This instance of TypeReflection has a null pointer");
    }

    public bool Equals(TypeReflection other) => pointer == other.pointer;
    public override bool Equals(object obj) => obj is TypeReflection other && Equals(other);
    public static bool operator == (TypeReflection a, TypeReflection b) => a.pointer == b.pointer;
    public static bool operator != (TypeReflection a, TypeReflection b) => a.pointer != b.pointer;
    public override int GetHashCode() => new IntPtr(pointer).GetHashCode();
}
