using System;
using System.Runtime.InteropServices;
using static SlangNet.LayoutRules;

namespace SlangNet;

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
    public delegate int _createCompileRequest(ISession* pThis, [NativeTypeName("SlangCompileRequest **")] ICompileRequest** outCompileRequest);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _createTypeConformanceComponentType(ISession* pThis, [NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("slang::TypeReflection *")] TypeReflection* interfaceType, ITypeConformance** outConformance, [NativeTypeName("SlangInt")] long conformanceIdOverride, ISlangBlob** outDiagnostics);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getGlobalSession"]/*' />
    [return: NativeTypeName("slang::IGlobalSession *")]
    public IGlobalSession* getGlobalSession()
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getGlobalSession>(lpVtbl->getGlobalSession)(pThis);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.loadModule"]/*' />
    [return: NativeTypeName("slang::IModule *")]
    public IModule* loadModule([NativeTypeName("const char *")] sbyte* moduleName, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadModule>(lpVtbl->loadModule)(pThis, moduleName, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.loadModuleFromSource"]/*' />
    [return: NativeTypeName("slang::IModule *")]
    public IModule* loadModuleFromSource([NativeTypeName("const char *")] sbyte* moduleName, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("slang::IBlob *")] ISlangBlob* source, [NativeTypeName("slang::IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadModuleFromSource>(lpVtbl->loadModuleFromSource)(pThis, moduleName, path, source, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.createCompositeComponentType"]/*' />
    [return: NativeTypeName("SlangResult")]
    public int createCompositeComponentType([NativeTypeName("IComponentType *const *")] IComponentType** componentTypes, [NativeTypeName("SlangInt")] long componentTypeCount, IComponentType** outCompositeComponentType, ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createCompositeComponentType>(lpVtbl->createCompositeComponentType)(pThis, componentTypes, componentTypeCount, outCompositeComponentType, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.specializeType"]/*' />
    [return: NativeTypeName("slang::TypeReflection *")]
    public TypeReflection* specializeType([NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("const SpecializationArg *")] SpecializationArg* specializationArgs, [NativeTypeName("SlangInt")] long specializationArgCount, ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_specializeType>(lpVtbl->specializeType)(pThis, type, specializationArgs, specializationArgCount, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getTypeLayout"]/*' />
    [return: NativeTypeName("slang::TypeLayoutReflection *")]
    public TypeLayoutReflection* getTypeLayout([NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("SlangInt")] long targetIndex = 0, [NativeTypeName("slang::LayoutRules")] LayoutRules rules = Default, ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTypeLayout>(lpVtbl->getTypeLayout)(pThis, type, targetIndex, rules, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getContainerType"]/*' />
    [return: NativeTypeName("slang::TypeReflection *")]
    public TypeReflection* getContainerType([NativeTypeName("slang::TypeReflection *")] TypeReflection* elementType, [NativeTypeName("slang::ContainerType")] ContainerType containerType, ISlangBlob** outDiagnostics = null)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getContainerType>(lpVtbl->getContainerType)(pThis, elementType, containerType, outDiagnostics);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getDynamicType"]/*' />
    [return: NativeTypeName("slang::TypeReflection *")]
    public TypeReflection* getDynamicType()
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDynamicType>(lpVtbl->getDynamicType)(pThis);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getTypeRTTIMangledName"]/*' />
    [return: NativeTypeName("SlangResult")]
    public int getTypeRTTIMangledName([NativeTypeName("slang::TypeReflection *")] TypeReflection* type, ISlangBlob** outNameBlob)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTypeRTTIMangledName>(lpVtbl->getTypeRTTIMangledName)(pThis, type, outNameBlob);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getTypeConformanceWitnessMangledName"]/*' />
    [return: NativeTypeName("SlangResult")]
    public int getTypeConformanceWitnessMangledName([NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("slang::TypeReflection *")] TypeReflection* interfaceType, ISlangBlob** outNameBlob)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTypeConformanceWitnessMangledName>(lpVtbl->getTypeConformanceWitnessMangledName)(pThis, type, interfaceType, outNameBlob);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.getTypeConformanceWitnessSequentialID"]/*' />
    [return: NativeTypeName("SlangResult")]
    public int getTypeConformanceWitnessSequentialID([NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("slang::TypeReflection *")] TypeReflection* interfaceType, [NativeTypeName("uint32_t *")] uint* outId)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTypeConformanceWitnessSequentialID>(lpVtbl->getTypeConformanceWitnessSequentialID)(pThis, type, interfaceType, outId);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.createCompileRequest"]/*' />
    [return: NativeTypeName("SlangResult")]
    public int createCompileRequest([NativeTypeName("SlangCompileRequest **")] ICompileRequest** outCompileRequest)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createCompileRequest>(lpVtbl->createCompileRequest)(pThis, outCompileRequest);
        }
    }

    /// <include file='ISession.xml' path='doc/member[@name="ISession.createTypeConformanceComponentType"]/*' />
    [return: NativeTypeName("SlangResult")]
    public int createTypeConformanceComponentType([NativeTypeName("slang::TypeReflection *")] TypeReflection* type, [NativeTypeName("slang::TypeReflection *")] TypeReflection* interfaceType, ITypeConformance** outConformance, [NativeTypeName("SlangInt")] long conformanceIdOverride, ISlangBlob** outDiagnostics)
    {
        fixed (ISession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createTypeConformanceComponentType>(lpVtbl->createTypeConformanceComponentType)(pThis, type, interfaceType, outConformance, conformanceIdOverride, outDiagnostics);
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
    }
}
