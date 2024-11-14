using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='ISlangProfiler.xml' path='doc/member[@name="ISlangProfiler"]/*' />
[NativeTypeName("struct ISlangProfiler : ISlangUnknown")]
public unsafe partial struct ISlangProfiler
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISlangProfiler* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISlangProfiler* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISlangProfiler* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("size_t")]
    public delegate UIntPtr _getEntryCount(ISlangProfiler* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const char *")]
    public delegate sbyte* _getEntryName(ISlangProfiler* pThis, [NativeTypeName("uint32_t")] uint index);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("long")]
    public delegate int _getEntryTimeMS(ISlangProfiler* pThis, [NativeTypeName("uint32_t")] uint index);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _getEntryInvocationTimes(ISlangProfiler* pThis, [NativeTypeName("uint32_t")] uint index);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISlangProfiler* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISlangProfiler* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISlangProfiler* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='ISlangProfiler.xml' path='doc/member[@name="ISlangProfiler.getEntryCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("size_t")]
    public UIntPtr getEntryCount()
    {
        fixed (ISlangProfiler* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryCount>(lpVtbl->getEntryCount)(pThis);
        }
    }

    /// <include file='ISlangProfiler.xml' path='doc/member[@name="ISlangProfiler.getEntryName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const char *")]
    public sbyte* getEntryName([NativeTypeName("uint32_t")] uint index)
    {
        fixed (ISlangProfiler* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryName>(lpVtbl->getEntryName)(pThis, index);
        }
    }

    /// <include file='ISlangProfiler.xml' path='doc/member[@name="ISlangProfiler.getEntryTimeMS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("long")]
    public int getEntryTimeMS([NativeTypeName("uint32_t")] uint index)
    {
        fixed (ISlangProfiler* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryTimeMS>(lpVtbl->getEntryTimeMS)(pThis, index);
        }
    }

    /// <include file='ISlangProfiler.xml' path='doc/member[@name="ISlangProfiler.getEntryInvocationTimes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint getEntryInvocationTimes([NativeTypeName("uint32_t")] uint index)
    {
        fixed (ISlangProfiler* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryInvocationTimes>(lpVtbl->getEntryInvocationTimes)(pThis, index);
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

        [NativeTypeName("size_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryCount;

        [NativeTypeName("const char *(uint32_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryName;

        [NativeTypeName("long (uint32_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryTimeMS;

        [NativeTypeName("uint32_t (uint32_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryInvocationTimes;
    }
}
