using System;
using System.Collections;
using System.Collections.Generic;

namespace SlangNet;

internal class IndexEnumerator<T> : IEnumerator<T>
{
    private readonly IReadOnlyList<T> list;
    private readonly int count; // we cache to save native calls
    private T? current = default(T?);
    private int index = -1;

    public IndexEnumerator(IReadOnlyList<T> list)
    {
        this.list = list;
        count = list.Count;
    }

    public T Current => current ?? default!;
    object IEnumerator.Current => Current!;

    public bool MoveNext()
    {
        ResetCurrent();
        if (++index >= count)
            return false;
        current = list[index];
        return true;
    }

    public void Reset()
    {
        ResetCurrent();
        index = -1;
    }

    private void ResetCurrent()
    {
        if (EqualityComparer<T?>.Default.Equals(current, default(T?)))
            return;
        if (Current is IDisposable disposable)
            disposable?.Dispose();
        current = default(T?);
    }

    public void Dispose() => ResetCurrent();
}
