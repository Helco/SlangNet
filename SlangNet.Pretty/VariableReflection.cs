using System;
using System.Collections.Generic;
using System.Text;
using SlangNet.Unsafe;
using static SlangNet.Unsafe.Slang;

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
    private SlangReflectionVariable* InternalPointer => (SlangReflectionVariable*)Pointer;

    internal VariableReflection(SlangReflectionVariable* pointer) : this((Unsafe.VariableReflection*)pointer) { }
    internal VariableReflection(Unsafe.VariableReflection* pointer)
    {
        this.pointer = pointer;
        UserAttributes = new NativeBoundedReadOnlyList<SlangReflectionVariable, UserAttribute>
        {
            Container = InternalPointer,
            GetCount = ReflectionVariable_GetUserAttributeCount,
            TryGetAt = TryGetUserAttributeAt
        };
    }

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

    public string? Name => InteropUtils.PtrToStringUTF8(ReflectionVariable_GetName(InternalPointer));
    public TypeReflection Type
    {
        get
        {
            var ptr = ReflectionVariable_GetType(InternalPointer);
            if (ptr == null)
                throw new SlangException($"{nameof(ReflectionVariable_GetType)} returned a null pointer");
            return new TypeReflection(ptr);
        }
    }

    // the original API has a FindModifier function, but it has no public API usage
    // in the future we can still add it properly, for now a HasModifier is sufficient

    public bool HasModifier(ModifierID modifierID) =>
        ReflectionVariable_FindModifier(InternalPointer, (SlangModifierID)modifierID) != null;

    public IReadOnlyList<UserAttribute> UserAttributes { get; }

    private static bool TryGetUserAttributeAt(SlangReflectionVariable* type, uint index, out UserAttribute attribute)
    {
        var ptr = ReflectionVariable_GetUserAttribute(type, index);
        attribute = new UserAttribute(ptr);
        return ptr != null;
    }

    public UserAttribute? FindUserAttributeByName(GlobalSession globalSession, ReadOnlySpan<byte> name)
    {
        SlangReflectionUserAttribute* attributePtr = null;
        fixed (byte* namePtr = name)
            attributePtr = ReflectionVariable_FindUserAttributeByName(InternalPointer, globalSession.Pointer, (sbyte*)namePtr);
        return attributePtr == null ? null : new(attributePtr);
    }

    public UserAttribute? FindUserAttributeByName(GlobalSession globalSession, string name)
    {
        using var nameStr = new Utf8String(name);
        var attributePtr = ReflectionVariable_FindUserAttributeByName(InternalPointer, globalSession.Pointer, nameStr);
        return attributePtr == null ? null : new(attributePtr);
    }

    public UserAttribute GetUserAttributeByName(GlobalSession globalSession, ReadOnlySpan<byte> name) =>
        FindUserAttributeByName(globalSession, name) ??
        throw new KeyNotFoundException($"No user attribute found with name: {Encoding.UTF8.GetString(name.ToArray())}");

    public UserAttribute GetUserAttributeByName(GlobalSession globalSession, string name) =>
        FindUserAttributeByName(globalSession, name) ??
        throw new KeyNotFoundException($"No user attribute found with name: {name}");
}