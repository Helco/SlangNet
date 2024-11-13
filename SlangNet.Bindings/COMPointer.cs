using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

[StructLayout(LayoutKind.Sequential)] // TODO: Add tests for alignment and size
public unsafe struct COMPointer<T> : IDisposable where T : unmanaged
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
