using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SlangNet;

internal abstract class NativeReadOnlyList<T> : IReadOnlyList<T>
    where T : class, IDisposable
{
    public abstract int Count { get; }
    internal abstract SlangResult TryGetAt(int index, [NotNullWhen(true)] out T? value);

    public T this[int index]
    {
        get
        {
            TryGetAt(index, out var value).ThrowIfFailed();
            return value!;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<T> GetEnumerator() => new Enumerator(this);

    private class Enumerator : IEnumerator<T>
    {
        private readonly NativeReadOnlyList<T> list;
        private readonly int count; // we cache to save native calls
        private int index = -1;

        public Enumerator(NativeReadOnlyList<T> list)
        {
            this.list = list;
            count = list.Count;
        }

        public T Current { get; private set; } = null!;
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            Current?.Dispose();
            Current = null!;
            if (++index >= count)
                return false;
            Current = list[index];
            return true;
        }

        public void Reset()
        {
            Current?.Dispose();
            Current = null!;
            index = -1;
        }

        public void Dispose() { }
    }
}
