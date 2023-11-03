using System;
using SlangNet.Unsafe;

namespace SlangNet.Internal;

public class COMObject<T> : IDisposable, IEquatable<COMObject<T>> where T : unmanaged
{
    private unsafe T* pointer;
    private bool disposedValue;

    /// <summary>Returns the raw pointer underneath the wrapper</summary>
    /// <remarks>The reference counter is not incremented</remarks>
    public unsafe T* Pointer
    {
        get
        {
            ThrowIfDisposed();
            return pointer;
        }
    }
    public bool IsDisposed => disposedValue;

    protected internal unsafe COMObject(T* pointer)
    {
        this.pointer = pointer;
        if (pointer == null)
            throw new NullReferenceException("Slang operation returned a null object");
    }

    public unsafe bool Equals(COMObject<T> other) => other == null!
        ? pointer == null
        : other.pointer == pointer;

    public override bool Equals(object obj) => obj is COMObject<T> other && Equals(other);
    public static bool operator ==(COMObject<T> a, COMObject<T> b) => a == null! || b == null!
        ? ReferenceEquals(a, b)
        : a.Equals(b);
    public static bool operator !=(COMObject<T> a, COMObject<T> b) => !(a == b);
    public unsafe override int GetHashCode() => new IntPtr(pointer).GetHashCode();

    protected internal void ThrowIfDisposed()
    {
        if (IsDisposed)
            throw new ObjectDisposedException(GetType().Name);
    }

    private unsafe void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (pointer != null)
            {
                ((ISlangUnknown*)pointer)->release();
                pointer = null;
            }
            disposedValue = true;
        }
    }

    ~COMObject()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
