using System;
using System.Runtime.InteropServices;
using System.Threading;
using SlangNet.Unsafe;

namespace SlangNet;

internal unsafe class ArrayBlob : COMProxy<ISlangBlob, ISlangBlob.Vtbl>, IDisposable
{
    private readonly GCHandle arrayHandle;
    private readonly byte* pointer;
    private readonly UIntPtr size;
    private bool disposedValue;

    private static readonly ISlangBlob._getBufferPointer GetBufferPointerDelegate = GetBufferPointer;
    private static readonly ISlangBlob._getBufferSize GetBufferSizeDelegate = GetBufferSize;
    private static readonly IntPtr GetBufferPointerFnPtr = Marshal.GetFunctionPointerForDelegate(GetBufferPointerDelegate);
    private static readonly IntPtr GetBufferSizeFnPtr = Marshal.GetFunctionPointerForDelegate(GetBufferSizeDelegate);
    private static ISlangBlob.Vtbl VTable = new()
    {
        queryInterface = COMProxy.QueryInterfaceFnPtr,
        addRef = COMProxy.AddRefFnPtr,
        release = COMProxy.ReleaseFnPtr,
        getBufferPointer = GetBufferPointerFnPtr,
        getBufferSize = GetBufferSizeFnPtr
    };

    public ArrayBlob(byte[] array) : base(ref VTable)
    {
        arrayHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
        pointer = (byte*)arrayHandle.AddrOfPinnedObject().ToPointer();
        size = new((ulong)array.LongLength);
    }

    private static void* GetBufferPointer(ISlangBlob* pThis) =>
        GetFromPointer<ArrayBlob>(pThis).pointer;

    private static UIntPtr GetBufferSize(ISlangBlob* pThis) =>
        GetFromPointer<ArrayBlob>(pThis).size;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
                arrayHandle.Free();
            disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
