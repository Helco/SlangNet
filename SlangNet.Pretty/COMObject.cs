using System;
using SlangNet.Unsafe;

namespace SlangNet.Internal;

public abstract class COMObject<T> : IDisposable where T : unmanaged
{
    private unsafe T* pointer;
    private bool disposedValue;

    /// <summary>Returns the raw pointer underneath the wrapper</summary>
    /// <remarks>The reference counter is not incremented</remarks>
    public unsafe T* Pointer => pointer;
    public bool IsDisposed => disposedValue;

    protected unsafe COMObject(T* pointer)
    {
        this.pointer = pointer;
        if (pointer == null)
            throw new NullReferenceException("Slang operation returned a null object");
    }

    protected void ThrowIfDisposed()
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
