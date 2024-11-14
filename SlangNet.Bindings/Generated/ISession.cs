using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static SlangNet.LayoutRules;

namespace SlangNet.Unsafe;

/// <include file='ISession.xml' path='doc/member[@name="ISession"]/*' />
[NativeTypeName("struct ISession : ISlangUnknown")]
public unsafe partial struct ISession
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISession* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISession* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISession* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::IGlobalSession *")]
    public delegate IGlobalSession* _getGlobalSession(ISession* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::IModule *")]
    public delegate IModule* _loadModule(ISession* pThis, [NativeTypeName("const char *")] sbyte* moduleName, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::IModule *")]
    public delegate IModule* _loadModuleFromSource(ISession* pThis, [NativeTypeName("const char *")] sbyte* moduleName, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("slang::IBlob *")] ISlangBlob* source, [NativeTypeName("slang::IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _createCompositeComponentType(ISession* pThis, [NativeTypeName("IComponentType *const *")] IComponentType** componentTypes, [NativeTypeName("SlangInt")] long componentTypeCount, IComponentType** outCompositeComponentType, ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::TypeReflection *")]
    public delegate TypeReflection* _specializeType(ISession* pThis, [NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("const SpecializationArg *")] SpecializationArg* specializationArgs, [NativeTypeName("SlangInt")] long specializationArgCount, ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::TypeLayoutReflection *")]
    public delegate TypeLayoutReflection* _getTypeLayout(ISession* pThis, [NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("SlangInt")] long targetIndex = 0, [NativeTypeName("slang::LayoutRules")] LayoutRules rules = Default, ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::TypeReflection *")]
    public delegate TypeReflection* _getContainerType(ISession* pThis, [NativeTypeName("slang::TypeReflection *")] TypeReflection* elementType, [NativeTypeName("slang::ContainerType")] ContainerType containerType, ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::TypeReflection *")]
    public delegate TypeReflection* _getDynamicType(ISession* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getTypeRTTIMangledName(ISession* pThis, [NativeTypeName("slang::TypeReflection *")] TypeReflection* type, ISlangBlob** outNameBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getTypeConformanceWitnessMangledName(ISession* pThis, [NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("slang::TypeReflection *")] TypeReflection* interfaceType, ISlangBlob** outNameBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getTypeConformanceWitnessSequentialID(ISession* pThis, [NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("slang::TypeReflection *")] TypeReflection* interfaceType, [NativeTypeName("uint32_t *")] uint* outId);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _createCompileRequest(ISession* pThis, [NativeTypeName("SlangCompileRequest **")] void** outCompileRequest);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _createTypeConformanceComponentType(ISession* pThis, [NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("slang::TypeReflection *")] TypeReflection* interfaceType, ITypeConformance** outConformance, [NativeTypeName("SlangInt")] long conformanceIdOverride, ISlangBlob** outDiagnostics);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::IModule *")]
    public delegate IModule* _loadModuleFromIRBlob(ISession* pThis, [NativeTypeName("const char *")] sbyte* moduleName, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("slang::IBlob *")] ISlangBlob* source, [NativeTypeName("slang::IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangInt")]
    public delegate long _getLoadedModuleCount(ISession* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::IModule *")]
    public delegate IModule* _getLoadedModule(ISession* pThis, [NativeTypeName("SlangInt")] long index);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("bool")]
    public delegate byte _isBinaryModuleUpToDate(ISession* pThis, [NativeTypeName("const char *")] sbyte* modulePath, [NativeTypeName("slang::IBlob *")] ISlangBlob* binaryModuleBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::IModule *")]
    public delegate IModule* _loadModuleFromSourceString(ISession* pThis, [NativeTypeName("const char *")] sbyte* moduleName, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* @string, [NativeTypeName("slang::IBlob **")] ISlangBlob** outDiagnostics = null);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getGlobalSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::IGlobalSession *")]
    public IGlobalSession* getGlobalSession()
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getGlobalSession>(lpVtbl->getGlobalSession)(pThis);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.loadModule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::IModule *")]
    public IModule* loadModule([NativeTypeName("const char *")] sbyte* moduleName, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadModule>(lpVtbl->loadModule)(pThis, moduleName, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.loadModuleFromSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::IModule *")]
    public IModule* loadModuleFromSource([NativeTypeName("const char *")] sbyte* moduleName, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("slang::IBlob *")] ISlangBlob* source, [NativeTypeName("slang::IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadModuleFromSource>(lpVtbl->loadModuleFromSource)(pThis, moduleName, path, source, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.createCompositeComponentType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int createCompositeComponentType([NativeTypeName("IComponentType *const *")] IComponentType** componentTypes, [NativeTypeName("SlangInt")] long componentTypeCount, IComponentType** outCompositeComponentType, ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createCompositeComponentType>(lpVtbl->createCompositeComponentType)(pThis, componentTypes, componentTypeCount, outCompositeComponentType, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.specializeType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::TypeReflection *")]
    public TypeReflection* specializeType([NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("const SpecializationArg *")] SpecializationArg* specializationArgs, [NativeTypeName("SlangInt")] long specializationArgCount, ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_specializeType>(lpVtbl->specializeType)(pThis, type, specializationArgs, specializationArgCount, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getTypeLayout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::TypeLayoutReflection *")]
    public TypeLayoutReflection* getTypeLayout([NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("SlangInt")] long targetIndex = 0, [NativeTypeName("slang::LayoutRules")] LayoutRules rules = Default, ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTypeLayout>(lpVtbl->getTypeLayout)(pThis, type, targetIndex, rules, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getContainerType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::TypeReflection *")]
    public TypeReflection* getContainerType([NativeTypeName("slang::TypeReflection *")] TypeReflection* elementType, [NativeTypeName("slang::ContainerType")] ContainerType containerType, ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getContainerType>(lpVtbl->getContainerType)(pThis, elementType, containerType, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getDynamicType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::TypeReflection *")]
    public TypeReflection* getDynamicType()
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDynamicType>(lpVtbl->getDynamicType)(pThis);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getTypeRTTIMangledName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getTypeRTTIMangledName([NativeTypeName("slang::TypeReflection *")] TypeReflection* type, ISlangBlob** outNameBlob)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTypeRTTIMangledName>(lpVtbl->getTypeRTTIMangledName)(pThis, type, outNameBlob);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getTypeConformanceWitnessMangledName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getTypeConformanceWitnessMangledName([NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("slang::TypeReflection *")] TypeReflection* interfaceType, ISlangBlob** outNameBlob)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTypeConformanceWitnessMangledName>(lpVtbl->getTypeConformanceWitnessMangledName)(pThis, type, interfaceType, outNameBlob);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getTypeConformanceWitnessSequentialID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getTypeConformanceWitnessSequentialID([NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("slang::TypeReflection *")] TypeReflection* interfaceType, [NativeTypeName("uint32_t *")] uint* outId)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTypeConformanceWitnessSequentialID>(lpVtbl->getTypeConformanceWitnessSequentialID)(pThis, type, interfaceType, outId);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.createCompileRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int createCompileRequest([NativeTypeName("SlangCompileRequest **")] void** outCompileRequest)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createCompileRequest>(lpVtbl->createCompileRequest)(pThis, outCompileRequest);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.createTypeConformanceComponentType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int createTypeConformanceComponentType([NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("slang::TypeReflection *")] TypeReflection* interfaceType, ITypeConformance** outConformance, [NativeTypeName("SlangInt")] long conformanceIdOverride, ISlangBlob** outDiagnostics)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createTypeConformanceComponentType>(lpVtbl->createTypeConformanceComponentType)(pThis, type, interfaceType, outConformance, conformanceIdOverride, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.loadModuleFromIRBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::IModule *")]
    public IModule* loadModuleFromIRBlob([NativeTypeName("const char *")] sbyte* moduleName, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("slang::IBlob *")] ISlangBlob* source, [NativeTypeName("slang::IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadModuleFromIRBlob>(lpVtbl->loadModuleFromIRBlob)(pThis, moduleName, path, source, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getLoadedModuleCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangInt")]
    public long getLoadedModuleCount()
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getLoadedModuleCount>(lpVtbl->getLoadedModuleCount)(pThis);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getLoadedModule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::IModule *")]
    public IModule* getLoadedModule([NativeTypeName("SlangInt")] long index)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getLoadedModule>(lpVtbl->getLoadedModule)(pThis, index);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.isBinaryModuleUpToDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool isBinaryModuleUpToDate([NativeTypeName("const char *")] sbyte* modulePath, [NativeTypeName("slang::IBlob *")] ISlangBlob* binaryModuleBlob)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_isBinaryModuleUpToDate>(lpVtbl->isBinaryModuleUpToDate)(pThis, modulePath, binaryModuleBlob) != 0;
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.loadModuleFromSourceString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::IModule *")]
    public IModule* loadModuleFromSourceString([NativeTypeName("const char *")] sbyte* moduleName, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* @string, [NativeTypeName("slang::IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadModuleFromSourceString>(lpVtbl->loadModuleFromSourceString)(pThis, moduleName, path, @string, outDiagnostics);
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

        [NativeTypeName("IGlobalSession *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getGlobalSession;

        [NativeTypeName("IModule *(const char *, IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr loadModule;

        [NativeTypeName("IModule *(const char *, const char *, slang::IBlob *, slang::IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr loadModuleFromSource;

        [NativeTypeName("SlangResult (IComponentType *const *, SlangInt, IComponentType **, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createCompositeComponentType;

        [NativeTypeName("TypeReflection *(TypeReflection *, const SpecializationArg *, SlangInt, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr specializeType;

        [NativeTypeName("TypeLayoutReflection *(TypeReflection *, SlangInt, LayoutRules, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getTypeLayout;

        [NativeTypeName("TypeReflection *(TypeReflection *, ContainerType, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getContainerType;

        [NativeTypeName("TypeReflection *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDynamicType;

        [NativeTypeName("SlangResult (TypeReflection *, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getTypeRTTIMangledName;

        [NativeTypeName("SlangResult (TypeReflection *, TypeReflection *, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getTypeConformanceWitnessMangledName;

        [NativeTypeName("SlangResult (slang::TypeReflection *, slang::TypeReflection *, uint32_t *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getTypeConformanceWitnessSequentialID;

        [NativeTypeName("SlangResult (SlangCompileRequest **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createCompileRequest;

        [NativeTypeName("SlangResult (slang::TypeReflection *, slang::TypeReflection *, ITypeConformance **, SlangInt, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createTypeConformanceComponentType;

        [NativeTypeName("IModule *(const char *, const char *, slang::IBlob *, slang::IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr loadModuleFromIRBlob;

        [NativeTypeName("SlangInt () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getLoadedModuleCount;

        [NativeTypeName("IModule *(SlangInt) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getLoadedModule;

        [NativeTypeName("bool (const char *, slang::IBlob *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr isBinaryModuleUpToDate;

        [NativeTypeName("IModule *(const char *, const char *, const char *, slang::IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr loadModuleFromSourceString;
    }
}
