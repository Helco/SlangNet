using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='ISlangClonable.xml' path='doc/member[@name="ISlangClonable"]/*' />
[NativeTypeName("struct ISlangClonable : ISlangCastable")]
public unsafe partial struct ISlangClonable
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISlangClonable* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISlangClonable* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISlangClonable* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void* _castAs(ISlangClonable* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* guid);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void* _clone(ISlangClonable* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* guid);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISlangClonable* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISlangClonable* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISlangClonable* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangCastable.castAs" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void* castAs([NativeTypeName("const SlangUUID &")] SlangUUID* guid)
    {
        fixed (ISlangClonable* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_castAs>(lpVtbl->castAs)(pThis, guid);
        }
    }

    /// <include file='ISlangClonable.xml' path='doc/member[@name="ISlangClonable.clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void* clone([NativeTypeName("const SlangUUID &")] SlangUUID* guid)
    {
        fixed (ISlangClonable* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_clone>(lpVtbl->clone)(pThis, guid);
        }
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr release;

        [NativeTypeName("void *(const SlangUUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr castAs;

        [NativeTypeName("void *(const SlangUUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr clone;
    }
}
