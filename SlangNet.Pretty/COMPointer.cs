using System;
using SlangNet.Unsafe;

namespace SlangNet;

internal unsafe struct COMPointer<T> : IDisposable where T : unmanaged
{
    public T* Pointer;

    public static implicit operator T*(COMPointer<T> self) => self.Pointer;

    public void Dispose()
    {
        if (Pointer != null)
        {
            ((ISlangUnknown*)Pointer)->release();
            Pointer = null;
        }    
    }
}
