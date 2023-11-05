using System;
using System.Collections.Generic;
using System.Text;
using SlangNet.Unsafe;
using static SlangNet.Unsafe.Slang;

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
    internal SlangReflectionUserAttribute* InternalPointer => (SlangReflectionUserAttribute*)Pointer;

    internal UserAttribute(SlangReflectionUserAttribute* pointer) : this((Unsafe.UserAttribute*)pointer) { }
    internal UserAttribute(Unsafe.UserAttribute* pointer)
    {
        this.pointer = pointer;
        Arguments = new NativeBoundedReadOnlyList<SlangReflectionUserAttribute, UserAttributeArgument>
        {
            Container = InternalPointer,
            GetCount = ReflectionUserAttribute_GetArgumentCount,
            TryGetAt = TryGetArgumentAt
        };
    }

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

    public string? Name => InteropUtils.PtrToStringUTF8(ReflectionUserAttribute_GetName(InternalPointer));
    public IReadOnlyList<UserAttributeArgument> Arguments { get; }

    private static bool TryGetArgumentAt(SlangReflectionUserAttribute* container, uint index, out UserAttributeArgument element)
    {
        element = new UserAttributeArgument
        {
            InternalPointer = container,
            Index = index
        };
        return true;
    }
}

[GenerateThrowingMethods]
public unsafe readonly partial struct UserAttributeArgument : IEquatable<UserAttributeArgument>
{
    internal SlangReflectionUserAttribute* InternalPointer { get; init; }
    public uint Index { get; internal init; }

    public bool Equals(UserAttributeArgument arg) => InternalPointer == arg.InternalPointer && Index == arg.Index;
    public override bool Equals(object? obj) => obj is UserAttributeArgument arg && Equals(arg);
    public override int GetHashCode() => InteropUtils.CombineHash(new IntPtr(InternalPointer), Index);
    public static bool operator ==(UserAttributeArgument left, UserAttributeArgument right) => left.Equals(right);
    public static bool operator !=(UserAttributeArgument left, UserAttributeArgument right) => !(left == right);

    public SlangResult TryAsInt(out int value)
    {
        SlangResult result;
        fixed (int* valuePtr = &value)
            result = new(ReflectionUserAttribute_GetArgumentValueInt(InternalPointer, Index, valuePtr));
        return result;
    }

    public SlangResult TryAsFloat(out float value)
    {
        SlangResult result;
        fixed (float* valuePtr = &value)
            result = new(ReflectionUserAttribute_GetArgumentValueFloat(InternalPointer, Index, valuePtr));
        return result;
    }

    public string? TryAsString()
    {
        UIntPtr size = UIntPtr.Zero;
        var data = ReflectionUserAttribute_GetArgumentValueString(InternalPointer, Index, &size);
        if (data == null)
            return null;
        return Encoding.UTF8.GetString((byte*)data, checked((int)size.ToUInt64()));
    }

    public string AsString() =>
        TryAsString() ??
        throw new SlangException("User attribute argument cannot be returned as string");
}
