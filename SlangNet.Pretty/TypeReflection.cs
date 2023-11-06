using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SlangNet.Unsafe;
using static SlangNet.Unsafe.Slang;

namespace SlangNet;

public unsafe readonly partial struct TypeReflection : IEquatable<TypeReflection>
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
    internal SlangReflectionType* InternalPointer => (SlangReflectionType*)Pointer;

    internal TypeReflection(SlangReflectionType* pointer) : this((Unsafe.TypeReflection*)pointer) { }
    internal TypeReflection(Unsafe.TypeReflection* pointer)
    {
        this.pointer = pointer;
        UserAttributes = new NativeBoundedReadOnlyList<SlangReflectionType, UserAttribute>
        {
            Container = InternalPointer,
            GetCount = &GetUserAttributeCount,
            TryGetAt = &TryGetUserAttributeAt
        };
        Fields = new NativeBoundedReadOnlyList<SlangReflectionType, VariableReflection>
        {
            Container = InternalPointer,
            GetCount = &GetFieldCount,
            TryGetAt = &TryGetFieldAt
        };
        SpecializedTypeArgTypes = new NativeBoundedReadOnlyList<SlangReflectionType, TypeReflection?>
        {
            Container = InternalPointer,
            GetCount = &ReflectionType_getSpecializedTypeArgCount,
            TryGetAt = &TryGetSpecializedTypeArgTypeAt
        };
    }

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

    public TypeKind Kind => (TypeKind)ReflectionType_GetKind(InternalPointer);
    public IReadOnlyList<UserAttribute> UserAttributes { get; }
    public IReadOnlyList<VariableReflection> Fields { get; }

    private static long GetUserAttributeCount(SlangReflectionType* type) =>
        ReflectionType_GetUserAttributeCount(type);

    private static bool TryGetUserAttributeAt(SlangReflectionType* type, long index, ref UserAttribute attribute)
    {
        var ptr = ReflectionType_GetUserAttribute(type, checked((uint)index));
        attribute = new UserAttribute(ptr);
        return ptr != null;
    }

    public UserAttribute? FindUserAttributeByName(ReadOnlySpan<byte> name)
    {
        SlangReflectionUserAttribute* attributePtr = null;
        fixed (byte* namePtr = name)
            attributePtr = ReflectionType_FindUserAttributeByName(InternalPointer, (sbyte*)namePtr);
        return attributePtr == null ? null : new(attributePtr);
    }

    public UserAttribute? FindUserAttributeByName(string name)
    {
        using var nameStr = new Utf8String(name);
        var attributePtr = ReflectionType_FindUserAttributeByName(InternalPointer, nameStr);
        return attributePtr == null ? null : new(attributePtr);
    }

    public UserAttribute GetUserAttributeByName(ReadOnlySpan<byte> name) =>
        FindUserAttributeByName(name) ??
        throw new KeyNotFoundException($"No user attribute found with name: {Encoding.UTF8.GetString(name.ToArray())}");

    public UserAttribute GetUserAttributeByName(string name) =>
        FindUserAttributeByName(name) ??
        throw new KeyNotFoundException($"No user attribute found with name: {name}");

    private static long GetFieldCount(SlangReflectionType* type) =>
        ReflectionType_GetFieldCount(type);

    private static bool TryGetFieldAt(SlangReflectionType* type, long index, ref VariableReflection variable)
    {
        var ptr = ReflectionType_GetFieldByIndex(type, checked((uint)index));
        variable = new VariableReflection(ptr);
        return ptr != null;
    }

    public ulong ElementCount => ReflectionType_GetElementCount(InternalPointer).ToUInt64();

    public TypeReflection? ElementType
    {
        get
        {
            var ptr = ReflectionType_GetElementType(InternalPointer);
            return ptr == null ? null : new(ptr);
        }
    }

    public uint RowCount => ReflectionType_GetRowCount(InternalPointer);
    public uint ColumnCount => ReflectionType_GetColumnCount(InternalPointer);
    public ScalarType ScalarType => (ScalarType)ReflectionType_GetScalarType(InternalPointer);
    public ResourceAccess ResourceAccess => (ResourceAccess)ReflectionType_GetResourceAccess(InternalPointer);
    public ResourceShape ResourceShape => (ResourceShape)ReflectionType_GetResourceShape(InternalPointer);
    
    public TypeReflection? ResourceResultType
    {
        get
        {
            var ptr = ReflectionType_GetResourceResultType(InternalPointer);
            return ptr == null ? null : new(ptr);
        }
    }

    public string? Name => InteropUtils.PtrToStringUTF8(ReflectionType_GetName(InternalPointer));

    private static uint GetSpecializedTypeArgCount(SlangReflectionType* type) =>
        checked((uint)ReflectionType_getSpecializedTypeArgCount(type));

    // this is weird in the Slang API, for now we have a list for the types with null elements for future non-types
    // but for anything further we have to wait for the changes in the Slang API

    private static bool TryGetSpecializedTypeArgTypeAt(SlangReflectionType* type, long index, ref TypeReflection? arg)
    {
        var ptr = ReflectionType_getSpecializedTypeArgType(type, index);
        arg = ptr == null ? null : new(ptr);
        return true;
    }

    public IReadOnlyList<TypeReflection?> SpecializedTypeArgTypes { get; }
}
