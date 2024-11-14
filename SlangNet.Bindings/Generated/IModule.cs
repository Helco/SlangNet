using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='IModule.xml' path='doc/member[@name="IModule"]/*' />
[NativeTypeName("struct IModule : slang::IComponentType")]
public unsafe partial struct IModule
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(IModule* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(IModule* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(IModule* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::ISession *")]
    public delegate ISession* _getSession(IModule* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::ProgramLayout *")]
    public delegate ShaderReflection* _getLayout(IModule* pThis, [NativeTypeName("SlangInt")] long targetIndex = 0, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangInt")]
    public delegate long _getSpecializationParamCount(IModule* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getEntryPointCode(IModule* pThis, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, [NativeTypeName("IBlob **")] ISlangBlob** outCode, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getResultAsFileSystem(IModule* pThis, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, ISlangMutableFileSystem** outFileSystem);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _getEntryPointHash(IModule* pThis, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, [NativeTypeName("IBlob **")] ISlangBlob** outHash);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _specialize(IModule* pThis, [NativeTypeName("const SpecializationArg *")] SpecializationArg* specializationArgs, [NativeTypeName("SlangInt")] long specializationArgCount, IComponentType** outSpecializedComponentType, ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _link(IModule* pThis, IComponentType** outLinkedComponentType, ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getEntryPointHostCallable(IModule* pThis, int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary, [NativeTypeName("slang::IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _renameEntryPoint(IModule* pThis, [NativeTypeName("const char *")] sbyte* newName, IComponentType** outEntryPoint);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _linkWithOptions(IModule* pThis, IComponentType** outLinkedComponentType, [NativeTypeName("uint32_t")] uint compilerOptionEntryCount, [NativeTypeName("slang::CompilerOptionEntry *")] CompilerOptionEntry* compilerOptionEntries, ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getTargetCode(IModule* pThis, [NativeTypeName("SlangInt")] long targetIndex, [NativeTypeName("IBlob **")] ISlangBlob** outCode, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getTargetMetadata(IModule* pThis, [NativeTypeName("SlangInt")] long targetIndex, IMetadata** outMetadata, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getEntryPointMetadata(IModule* pThis, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, IMetadata** outMetadata, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _findEntryPointByName(IModule* pThis, [NativeTypeName("const char *")] sbyte* name, IEntryPoint** outEntryPoint);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangInt32")]
    public delegate int _getDefinedEntryPointCount(IModule* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getDefinedEntryPoint(IModule* pThis, [NativeTypeName("SlangInt32")] int index, IEntryPoint** outEntryPoint);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _serialize(IModule* pThis, ISlangBlob** outSerializedBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _writeToFile(IModule* pThis, [NativeTypeName("const char *")] sbyte* fileName);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const char *")]
    public delegate sbyte* _getName(IModule* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const char *")]
    public delegate sbyte* _getFilePath(IModule* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const char *")]
    public delegate sbyte* _getUniqueIdentity(IModule* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _findAndCheckEntryPoint(IModule* pThis, [NativeTypeName("const char *")] sbyte* name, SlangStage stage, IEntryPoint** outEntryPoint, ISlangBlob** outDiagnostics);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangInt32")]
    public delegate int _getDependencyFileCount(IModule* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const char *")]
    public delegate sbyte* _getDependencyFilePath(IModule* pThis, [NativeTypeName("SlangInt32")] int index);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::DeclReflection *")]
    public delegate DeclReflection* _getModuleReflection(IModule* pThis);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <inheritdoc cref="IComponentType.getSession" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::ISession *")]
    public ISession* getSession()
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getSession>(lpVtbl->getSession)(pThis);
        }
    }

    /// <inheritdoc cref="IComponentType.getLayout" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::ProgramLayout *")]
    public ShaderReflection* getLayout([NativeTypeName("SlangInt")] long targetIndex = 0, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getLayout>(lpVtbl->getLayout)(pThis, targetIndex, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.getSpecializationParamCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangInt")]
    public long getSpecializationParamCount()
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getSpecializationParamCount>(lpVtbl->getSpecializationParamCount)(pThis);
        }
    }

    /// <inheritdoc cref="IComponentType.getEntryPointCode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getEntryPointCode([NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, [NativeTypeName("IBlob **")] ISlangBlob** outCode, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryPointCode>(lpVtbl->getEntryPointCode)(pThis, entryPointIndex, targetIndex, outCode, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.getResultAsFileSystem" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getResultAsFileSystem([NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, ISlangMutableFileSystem** outFileSystem)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getResultAsFileSystem>(lpVtbl->getResultAsFileSystem)(pThis, entryPointIndex, targetIndex, outFileSystem);
        }
    }

    /// <inheritdoc cref="IComponentType.getEntryPointHash" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void getEntryPointHash([NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, [NativeTypeName("IBlob **")] ISlangBlob** outHash)
    {
        fixed (IModule* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_getEntryPointHash>(lpVtbl->getEntryPointHash)(pThis, entryPointIndex, targetIndex, outHash);
        }
    }

    /// <inheritdoc cref="IComponentType.specialize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int specialize([NativeTypeName("const SpecializationArg *")] SpecializationArg* specializationArgs, [NativeTypeName("SlangInt")] long specializationArgCount, IComponentType** outSpecializedComponentType, ISlangBlob** outDiagnostics = null)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_specialize>(lpVtbl->specialize)(pThis, specializationArgs, specializationArgCount, outSpecializedComponentType, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.link" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int link(IComponentType** outLinkedComponentType, ISlangBlob** outDiagnostics = null)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_link>(lpVtbl->link)(pThis, outLinkedComponentType, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.getEntryPointHostCallable" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getEntryPointHostCallable(int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary, [NativeTypeName("slang::IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryPointHostCallable>(lpVtbl->getEntryPointHostCallable)(pThis, entryPointIndex, targetIndex, outSharedLibrary, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.renameEntryPoint" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int renameEntryPoint([NativeTypeName("const char *")] sbyte* newName, IComponentType** outEntryPoint)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_renameEntryPoint>(lpVtbl->renameEntryPoint)(pThis, newName, outEntryPoint);
        }
    }

    /// <inheritdoc cref="IComponentType.linkWithOptions" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int linkWithOptions(IComponentType** outLinkedComponentType, [NativeTypeName("uint32_t")] uint compilerOptionEntryCount, [NativeTypeName("slang::CompilerOptionEntry *")] CompilerOptionEntry* compilerOptionEntries, ISlangBlob** outDiagnostics = null)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_linkWithOptions>(lpVtbl->linkWithOptions)(pThis, outLinkedComponentType, compilerOptionEntryCount, compilerOptionEntries, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.getTargetCode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getTargetCode([NativeTypeName("SlangInt")] long targetIndex, [NativeTypeName("IBlob **")] ISlangBlob** outCode, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTargetCode>(lpVtbl->getTargetCode)(pThis, targetIndex, outCode, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.getTargetMetadata" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getTargetMetadata([NativeTypeName("SlangInt")] long targetIndex, IMetadata** outMetadata, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTargetMetadata>(lpVtbl->getTargetMetadata)(pThis, targetIndex, outMetadata, outDiagnostics);
        }
    }

    /// <inheritdoc cref="IComponentType.getEntryPointMetadata" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getEntryPointMetadata([NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, IMetadata** outMetadata, [NativeTypeName("IBlob **")] ISlangBlob** outDiagnostics = null)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryPointMetadata>(lpVtbl->getEntryPointMetadata)(pThis, entryPointIndex, targetIndex, outMetadata, outDiagnostics);
        }
    }

    /// <include file='IModule.xml' path='doc/member[@name="IModule.findEntryPointByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int findEntryPointByName([NativeTypeName("const char *")] sbyte* name, IEntryPoint** outEntryPoint)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_findEntryPointByName>(lpVtbl->findEntryPointByName)(pThis, name, outEntryPoint);
        }
    }

    /// <include file='IModule.xml' path='doc/member[@name="IModule.getDefinedEntryPointCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangInt32")]
    public int getDefinedEntryPointCount()
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDefinedEntryPointCount>(lpVtbl->getDefinedEntryPointCount)(pThis);
        }
    }

    /// <include file='IModule.xml' path='doc/member[@name="IModule.getDefinedEntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getDefinedEntryPoint([NativeTypeName("SlangInt32")] int index, IEntryPoint** outEntryPoint)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDefinedEntryPoint>(lpVtbl->getDefinedEntryPoint)(pThis, index, outEntryPoint);
        }
    }

    /// <include file='IModule.xml' path='doc/member[@name="IModule.serialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int serialize(ISlangBlob** outSerializedBlob)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_serialize>(lpVtbl->serialize)(pThis, outSerializedBlob);
        }
    }

    /// <include file='IModule.xml' path='doc/member[@name="IModule.writeToFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int writeToFile([NativeTypeName("const char *")] sbyte* fileName)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_writeToFile>(lpVtbl->writeToFile)(pThis, fileName);
        }
    }

    /// <include file='IModule.xml' path='doc/member[@name="IModule.getName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const char *")]
    public sbyte* getName()
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getName>(lpVtbl->getName)(pThis);
        }
    }

    /// <include file='IModule.xml' path='doc/member[@name="IModule.getFilePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const char *")]
    public sbyte* getFilePath()
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getFilePath>(lpVtbl->getFilePath)(pThis);
        }
    }

    /// <include file='IModule.xml' path='doc/member[@name="IModule.getUniqueIdentity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const char *")]
    public sbyte* getUniqueIdentity()
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getUniqueIdentity>(lpVtbl->getUniqueIdentity)(pThis);
        }
    }

    /// <include file='IModule.xml' path='doc/member[@name="IModule.findAndCheckEntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int findAndCheckEntryPoint([NativeTypeName("const char *")] sbyte* name, SlangStage stage, IEntryPoint** outEntryPoint, ISlangBlob** outDiagnostics)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_findAndCheckEntryPoint>(lpVtbl->findAndCheckEntryPoint)(pThis, name, stage, outEntryPoint, outDiagnostics);
        }
    }

    /// <include file='IModule.xml' path='doc/member[@name="IModule.getDependencyFileCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangInt32")]
    public int getDependencyFileCount()
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDependencyFileCount>(lpVtbl->getDependencyFileCount)(pThis);
        }
    }

    /// <include file='IModule.xml' path='doc/member[@name="IModule.getDependencyFilePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const char *")]
    public sbyte* getDependencyFilePath([NativeTypeName("SlangInt32")] int index)
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDependencyFilePath>(lpVtbl->getDependencyFilePath)(pThis, index);
        }
    }

    /// <include file='IModule.xml' path='doc/member[@name="IModule.getModuleReflection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::DeclReflection *")]
    public DeclReflection* getModuleReflection()
    {
        fixed (IModule* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getModuleReflection>(lpVtbl->getModuleReflection)(pThis);
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

        [NativeTypeName("SlangResult (IComponentType **, uint32_t, CompilerOptionEntry *, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr linkWithOptions;

        [NativeTypeName("SlangResult (SlangInt, IBlob **, IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getTargetCode;

        [NativeTypeName("SlangResult (SlangInt, IMetadata **, IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getTargetMetadata;

        [NativeTypeName("SlangResult (SlangInt, SlangInt, IMetadata **, IBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryPointMetadata;

        [NativeTypeName("SlangResult (const char *, IEntryPoint **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr findEntryPointByName;

        [NativeTypeName("SlangInt32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDefinedEntryPointCount;

        [NativeTypeName("SlangResult (SlangInt32, IEntryPoint **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDefinedEntryPoint;

        [NativeTypeName("SlangResult (ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr serialize;

        [NativeTypeName("SlangResult (const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr writeToFile;

        [NativeTypeName("const char *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getName;

        [NativeTypeName("const char *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getFilePath;

        [NativeTypeName("const char *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getUniqueIdentity;

        [NativeTypeName("SlangResult (const char *, SlangStage, IEntryPoint **, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr findAndCheckEntryPoint;

        [NativeTypeName("SlangInt32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDependencyFileCount;

        [NativeTypeName("const char *(SlangInt32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDependencyFilePath;

        [NativeTypeName("DeclReflection *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getModuleReflection;
    }
}
