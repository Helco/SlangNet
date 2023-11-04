using System;
using SlangNet.Unsafe;

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

    internal ShaderReflection(Unsafe.ShaderReflection* pointer) => this.pointer = pointer;

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
}
