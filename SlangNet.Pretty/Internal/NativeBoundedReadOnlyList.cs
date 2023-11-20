using System;
using System.Collections;
using System.Collections.Generic;

namespace SlangNet;

// for lists of opaque objects returned as pair of
//   X_getCount
//   Element* getAt
internal unsafe readonly struct NativeBoundedReadOnlyList<TContainer, TElement> : IReadOnlyList<TElement>
    where TContainer : unmanaged
{
    public TContainer* Container { get; init; }
    public delegate* managed<TContainer*, long> GetCount { get; init; }
    public delegate* managed<TContainer*, long, ref TElement, bool> TryGetAt { get; init; }

    public long Count => GetCount(Container);
    int IReadOnlyCollection<TElement>.Count => checked((int)Count);

    public TElement this[int index] => this[(long)index];
    public TElement this[long index]
    {
        get
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException("index");
            TElement element = default!;
            return TryGetAt(Container, index, ref element)
                ? element
                : throw new SlangException("Slang list returned a null pointer");
        }
    }

    public IEnumerator<TElement> GetEnumerator() => new IndexEnumerator<TElement>(this);
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

// and there is one two-dimensional list (TypeLayoutReflection.DescriptorSetDescriptorRange)
internal unsafe readonly struct NativeBoundedReadOnlyList<TContainer, TArgument, TElement> : IReadOnlyList<TElement>
    where TContainer : unmanaged
{
    public TContainer* Container { get; init; }
    public TArgument Argument { get; init; }
    public delegate* managed<TContainer*, TArgument, long> GetCount { get; init; }
    public delegate* managed<TContainer*, TArgument, long, ref TElement, bool> TryGetAt { get; init; }

    public long Count => GetCount(Container, Argument);
    int IReadOnlyCollection<TElement>.Count => checked((int)Count);

    public TElement this[int index] => this[index];
    public TElement this[long index]
    {
        get
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException("index");
            TElement element = default!;
            return TryGetAt(Container, Argument, index, ref element)
                ? element
                : throw new SlangException("Slang list returned a null pointer");
        }
    }

    public IEnumerator<TElement> GetEnumerator() => new IndexEnumerator<TElement>(this);
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
