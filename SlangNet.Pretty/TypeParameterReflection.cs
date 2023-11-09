using System;
using System.Collections.Generic;
using SlangNet.Unsafe;
using static SlangNet.Unsafe.Slang;

namespace SlangNet;

public unsafe readonly struct TypeParameterReflection : IEquatable<TypeParameterReflection>
{
    private readonly Unsafe.TypeParameterReflection* pointer;
    public Unsafe.TypeParameterReflection* Pointer
    {
        get
        {
            ThrowIfNull();
            return pointer;
        }
    }
    internal SlangReflectionTypeParameter* InternalPointer => (SlangReflectionTypeParameter*)Pointer;

    internal TypeParameterReflection(SlangReflectionTypeParameter* pointer) : this((Unsafe.TypeParameterReflection*)pointer) {}
    internal TypeParameterReflection(Unsafe.TypeParameterReflection* pointer)
    {
        this.pointer = pointer;
        Constraints = new NativeBoundedReadOnlyList<SlangReflectionTypeParameter, TypeReflection>
        {
            Container = InternalPointer,
            GetCount = &GetConstraintCount,
            TryGetAt = &TryGetConstraintAt
        };
    }

    internal void ThrowIfNull()
    {
        if (pointer == null)
            throw new NullReferenceException("This instance of TypeParameterReflection has a null pointer");
    }

    public bool Equals(TypeParameterReflection other) => pointer == other.pointer;
    public override bool Equals(object obj) => obj is TypeParameterReflection other && Equals(other);
    public static bool operator ==(TypeParameterReflection a, TypeParameterReflection b) => a.pointer == b.pointer;
    public static bool operator !=(TypeParameterReflection a, TypeParameterReflection b) => a.pointer != b.pointer;
    public override int GetHashCode() => new IntPtr(pointer).GetHashCode();

    public string? Name => InteropUtils.PtrToStringUTF8(ReflectionTypeParameter_GetName(InternalPointer));

    public uint Index => ReflectionTypeParameter_GetIndex(InternalPointer);

    private static long GetConstraintCount(SlangReflectionTypeParameter* param) =>
        ReflectionTypeParameter_GetConstraintCount(param);

    private static bool TryGetConstraintAt(SlangReflectionTypeParameter* param, long index, ref TypeReflection constraint)
    {
        var ptr = ReflectionTypeParameter_GetConstraintByIndex(param, checked((uint)index));
        constraint = ptr == null ? default : new(ptr);
        return ptr != null;
    }

    public IReadOnlyList<TypeReflection> Constraints { get; }
}
