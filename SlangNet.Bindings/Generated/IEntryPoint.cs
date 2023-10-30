using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='IEntryPoint.xml' path='doc/member[@name="IEntryPoint"]/*' />
[NativeTypeName("struct IEntryPoint : slang::IComponentType")]
public unsafe partial struct IEntryPoint
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(IEntryPoint* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(IEntryPoint* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(IEntryPoint* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::ISession *")]
    public delegate ISession* _getSession(IEntryPoint* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::ProgramLayout *")]
    public delegate ShaderReflection* _getLayout(IEntryPoint* pThis, [NativeTypeName("SlangInt")] long targetIndex = 0, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangInt")]
    public delegate long _getSpecializationParamCount(IEntryPoint* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getEntryPointCode(IEntryPoint* pThis, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, [NativeTypeName("IBlob **")] ISlangBlob** outCode, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getResultAsFileSystem(IEntryPoint* pThis, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, ISlangMutableFileSystem** outFileSystem);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _getEntryPointHash(IEntryPoint* pThis, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, [NativeTypeName("IBlob **")] ISlangBlob** outHash);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _specialize(IEntryPoint* pThis, [NativeTypeName("const SpecializationArg *")] SpecializationArg* specializationArgs, [NativeTypeName("SlangInt")] long specializationArgCount, IComponentType** outSpecializedComponentType, ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _link(IEntryPoint* pThis, IComponentType** outLinkedComponentType, ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getEntryPointHostCallable(IEntryPoint* pThis, int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary, [NativeTypeName("slang::IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _renameEntryPoint(IEntryPoint* pThis, [NativeTypeName("const char *")] sbyte* newName, IComponentType** outEntryPoint);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (IEntryPoint* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (IEntryPoint* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (IEntryPoint* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <inheritdoc cref="IComponentType.getSession" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::ISession *")]
    public ISession* getSession()
    {
        fixed (IEntryPoint* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getSession>(lpVtbl->getSession)(pThis);
        }
    }

    /// <inheritdoc cref="IComponentType.getLayout" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::ProgramLayout *")]
    public ShaderReflection* getLayout([NativeTypeName("SlangInt")] long targetIndex = 0, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (IEntryPoint* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getLayout>(lpVtbl->getLayout)(pThis, targetIndex, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.getSpecializationParamCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangInt")]
    public long getSpecializationParamCount()
    {
        fixed (IEntryPoint* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getSpecializationParamCount>(lpVtbl->getSpecializationParamCount)(pThis);
        }
    }

    /// <inheritdoc cref="IComponentType.getEntryPointCode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getEntryPointCode([NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, [NativeTypeName("IBlob **")] ISlangBlob** outCode, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (IEntryPoint* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryPointCode>(lpVtbl->getEntryPointCode)(pThis, entryPointIndex, targetIndex, outCode, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.getResultAsFileSystem" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getResultAsFileSystem([NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, ISlangMutableFileSystem** outFileSystem)
    {
        fixed (IEntryPoint* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getResultAsFileSystem>(lpVtbl->getResultAsFileSystem)(pThis, entryPointIndex, targetIndex, outFileSystem);
        }
    }

    /// <inheritdoc cref="IComponentType.getEntryPointHash" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void getEntryPointHash([NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, [NativeTypeName("IBlob **")] ISlangBlob** outHash)
    {
        fixed (IEntryPoint* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_getEntryPointHash>(lpVtbl->getEntryPointHash)(pThis, entryPointIndex, targetIndex, outHash);
        }
    }

    /// <inheritdoc cref="IComponentType.specialize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int specialize([NativeTypeName("const SpecializationArg *")] SpecializationArg* specializationArgs, [NativeTypeName("SlangInt")] long specializationArgCount, IComponentType** outSpecializedComponentType, ISlangBlob** outDiagnostics = null)
    {
        fixed (IEntryPoint* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_specialize>(lpVtbl->specialize)(pThis, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.link" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int link(IComponentType** outLinkedComponentType, ISlangBlob** outDiagnostics = null)
    {
        fixed (IEntryPoint* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_link>(lpVtbl->link)(pThis, outLinkedComponentType, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.getEntryPointHostCallable" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getEntryPointHostCallable(int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary, [NativeTypeName("slang::IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (IEntryPoint* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryPointHostCallable>(lpVtbl->getEntryPointHostCallable)(pThis, entryPointIndex, targetIndex, outSharedLibrary, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.renameEntryPoint" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int renameEntryPoint([NativeTypeName("const char *")] sbyte* newName, IComponentType** outEntryPoint)
    {
        fixed (IEntryPoint* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_renameEntryPoint>(lpVtbl->renameEntryPoint)(pThis, newName, outEntryPoint);
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

        [NativeTypeName("ISession *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getSession;

        [NativeTypeName("ProgramLayout *(SlangInt, IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getLayout;

        [NativeTypeName("SlangInt () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getSpecializationParamCount;

        [NativeTypeName("SlangResult (SlangInt, SlangInt, IBlob **, IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryPointCode;

        [NativeTypeName("SlangResult (SlangInt, SlangInt, ISlangMutableFileSystem **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getResultAsFileSystem;

        [NativeTypeName("void (SlangInt, SlangInt, IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryPointHash;

        [NativeTypeName("SlangResult (const SpecializationArg *, SlangInt, IComponentType **, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr specialize;

        [NativeTypeName("SlangResult (IComponentType **, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr link;

        [NativeTypeName("SlangResult (int, int, ISlangSharedLibrary **, slang::IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryPointHostCallable;

        [NativeTypeName("SlangResult (const char *, IComponentType **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr renameEntryPoint;
    }
}
