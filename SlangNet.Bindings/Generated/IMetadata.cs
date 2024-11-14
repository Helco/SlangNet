using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='IMetadata.xml' path='doc/member[@name="IMetadata"]/*' />
[NativeTypeName("struct IMetadata : ISlangCastable")]
public unsafe partial struct IMetadata
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(IMetadata* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(IMetadata* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(IMetadata* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void* _castAs(IMetadata* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* guid);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _isParameterLocationUsed(IMetadata* pThis, SlangParameterCategory category, [NativeTypeName("SlangUInt")] ulong spaceIndex, [NativeTypeName("SlangUInt")] ulong registerIndex, [NativeTypeName("bool &")] bool* outUsed);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (IMetadata* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (IMetadata* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (IMetadata* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangCastable.castAs" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void* castAs([NativeTypeName("const SlangUUID &")] SlangUUID* guid)
    {
        fixed (IMetadata* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_castAs>(lpVtbl->castAs)(pThis, guid);
        }
    }

    /// <include file='IMetadata.xml' path='doc/member[@name="IMetadata.isParameterLocationUsed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int isParameterLocationUsed(SlangParameterCategory category, [NativeTypeName("SlangUInt")] ulong spaceIndex, [NativeTypeName("SlangUInt")] ulong registerIndex, [NativeTypeName("bool &")] bool* outUsed)
    {
        fixed (IMetadata* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_isParameterLocationUsed>(lpVtbl->isParameterLocationUsed)(pThis, category, spaceIndex, registerIndex, outUsed);
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

        [NativeTypeName("SlangResult (SlangParameterCategory, SlangUInt, SlangUInt, bool &)")]
        public IntPtr isParameterLocationUsed;
    }
}
