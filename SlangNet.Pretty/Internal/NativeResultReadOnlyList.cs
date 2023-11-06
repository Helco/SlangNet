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
