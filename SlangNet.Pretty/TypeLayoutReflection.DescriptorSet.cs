using System;
using System.Collections.Generic;
using SlangNet.Unsafe;
using static SlangNet.Unsafe.Slang;

namespace SlangNet;

unsafe partial struct TypeLayoutReflection
{
    public readonly struct DescriptorSet : IEquatable<DescriptorSet>
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

        internal DescriptorSet(SlangReflectionTypeLayout* pointer, long index)
        {
            this.pointer = pointer;
            Index = index;
            Ranges = new NativeBoundedReadOnlyList<SlangReflectionTypeLayout, long, DescriptorRange>
            {
                Container = pointer,
                Argument = Index,
                GetCount = &ReflectionTypeLayout_getDescriptorSetDescriptorRangeCount,
                TryGetAt = &TryGetRangeAt
            };
        }

        internal void ThrowIfNull()
        {
            if (pointer == null)
                throw new NullReferenceException("This instance of TypeLayoutReflection.DescriptorSet has a null pointer");
        }

        public bool Equals(DescriptorSet other) => pointer == other.pointer && Index == other.Index;
        public override bool Equals(object obj) => obj is DescriptorSet other && Equals(other);
        public static bool operator ==(DescriptorSet a, DescriptorSet b) => a.Equals(b);
        public static bool operator !=(DescriptorSet a, DescriptorSet b) => !a.Equals(b);
        public override int GetHashCode() => InteropUtils.CombineHash(new IntPtr(pointer), Index);

        public long SpaceOffset =>
            ReflectionTypeLayout_getDescriptorSetSpaceOffset(Pointer, Index);

        private static bool TryGetRangeAt(SlangReflectionTypeLayout* type, long setIndex, long rangeIndex, ref DescriptorRange range)
        {
            range = new(type, setIndex, rangeIndex);
            return true;
        }

        public IReadOnlyList<DescriptorRange> Ranges { get; }
    }
}