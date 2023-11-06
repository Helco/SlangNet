using System;
using SlangNet.Unsafe;
using static SlangNet.Unsafe.Slang;

namespace SlangNet;

unsafe partial struct TypeLayoutReflection
{
    public readonly struct BindingRange : IEquatable<BindingRange>
    {
        private readonly SlangReflectionTypeLayout* pointer;
        public SlangReflectionTypeLayout* Pointer
        {
            get
            {
                ThrowIfNull();
                return pointer;
            }
        }
        public long Index { get; }

        internal BindingRange(SlangReflectionTypeLayout* pointer, long index)
        {
            this.pointer = pointer;
            Index = index;
        }

        internal void ThrowIfNull()
        {
            if (pointer == null)
                throw new NullReferenceException("This instance of TypeLayoutReflection.BindingRange has a null pointer");
        }

        public bool Equals(BindingRange other) => pointer == other.pointer && Index == other.Index;
        public override bool Equals(object obj) => obj is BindingRange other && Equals(other);
        public static bool operator ==(BindingRange a, BindingRange b) => a.Equals(b);
        public static bool operator !=(BindingRange a, BindingRange b) => !a.Equals(b);
        public override int GetHashCode() => InteropUtils.CombineHash(new IntPtr(pointer), Index);

        public BindingType BindingRangeType =>
            (BindingType)ReflectionTypeLayout_getBindingRangeType(Pointer, Index);

        public long BindingCount =>
            ReflectionTypeLayout_getBindingRangeBindingCount(Pointer, Index);

        public TypeLayoutReflection? LeafTypeLayout
        {
            get
            {
                var ptr = ReflectionTypeLayout_getBindingRangeLeafTypeLayout(Pointer, Index);
                return ptr == null ? null : new(ptr);
            }
        }

        public VariableReflection? LeafVariable
        {
            get
            {
                var ptr = ReflectionTypeLayout_getBindingRangeLeafVariable(Pointer, Index);
                return ptr == null ? null : new(ptr);
            }
        }

        public long DescriptorSetIndex =>
            ReflectionTypeLayout_getBindingRangeDescriptorSetIndex(Pointer, Index);

        public long FirstDescriptorRangeIndex =>
            ReflectionTypeLayout_getBindingRangeFirstDescriptorRangeIndex(Pointer, Index);

        public long DescriptorRangeCount =>
            ReflectionTypeLayout_getBindingRangeDescriptorRangeCount(Pointer, Index);
    }
}
