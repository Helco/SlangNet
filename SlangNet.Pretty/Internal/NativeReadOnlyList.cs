using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SlangNet;

// for lists of COM objects returned as pair of
//   X_GetCount
//   SlangResult X_getAt(Container*, index, Element**)
internal abstract class NativeResultReadOnlyList<T> : IReadOnlyList<T>
    where T : class, IDisposable
{
    public abstract int Count { get; }
    public abstract SlangResult TryGetAt(int index, [NotNullWhen(true)] out T? value);

    public T this[int index]
    {
        get
        {
            TryGetAt(index, out var value).ThrowIfFailed();
            return value!;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<T> GetEnumerator() => new IndexEnumerator<T>(this);
}

// for lists of opaque objects returned as pair of
//   X_getCount
//   Element* getAt
internal unsafe readonly struct NativeBoundedReadOnlyList<TContainer, TElement> : IReadOnlyList<TElement>
    where TContainer : unmanaged
{
    public delegate uint GetCountFunc(TContainer* container);
    public delegate bool TryGetAtFunc(TContainer* container, uint index, out TElement element);

    public TContainer* Container { get; init; }
    public GetCountFunc GetCount { get; init; }
    public TryGetAtFunc TryGetAt { get; init; }

    public int Count => checked((int)GetCount(Container));

    public TElement this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException("index");
            return TryGetAt(Container, checked((uint)index), out var element)
                ? element
                : throw new SlangException("Slang list returned a null pointer");
        }
    }

    public IEnumerator<TElement> GetEnumerator() => new IndexEnumerator<TElement>(this);
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
