using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='IModulePrecompileService_Experimental.xml' path='doc/member[@name="IModulePrecompileService_Experimental"]/*' />
[NativeTypeName("struct IModulePrecompileService_Experimental : ISlangUnknown")]
public unsafe partial struct IModulePrecompileService_Experimental
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(IModulePrecompileService_Experimental* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(IModulePrecompileService_Experimental* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(IModulePrecompileService_Experimental* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _precompileForTarget(IModulePrecompileService_Experimental* pThis, SlangCompileTarget target, ISlangBlob** outDiagnostics);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getPrecompiledTargetCode(IModulePrecompileService_Experimental* pThis, SlangCompileTarget target, [NativeTypeName("IBlob **")] ISlangBlob** outCode, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangInt")]
    public delegate long _getModuleDependencyCount(IModulePrecompileService_Experimental* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getModuleDependency(IModulePrecompileService_Experimental* pThis, [NativeTypeName("SlangInt")] long dependencyIndex, IModule** outModule, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (IModulePrecompileService_Experimental* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (IModulePrecompileService_Experimental* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (IModulePrecompileService_Experimental* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='IModulePrecompileService_Experimental.xml' path='doc/member[@name="IModulePrecompileService_Experimental.precompileForTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int precompileForTarget(SlangCompileTarget target, ISlangBlob** outDiagnostics)
    {
        fixed (IModulePrecompileService_Experimental* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_precompileForTarget>(lpVtbl->precompileForTarget)(pThis, target, outDiagnostics);
        }
    }

    /// <include file='IModulePrecompileService_Experimental.xml' path='doc/member[@name="IModulePrecompileService_Experimental.getPrecompiledTargetCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getPrecompiledTargetCode(SlangCompileTarget target, [NativeTypeName("IBlob **")] ISlangBlob** outCode, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (IModulePrecompileService_Experimental* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getPrecompiledTargetCode>(lpVtbl->getPrecompiledTargetCode)(pThis, target, outCode, outDiagnostics);
        }
    }

    /// <include file='IModulePrecompileService_Experimental.xml' path='doc/member[@name="IModulePrecompileService_Experimental.getModuleDependencyCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangInt")]
    public long getModuleDependencyCount()
    {
        fixed (IModulePrecompileService_Experimental* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getModuleDependencyCount>(lpVtbl->getModuleDependencyCount)(pThis);
        }
    }

    /// <include file='IModulePrecompileService_Experimental.xml' path='doc/member[@name="IModulePrecompileService_Experimental.getModuleDependency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getModuleDependency([NativeTypeName("SlangInt")] long dependencyIndex, IModule** outModule, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (IModulePrecompileService_Experimental* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getModuleDependency>(lpVtbl->getModuleDependency)(pThis, dependencyIndex, outModule, outDiagnostics);
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

        [NativeTypeName("SlangResult (SlangCompileTarget, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr precompileForTarget;

        [NativeTypeName("SlangResult (SlangCompileTarget, IBlob **, IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getPrecompiledTargetCode;

        [NativeTypeName("SlangInt () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getModuleDependencyCount;

        [NativeTypeName("SlangResult (SlangInt, IModule **, IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getModuleDependency;
    }
}
