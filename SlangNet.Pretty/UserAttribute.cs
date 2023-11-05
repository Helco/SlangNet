using System;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe readonly struct UserAttribute : IEquatable<UserAttribute>
{
    private readonly Unsafe.UserAttribute* pointer;
    public Unsafe.UserAttribute* Pointer
    {
        get
        {
            ThrowIfNull();
            return pointer;
        }
    }

    internal UserAttribute(SlangReflectionUserAttribute* pointer) : this((Unsafe.UserAttribute*)pointer) { }
    internal UserAttribute(Unsafe.UserAttribute* pointer) => this.pointer = pointer;

    internal void ThrowIfNull()
    {
        if (pointer == null)
            throw new NullReferenceException("This instance of UserAttribute has a null pointer");
    }

    public bool Equals(UserAttribute other) => pointer == other.pointer;
    public override bool Equals(object obj) => obj is UserAttribute other && Equals(other);
    public static bool operator ==(UserAttribute a, UserAttribute b) => a.pointer == b.pointer;
    public static bool operator !=(UserAttribute a, UserAttribute b) => a.pointer != b.pointer;
    public override int GetHashCode() => new IntPtr(pointer).GetHashCode();
}
