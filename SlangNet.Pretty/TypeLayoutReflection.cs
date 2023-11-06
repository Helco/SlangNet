using System;
using System.Collections.Generic;
using SlangNet.Unsafe;
using static SlangNet.Unsafe.Slang;

namespace SlangNet;

public unsafe readonly partial struct TypeLayoutReflection : IEquatable<TypeLayoutReflection>
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
    private SlangReflectionTypeLayout* InternalPointer => (SlangReflectionTypeLayout*)Pointer;

    internal TypeLayoutReflection(SlangReflectionTypeLayout* pointer) : this((Unsafe.TypeLayoutReflection*)pointer) { }
    internal TypeLayoutReflection(Unsafe.TypeLayoutReflection* pointer)
    {
        this.pointer = pointer;
        Fields = new NativeBoundedReadOnlyList<SlangReflectionTypeLayout, VariableLayoutReflection>
        {
            Container = InternalPointer,
            GetCount = &GetFieldCount,
            TryGetAt = &TryGetFieldAt
        };
        Categories = new NativeBoundedReadOnlyList<SlangReflectionTypeLayout, ParameterCategory>
        {
            Container = InternalPointer,
            GetCount = &GetCategoryCount,
            TryGetAt = &TryGetCategoryAt
        };
        BindingRanges = new NativeBoundedReadOnlyList<SlangReflectionTypeLayout, BindingRange>
        {
            Container = InternalPointer,
            GetCount = &ReflectionTypeLayout_getBindingRangeCount,
            TryGetAt = &TryGetBindingRangeAt
        };
        DescriptorSets = new NativeBoundedReadOnlyList<SlangReflectionTypeLayout, DescriptorSet>
        {
            Container = InternalPointer,
            GetCount = &ReflectionTypeLayout_getDescriptorSetCount,
            TryGetAt = &TryGetDescriptorSetAt
        };
    }

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

    public TypeReflection Type
    {
        get
        {
            var ptr = ReflectionTypeLayout_GetType(InternalPointer);
            if (ptr == null)
                throw new SlangException($"{nameof(ReflectionTypeLayout_GetType)} returned a null pointer");
            return new TypeReflection(ptr);
        }
    }

    public TypeKind Kind => (TypeKind)ReflectionTypeLayout_getKind(InternalPointer);

    public ulong GetSize(ParameterCategory category) =>
        ReflectionTypeLayout_GetSize(InternalPointer, (SlangParameterCategory)category).ToUInt64();

    public ulong GetStride(ParameterCategory category) =>
        ReflectionTypeLayout_GetStride(InternalPointer, (SlangParameterCategory)category).ToUInt64();

    public int GetAlignment(ParameterCategory category) =>
        ReflectionTypeLayout_getAlignment(InternalPointer, (SlangParameterCategory)category);

    public ulong GetElementStride(ParameterCategory category) =>
        ReflectionTypeLayout_GetElementStride(InternalPointer, (SlangParameterCategory)category).ToUInt64();

    private static long GetFieldCount(SlangReflectionTypeLayout* internalPointer)
    {
        var typePtr = ReflectionTypeLayout_GetType(internalPointer);
        return ReflectionType_GetFieldCount(typePtr);
    }

    private static bool TryGetFieldAt(SlangReflectionTypeLayout* internalPointer, long index, ref VariableLayoutReflection variable)
    {
        var ptr = ReflectionTypeLayout_GetFieldByIndex(internalPointer, checked((uint)index));
        variable = ptr == null ? default : new(ptr);
        return ptr != null;
    }

    public IReadOnlyList<VariableLayoutReflection> Fields { get; }

    public long FindFieldIndexByName(ReadOnlySpan<byte> name)
    {
        fixed (byte* namePtr = name)
            return ReflectionTypeLayout_findFieldIndexByName(InternalPointer,
                (sbyte*)namePtr, (sbyte*)namePtr + name.Length);
    }

    public long FindFieldIndexByName(string name)
    {
        using var nameStr = new Utf8String(name);
        return ReflectionTypeLayout_findFieldIndexByName(InternalPointer, nameStr, nameStr.MemoryEnd);
    }

    public long GetFieldBindingRangeOffset(long fieldIndex) =>
        ReflectionTypeLayout_getFieldBindingRangeOffset(InternalPointer, fieldIndex);

    public VariableLayoutReflection? ExplicitCounter
    {
        get
        {
            var ptr = ReflectionTypeLayout_GetExplicitCounter(InternalPointer);
            return ptr == null ? null : new(ptr);
        }
    }

    public long ExplicitCounterBindingRangeOffset =>
        ReflectionTypeLayout_getExplicitCounterBindingRangeOffset(InternalPointer);

    public TypeLayoutReflection? ElementTypeLayout
    {
        get
        {
            var ptr = ReflectionTypeLayout_GetElementTypeLayout(InternalPointer);
            return ptr == null ? null : new(ptr);
        }
    }

    public VariableLayoutReflection? ElementVarLayout
    {
        get
        {
            var ptr = ReflectionTypeLayout_GetElementVarLayout(InternalPointer);
            return ptr == null ? null : new(ptr);
        }
    }

    public VariableLayoutReflection? ContainerVarLayout
    {
        get
        {
            var ptr = ReflectionTypeLayout_getContainerVarLayout(InternalPointer);
            return ptr == null ? null : new(ptr);
        }
    }

    public ParameterCategory ParameterCategory =>
        (ParameterCategory)ReflectionTypeLayout_GetParameterCategory(InternalPointer);

    private static long GetCategoryCount(SlangReflectionTypeLayout* type) =>
        ReflectionTypeLayout_GetCategoryCount(type);

    private static bool TryGetCategoryAt(SlangReflectionTypeLayout* type, long index, ref ParameterCategory category)
    {
        category = (ParameterCategory)ReflectionTypeLayout_GetCategoryByIndex(type, checked((uint)index));
        return true;
    }

    public IReadOnlyList<ParameterCategory> Categories { get; }

    public MatrixLayoutMode MatrixLayoutMode =>
        (MatrixLayoutMode)ReflectionTypeLayout_GetMatrixLayoutMode(InternalPointer);

    public int GenericParamIndex =>
        ReflectionTypeLayout_getGenericParamIndex(InternalPointer);

    public TypeLayoutReflection? PendingDataTypeLayout
    {
        get
        {
            var ptr = ReflectionTypeLayout_getPendingDataTypeLayout(InternalPointer);
            return ptr == null ? null : new(ptr);
        }
    }

    public VariableLayoutReflection? SpecializedTypePendingDataVarLayout
    {
        get
        {
            var ptr = ReflectionTypeLayout_getSpecializedTypePendingDataVarLayout(InternalPointer);
            return ptr == null ? null : new(ptr);
        }
    }

    private static bool TryGetBindingRangeAt(SlangReflectionTypeLayout* type, long index, ref BindingRange bindingRange)
    {
        bindingRange = new(type, index);
        return true;
    }

    public IReadOnlyList<BindingRange> BindingRanges { get; }

    private static bool TryGetDescriptorSetAt(SlangReflectionTypeLayout* type, long index, ref DescriptorSet descriptorSet)
    {
        descriptorSet = new(type, index);
        return true;
    }

    public IReadOnlyList<DescriptorSet> DescriptorSets { get; }
}