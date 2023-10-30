using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='ISlangWriter.xml' path='doc/member[@name="ISlangWriter"]/*' />
[NativeTypeName("struct ISlangWriter : ISlangUnknown")]
public unsafe partial struct ISlangWriter
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISlangWriter* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISlangWriter* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISlangWriter* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("char *")]
    public delegate sbyte* _beginAppendBuffer(ISlangWriter* pThis, [NativeTypeName("size_t")] UIntPtr maxNumChars);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _endAppendBuffer(ISlangWriter* pThis, [NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("size_t")] UIntPtr numChars);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _write(ISlangWriter* pThis, [NativeTypeName("const char *")] sbyte* chars, [NativeTypeName("size_t")] UIntPtr numChars);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _flush(ISlangWriter* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangBool")]
    public delegate byte _isConsole(ISlangWriter* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _setMode(ISlangWriter* pThis, SlangWriterMode mode);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISlangWriter* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISlangWriter* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISlangWriter* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='ISlangWriter.xml' path='doc/member[@name="ISlangWriter.beginAppendBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("char *")]
    public sbyte* beginAppendBuffer([NativeTypeName("size_t")] UIntPtr maxNumChars)
    {
        fixed (ISlangWriter* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_beginAppendBuffer>(lpVtbl->beginAppendBuffer)(pThis, maxNumChars);
        }
    }

    /// <include file='ISlangWriter.xml' path='doc/member[@name="ISlangWriter.endAppendBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int endAppendBuffer([NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("size_t")] UIntPtr numChars)
    {
        fixed (ISlangWriter* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_endAppendBuffer>(lpVtbl->endAppendBuffer)(pThis, buffer, numChars);
        }
    }

    /// <include file='ISlangWriter.xml' path='doc/member[@name="ISlangWriter.write"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int write([NativeTypeName("const char *")] sbyte* chars, [NativeTypeName("size_t")] UIntPtr numChars)
    {
        fixed (ISlangWriter* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_write>(lpVtbl->write)(pThis, chars, numChars);
        }
    }

    /// <include file='ISlangWriter.xml' path='doc/member[@name="ISlangWriter.flush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void flush()
    {
        fixed (ISlangWriter* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_flush>(lpVtbl->flush)(pThis);
        }
    }

    /// <include file='ISlangWriter.xml' path='doc/member[@name="ISlangWriter.isConsole"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangBool")]
    public bool isConsole()
    {
        fixed (ISlangWriter* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_isConsole>(lpVtbl->isConsole)(pThis) != 0;
        }
    }

    /// <include file='ISlangWriter.xml' path='doc/member[@name="ISlangWriter.setMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int setMode(SlangWriterMode mode)
    {
        fixed (ISlangWriter* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_setMode>(lpVtbl->setMode)(pThis, mode);
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

        [NativeTypeName("char *(size_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr beginAppendBuffer;

        [NativeTypeName("SlangResult (char *, size_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr endAppendBuffer;

        [NativeTypeName("SlangResult (const char *, size_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr write;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr flush;

        [NativeTypeName("SlangBool () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr isConsole;

        [NativeTypeName("SlangResult (SlangWriterMode) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setMode;
    }
}
