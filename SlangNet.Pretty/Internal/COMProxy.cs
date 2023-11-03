using System;
using System.Runtime.InteropServices;
using System.Threading;
using SlangNet.Unsafe;

namespace SlangNet;

[StructLayout(LayoutKind.Sequential)]
internal struct COMProxyStruct
{
    public ISlangUnknown Unknown;
    public int RefCount;
    public IntPtr ProxyPointer;

    public GCHandle ProxyHandle => GCHandle.FromIntPtr(ProxyPointer);
    public object Proxy => ProxyHandle.Target;
}

internal abstract unsafe class COMProxy<T, TVTable> where T : unmanaged where TVTable : unmanaged
{
    private readonly COMProxyStruct* proxyStruct;
    public T* Pointer => (T*)proxyStruct;

    public COMProxy(ref TVTable vtable)
    {
        proxyStruct = (COMProxyStruct*)Marshal.AllocCoTaskMem(sizeof(COMProxyStruct));
        proxyStruct->Unknown.lpVtbl = (ISlangUnknown.Vtbl*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref vtable);
        proxyStruct->RefCount = 1;
        proxyStruct->ProxyPointer = GCHandle.ToIntPtr(GCHandle.Alloc(this));
    }

    protected static TManaged GetFromPointer<TManaged>(T* ptr)
    {
        if (ptr == null)
            throw new ArgumentNullException(nameof(ptr));
        var proxyStruct = (COMProxyStruct*)ptr;
        return (TManaged)proxyStruct->Proxy;
    }

    public static implicit operator T*(COMProxy<T, TVTable> proxy) => proxy.Pointer;
}

internal unsafe static class COMProxy
{
    private static readonly ISlangUnknown._queryInterface QueryInterfaceDelegate = QueryInterface;
    private static readonly ISlangUnknown._addRef AddRefDelegate = AddRef;
    private static readonly ISlangUnknown._release ReleaseDelegate = Release;

    public static readonly IntPtr QueryInterfaceFnPtr = Marshal.GetFunctionPointerForDelegate(QueryInterfaceDelegate);
    public static readonly IntPtr AddRefFnPtr = Marshal.GetFunctionPointerForDelegate(AddRefDelegate);
    public static readonly IntPtr ReleaseFnPtr = Marshal.GetFunctionPointerForDelegate(ReleaseDelegate);

    private static unsafe int QueryInterface(ISlangUnknown* pThis, SlangUUID* uuid, void** outObject)
    {
        return SlangResult.NoInterface.RawValue;
    }

    private static unsafe uint AddRef(ISlangUnknown* pThis_)
    {
        var pThis = (COMProxyStruct*)pThis_;
        return (uint)Interlocked.Increment(ref pThis->RefCount);
    }

    private static unsafe uint Release(ISlangUnknown* pThis_)
    {
        var pThis = (COMProxyStruct*)pThis_;
        var newRefCount = Interlocked.Decrement(ref pThis->RefCount);
        if (newRefCount == 0)
        {
            (pThis->Proxy as IDisposable)?.Dispose();
            pThis->ProxyHandle.Free();
            Marshal.FreeCoTaskMem(new(pThis));
        }
        return newRefCount < 0 ? 0 : (uint)newRefCount;
    }
}
