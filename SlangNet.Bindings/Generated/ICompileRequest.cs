using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest"]/*' />
[NativeTypeName("struct ICompileRequest : ISlangUnknown")]
public unsafe partial struct ICompileRequest
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ICompileRequest* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ICompileRequest* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ICompileRequest* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setFileSystem(ICompileRequest* pThis, ISlangFileSystem* fileSystem);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setCompileFlags(ICompileRequest* pThis, [NativeTypeName("SlangCompileFlags")] uint flags);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangCompileFlags")]
    public delegate uint _getCompileFlags(ICompileRequest* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setDumpIntermediates(ICompileRequest* pThis, int enable);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setDumpIntermediatePrefix(ICompileRequest* pThis, [NativeTypeName("const char *")] sbyte* prefix);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setLineDirectiveMode(ICompileRequest* pThis, SlangLineDirectiveMode mode);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setCodeGenTarget(ICompileRequest* pThis, SlangCompileTarget target);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int _addCodeGenTarget(ICompileRequest* pThis, SlangCompileTarget target);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setTargetProfile(ICompileRequest* pThis, int targetIndex, SlangProfileID profile);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setTargetFlags(ICompileRequest* pThis, int targetIndex, [NativeTypeName("SlangTargetFlags")] uint flags);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setTargetFloatingPointMode(ICompileRequest* pThis, int targetIndex, SlangFloatingPointMode mode);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setTargetMatrixLayoutMode(ICompileRequest* pThis, int targetIndex, SlangMatrixLayoutMode mode);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setMatrixLayoutMode(ICompileRequest* pThis, SlangMatrixLayoutMode mode);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setDebugInfoLevel(ICompileRequest* pThis, SlangDebugInfoLevel level);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setOptimizationLevel(ICompileRequest* pThis, SlangOptimizationLevel level);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setOutputContainerFormat(ICompileRequest* pThis, SlangContainerFormat format);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setPassThrough(ICompileRequest* pThis, SlangPassThrough passThrough);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setDiagnosticCallback(ICompileRequest* pThis, [NativeTypeName("Read")] IntPtr callback, [NativeTypeName("const void *")] void* userData);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setWriter(ICompileRequest* pThis, SlangWriterChannel channel, ISlangWriter* writer);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate ISlangWriter* _getWriter(ICompileRequest* pThis, SlangWriterChannel channel);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _addSearchPath(ICompileRequest* pThis, [NativeTypeName("const char *")] sbyte* searchDir);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _addPreprocessorDefine(ICompileRequest* pThis, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _processCommandLineArguments(ICompileRequest* pThis, [NativeTypeName("const char *const *")] sbyte** args, int argCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int _addTranslationUnit(ICompileRequest* pThis, SlangSourceLanguage language, [NativeTypeName("const char *")] sbyte* name);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setDefaultModuleName(ICompileRequest* pThis, [NativeTypeName("const char *")] sbyte* defaultModuleName);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _addTranslationUnitPreprocessorDefine(ICompileRequest* pThis, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _addTranslationUnitSourceFile(ICompileRequest* pThis, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _addTranslationUnitSourceString(ICompileRequest* pThis, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* source);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _addLibraryReference(ICompileRequest* pThis, [NativeTypeName("const void *")] void* libData, [NativeTypeName("size_t")] UIntPtr libDataSize);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _addTranslationUnitSourceStringSpan(ICompileRequest* pThis, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* sourceBegin, [NativeTypeName("const char *")] sbyte* sourceEnd);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _addTranslationUnitSourceBlob(ICompileRequest* pThis, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, ISlangBlob* sourceBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int _addEntryPoint(ICompileRequest* pThis, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* name, SlangStage stage);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int _addEntryPointEx(ICompileRequest* pThis, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* name, SlangStage stage, int genericArgCount, [NativeTypeName("const char **")] sbyte** genericArgs);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _setGlobalGenericArgs(ICompileRequest* pThis, int genericArgCount, [NativeTypeName("const char **")] sbyte** genericArgs);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _setTypeNameForGlobalExistentialTypeParam(ICompileRequest* pThis, int slotIndex, [NativeTypeName("const char *")] sbyte* typeName);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _setTypeNameForEntryPointExistentialTypeParam(ICompileRequest* pThis, int entryPointIndex, int slotIndex, [NativeTypeName("const char *")] sbyte* typeName);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _compile(ICompileRequest* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const char *")]
    public delegate sbyte* _getDiagnosticOutput(ICompileRequest* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getDiagnosticOutputBlob(ICompileRequest* pThis, ISlangBlob** outBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int _getDependencyFileCount(ICompileRequest* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const char *")]
    public delegate sbyte* _getDependencyFilePath(ICompileRequest* pThis, int index);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int _getTranslationUnitCount(ICompileRequest* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const char *")]
    public delegate sbyte* _getEntryPointSource(ICompileRequest* pThis, int entryPointIndex);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const void *")]
    public delegate void* _getEntryPointCode(ICompileRequest* pThis, int entryPointIndex, [NativeTypeName("size_t *")] UIntPtr* outSize);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getEntryPointCodeBlob(ICompileRequest* pThis, int entryPointIndex, int targetIndex, ISlangBlob** outBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getEntryPointHostCallable(ICompileRequest* pThis, int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getTargetCodeBlob(ICompileRequest* pThis, int targetIndex, ISlangBlob** outBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getTargetHostCallable(ICompileRequest* pThis, int targetIndex, ISlangSharedLibrary** outSharedLibrary);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const void *")]
    public delegate void* _getCompileRequestCode(ICompileRequest* pThis, [NativeTypeName("size_t *")] UIntPtr* outSize);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate ISlangMutableFileSystem* _getCompileRequestResultAsFileSystem(ICompileRequest* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getContainerCode(ICompileRequest* pThis, ISlangBlob** outBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _loadRepro(ICompileRequest* pThis, ISlangFileSystem* fileSystem, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _saveRepro(ICompileRequest* pThis, ISlangBlob** outBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _enableReproCapture(ICompileRequest* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getProgram(ICompileRequest* pThis, [NativeTypeName("slang::IComponentType **")] IComponentType** outProgram);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getEntryPoint(ICompileRequest* pThis, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("slang::IComponentType **")] IComponentType** outEntryPoint);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getModule(ICompileRequest* pThis, [NativeTypeName("SlangInt")] long translationUnitIndex, [NativeTypeName("slang::IModule **")] IModule** outModule);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getSession(ICompileRequest* pThis, [NativeTypeName("slang::ISession **")] ISession** outSession);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangReflection *")]
    public delegate SlangProgramLayout* _getReflection(ICompileRequest* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setCommandLineCompilerMode(ICompileRequest* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _addTargetCapability(ICompileRequest* pThis, [NativeTypeName("SlangInt")] long targetIndex, SlangCapabilityID capability);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getProgramWithEntryPoints(ICompileRequest* pThis, [NativeTypeName("slang::IComponentType **")] IComponentType** outProgram);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _isParameterLocationUsed(ICompileRequest* pThis, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, SlangParameterCategory category, [NativeTypeName("SlangUInt")] ulong spaceIndex, [NativeTypeName("SlangUInt")] ulong registerIndex, [NativeTypeName("bool &")] bool* outUsed);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setTargetLineDirectiveMode(ICompileRequest* pThis, [NativeTypeName("SlangInt")] long targetIndex, SlangLineDirectiveMode mode);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setTargetForceGLSLScalarBufferLayout(ICompileRequest* pThis, int targetIndex, [NativeTypeName("bool")] byte forceScalarLayout);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _overrideDiagnosticSeverity(ICompileRequest* pThis, [NativeTypeName("SlangInt")] long messageID, SlangSeverity overrideSeverity);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangDiagnosticFlags")]
    public delegate int _getDiagnosticFlags(ICompileRequest* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setDiagnosticFlags(ICompileRequest* pThis, [NativeTypeName("SlangDiagnosticFlags")] int flags);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setDebugInfoFormat(ICompileRequest* pThis, SlangDebugInfoFormat debugFormat);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setEnableEffectAnnotations(ICompileRequest* pThis, [NativeTypeName("bool")] byte value);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setReportDownstreamTime(ICompileRequest* pThis, [NativeTypeName("bool")] byte value);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setReportPerfBenchmark(ICompileRequest* pThis, [NativeTypeName("bool")] byte value);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setFileSystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setFileSystem(ISlangFileSystem* fileSystem)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setFileSystem>(lpVtbl->setFileSystem)(pThis, fileSystem);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setCompileFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setCompileFlags([NativeTypeName("SlangCompileFlags")] uint flags)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setCompileFlags>(lpVtbl->setCompileFlags)(pThis, flags);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getCompileFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangCompileFlags")]
    public uint getCompileFlags()
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getCompileFlags>(lpVtbl->getCompileFlags)(pThis);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setDumpIntermediates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setDumpIntermediates(int enable)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setDumpIntermediates>(lpVtbl->setDumpIntermediates)(pThis, enable);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setDumpIntermediatePrefix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setDumpIntermediatePrefix([NativeTypeName("const char *")] sbyte* prefix)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setDumpIntermediatePrefix>(lpVtbl->setDumpIntermediatePrefix)(pThis, prefix);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setLineDirectiveMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setLineDirectiveMode(SlangLineDirectiveMode mode)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setLineDirectiveMode>(lpVtbl->setLineDirectiveMode)(pThis, mode);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setCodeGenTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setCodeGenTarget(SlangCompileTarget target)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setCodeGenTarget>(lpVtbl->setCodeGenTarget)(pThis, target);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addCodeGenTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int addCodeGenTarget(SlangCompileTarget target)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addCodeGenTarget>(lpVtbl->addCodeGenTarget)(pThis, target);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setTargetProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setTargetProfile(int targetIndex, SlangProfileID profile)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setTargetProfile>(lpVtbl->setTargetProfile)(pThis, targetIndex, profile);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setTargetFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setTargetFlags(int targetIndex, [NativeTypeName("SlangTargetFlags")] uint flags)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setTargetFlags>(lpVtbl->setTargetFlags)(pThis, targetIndex, flags);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setTargetFloatingPointMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setTargetFloatingPointMode(int targetIndex, SlangFloatingPointMode mode)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setTargetFloatingPointMode>(lpVtbl->setTargetFloatingPointMode)(pThis, targetIndex, mode);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setTargetMatrixLayoutMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setTargetMatrixLayoutMode(int targetIndex, SlangMatrixLayoutMode mode)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setTargetMatrixLayoutMode>(lpVtbl->setTargetMatrixLayoutMode)(pThis, targetIndex, mode);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setMatrixLayoutMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setMatrixLayoutMode(SlangMatrixLayoutMode mode)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setMatrixLayoutMode>(lpVtbl->setMatrixLayoutMode)(pThis, mode);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setDebugInfoLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setDebugInfoLevel(SlangDebugInfoLevel level)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setDebugInfoLevel>(lpVtbl->setDebugInfoLevel)(pThis, level);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setOptimizationLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setOptimizationLevel(SlangOptimizationLevel level)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setOptimizationLevel>(lpVtbl->setOptimizationLevel)(pThis, level);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setOutputContainerFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setOutputContainerFormat(SlangContainerFormat format)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setOutputContainerFormat>(lpVtbl->setOutputContainerFormat)(pThis, format);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setPassThrough"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setPassThrough(SlangPassThrough passThrough)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setPassThrough>(lpVtbl->setPassThrough)(pThis, passThrough);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setDiagnosticCallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setDiagnosticCallback([NativeTypeName("SlangDiagnosticCallback")] IntPtr callback, [NativeTypeName("const void *")] void* userData)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setDiagnosticCallback>(lpVtbl->setDiagnosticCallback)(pThis, callback, userData);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setWriter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setWriter(SlangWriterChannel channel, ISlangWriter* writer)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setWriter>(lpVtbl->setWriter)(pThis, channel, writer);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getWriter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ISlangWriter* getWriter(SlangWriterChannel channel)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getWriter>(lpVtbl->getWriter)(pThis, channel);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addSearchPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void addSearchPath([NativeTypeName("const char *")] sbyte* searchDir)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_addSearchPath>(lpVtbl->addSearchPath)(pThis, searchDir);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addPreprocessorDefine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void addPreprocessorDefine([NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_addPreprocessorDefine>(lpVtbl->addPreprocessorDefine)(pThis, key, value);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.processCommandLineArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int processCommandLineArguments([NativeTypeName("const char *const *")] sbyte** args, int argCount)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_processCommandLineArguments>(lpVtbl->processCommandLineArguments)(pThis, args, argCount);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addTranslationUnit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int addTranslationUnit(SlangSourceLanguage language, [NativeTypeName("const char *")] sbyte* name)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addTranslationUnit>(lpVtbl->addTranslationUnit)(pThis, language, name);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setDefaultModuleName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setDefaultModuleName([NativeTypeName("const char *")] sbyte* defaultModuleName)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setDefaultModuleName>(lpVtbl->setDefaultModuleName)(pThis, defaultModuleName);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addTranslationUnitPreprocessorDefine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void addTranslationUnitPreprocessorDefine(int translationUnitIndex, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_addTranslationUnitPreprocessorDefine>(lpVtbl->addTranslationUnitPreprocessorDefine)(pThis, translationUnitIndex, key, value);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addTranslationUnitSourceFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void addTranslationUnitSourceFile(int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_addTranslationUnitSourceFile>(lpVtbl->addTranslationUnitSourceFile)(pThis, translationUnitIndex, path);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addTranslationUnitSourceString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void addTranslationUnitSourceString(int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* source)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_addTranslationUnitSourceString>(lpVtbl->addTranslationUnitSourceString)(pThis, translationUnitIndex, path, source);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addLibraryReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int addLibraryReference([NativeTypeName("const void *")] void* libData, [NativeTypeName("size_t")] UIntPtr libDataSize)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addLibraryReference>(lpVtbl->addLibraryReference)(pThis, libData, libDataSize);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addTranslationUnitSourceStringSpan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void addTranslationUnitSourceStringSpan(int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* sourceBegin, [NativeTypeName("const char *")] sbyte* sourceEnd)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_addTranslationUnitSourceStringSpan>(lpVtbl->addTranslationUnitSourceStringSpan)(pThis, translationUnitIndex, path, sourceBegin, sourceEnd);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addTranslationUnitSourceBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void addTranslationUnitSourceBlob(int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, ISlangBlob* sourceBlob)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_addTranslationUnitSourceBlob>(lpVtbl->addTranslationUnitSourceBlob)(pThis, translationUnitIndex, path, sourceBlob);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addEntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int addEntryPoint(int translationUnitIndex, [NativeTypeName("const char *")] sbyte* name, SlangStage stage)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addEntryPoint>(lpVtbl->addEntryPoint)(pThis, translationUnitIndex, name, stage);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addEntryPointEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int addEntryPointEx(int translationUnitIndex, [NativeTypeName("const char *")] sbyte* name, SlangStage stage, int genericArgCount, [NativeTypeName("const char **")] sbyte** genericArgs)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addEntryPointEx>(lpVtbl->addEntryPointEx)(pThis, translationUnitIndex, name, stage, genericArgCount, genericArgs);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setGlobalGenericArgs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int setGlobalGenericArgs(int genericArgCount, [NativeTypeName("const char **")] sbyte** genericArgs)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_setGlobalGenericArgs>(lpVtbl->setGlobalGenericArgs)(pThis, genericArgCount, genericArgs);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setTypeNameForGlobalExistentialTypeParam"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int setTypeNameForGlobalExistentialTypeParam(int slotIndex, [NativeTypeName("const char *")] sbyte* typeName)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_setTypeNameForGlobalExistentialTypeParam>(lpVtbl->setTypeNameForGlobalExistentialTypeParam)(pThis, slotIndex, typeName);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setTypeNameForEntryPointExistentialTypeParam"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int setTypeNameForEntryPointExistentialTypeParam(int entryPointIndex, int slotIndex, [NativeTypeName("const char *")] sbyte* typeName)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_setTypeNameForEntryPointExistentialTypeParam>(lpVtbl->setTypeNameForEntryPointExistentialTypeParam)(pThis, entryPointIndex, slotIndex, typeName);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.compile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int compile()
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_compile>(lpVtbl->compile)(pThis);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getDiagnosticOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const char *")]
    public sbyte* getDiagnosticOutput()
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDiagnosticOutput>(lpVtbl->getDiagnosticOutput)(pThis);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getDiagnosticOutputBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getDiagnosticOutputBlob(ISlangBlob** outBlob)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDiagnosticOutputBlob>(lpVtbl->getDiagnosticOutputBlob)(pThis, outBlob);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getDependencyFileCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int getDependencyFileCount()
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDependencyFileCount>(lpVtbl->getDependencyFileCount)(pThis);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getDependencyFilePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const char *")]
    public sbyte* getDependencyFilePath(int index)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDependencyFilePath>(lpVtbl->getDependencyFilePath)(pThis, index);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getTranslationUnitCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int getTranslationUnitCount()
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTranslationUnitCount>(lpVtbl->getTranslationUnitCount)(pThis);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getEntryPointSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const char *")]
    public sbyte* getEntryPointSource(int entryPointIndex)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryPointSource>(lpVtbl->getEntryPointSource)(pThis, entryPointIndex);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getEntryPointCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const void *")]
    public void* getEntryPointCode(int entryPointIndex, [NativeTypeName("size_t *")] UIntPtr* outSize)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryPointCode>(lpVtbl->getEntryPointCode)(pThis, entryPointIndex, outSize);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getEntryPointCodeBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getEntryPointCodeBlob(int entryPointIndex, int targetIndex, ISlangBlob** outBlob)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryPointCodeBlob>(lpVtbl->getEntryPointCodeBlob)(pThis, entryPointIndex, targetIndex, outBlob);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getEntryPointHostCallable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getEntryPointHostCallable(int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryPointHostCallable>(lpVtbl->getEntryPointHostCallable)(pThis, entryPointIndex, targetIndex, outSharedLibrary);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getTargetCodeBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getTargetCodeBlob(int targetIndex, ISlangBlob** outBlob)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTargetCodeBlob>(lpVtbl->getTargetCodeBlob)(pThis, targetIndex, outBlob);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getTargetHostCallable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getTargetHostCallable(int targetIndex, ISlangSharedLibrary** outSharedLibrary)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getTargetHostCallable>(lpVtbl->getTargetHostCallable)(pThis, targetIndex, outSharedLibrary);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getCompileRequestCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const void *")]
    public void* getCompileRequestCode([NativeTypeName("size_t *")] UIntPtr* outSize)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getCompileRequestCode>(lpVtbl->getCompileRequestCode)(pThis, outSize);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getCompileRequestResultAsFileSystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ISlangMutableFileSystem* getCompileRequestResultAsFileSystem()
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getCompileRequestResultAsFileSystem>(lpVtbl->getCompileRequestResultAsFileSystem)(pThis);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getContainerCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getContainerCode(ISlangBlob** outBlob)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getContainerCode>(lpVtbl->getContainerCode)(pThis, outBlob);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.loadRepro"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int loadRepro(ISlangFileSystem* fileSystem, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr size)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadRepro>(lpVtbl->loadRepro)(pThis, fileSystem, data, size);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.saveRepro"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int saveRepro(ISlangBlob** outBlob)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_saveRepro>(lpVtbl->saveRepro)(pThis, outBlob);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.enableReproCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int enableReproCapture()
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_enableReproCapture>(lpVtbl->enableReproCapture)(pThis);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getProgram"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getProgram([NativeTypeName("slang::IComponentType **")] IComponentType** outProgram)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getProgram>(lpVtbl->getProgram)(pThis, outProgram);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getEntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getEntryPoint([NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("slang::IComponentType **")] IComponentType** outEntryPoint)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryPoint>(lpVtbl->getEntryPoint)(pThis, entryPointIndex, outEntryPoint);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getModule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getModule([NativeTypeName("SlangInt")] long translationUnitIndex, [NativeTypeName("slang::IModule **")] IModule** outModule)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getModule>(lpVtbl->getModule)(pThis, translationUnitIndex, outModule);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getSession([NativeTypeName("slang::ISession **")] ISession** outSession)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getSession>(lpVtbl->getSession)(pThis, outSession);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getReflection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangReflection *")]
    public SlangProgramLayout* getReflection()
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getReflection>(lpVtbl->getReflection)(pThis);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setCommandLineCompilerMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setCommandLineCompilerMode()
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setCommandLineCompilerMode>(lpVtbl->setCommandLineCompilerMode)(pThis);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.addTargetCapability"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int addTargetCapability([NativeTypeName("SlangInt")] long targetIndex, SlangCapabilityID capability)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addTargetCapability>(lpVtbl->addTargetCapability)(pThis, targetIndex, capability);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getProgramWithEntryPoints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getProgramWithEntryPoints([NativeTypeName("slang::IComponentType **")] IComponentType** outProgram)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getProgramWithEntryPoints>(lpVtbl->getProgramWithEntryPoints)(pThis, outProgram);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.isParameterLocationUsed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int isParameterLocationUsed([NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, SlangParameterCategory category, [NativeTypeName("SlangUInt")] ulong spaceIndex, [NativeTypeName("SlangUInt")] ulong registerIndex, [NativeTypeName("bool &")] bool* outUsed)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_isParameterLocationUsed>(lpVtbl->isParameterLocationUsed)(pThis, entryPointIndex, targetIndex, category, spaceIndex, registerIndex, outUsed);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setTargetLineDirectiveMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setTargetLineDirectiveMode([NativeTypeName("SlangInt")] long targetIndex, SlangLineDirectiveMode mode)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setTargetLineDirectiveMode>(lpVtbl->setTargetLineDirectiveMode)(pThis, targetIndex, mode);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setTargetForceGLSLScalarBufferLayout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setTargetForceGLSLScalarBufferLayout(int targetIndex, [NativeTypeName("bool")] byte forceScalarLayout)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setTargetForceGLSLScalarBufferLayout>(lpVtbl->setTargetForceGLSLScalarBufferLayout)(pThis, targetIndex, forceScalarLayout);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.overrideDiagnosticSeverity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void overrideDiagnosticSeverity([NativeTypeName("SlangInt")] long messageID, SlangSeverity overrideSeverity)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_overrideDiagnosticSeverity>(lpVtbl->overrideDiagnosticSeverity)(pThis, messageID, overrideSeverity);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.getDiagnosticFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangDiagnosticFlags")]
    public int getDiagnosticFlags()
    {
        fixed (ICompileRequest* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDiagnosticFlags>(lpVtbl->getDiagnosticFlags)(pThis);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setDiagnosticFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setDiagnosticFlags([NativeTypeName("SlangDiagnosticFlags")] int flags)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setDiagnosticFlags>(lpVtbl->setDiagnosticFlags)(pThis, flags);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setDebugInfoFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setDebugInfoFormat(SlangDebugInfoFormat debugFormat)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setDebugInfoFormat>(lpVtbl->setDebugInfoFormat)(pThis, debugFormat);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setEnableEffectAnnotations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setEnableEffectAnnotations([NativeTypeName("bool")] byte value)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setEnableEffectAnnotations>(lpVtbl->setEnableEffectAnnotations)(pThis, value);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setReportDownstreamTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setReportDownstreamTime([NativeTypeName("bool")] byte value)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setReportDownstreamTime>(lpVtbl->setReportDownstreamTime)(pThis, value);
        }
    }

    /// <include file='ICompileRequest.xml' path='doc/member[@name="ICompileRequest.setReportPerfBenchmark"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setReportPerfBenchmark([NativeTypeName("bool")] byte value)
    {
        fixed (ICompileRequest* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setReportPerfBenchmark>(lpVtbl->setReportPerfBenchmark)(pThis, value);
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

        [NativeTypeName("void (ISlangFileSystem *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setFileSystem;

        [NativeTypeName("void (SlangCompileFlags) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setCompileFlags;

        [NativeTypeName("SlangCompileFlags () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getCompileFlags;

        [NativeTypeName("void (int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setDumpIntermediates;

        [NativeTypeName("void (const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setDumpIntermediatePrefix;

        [NativeTypeName("void (SlangLineDirectiveMode) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setLineDirectiveMode;

        [NativeTypeName("void (SlangCompileTarget) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setCodeGenTarget;

        [NativeTypeName("int (SlangCompileTarget) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addCodeGenTarget;

        [NativeTypeName("void (int, SlangProfileID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setTargetProfile;

        [NativeTypeName("void (int, SlangTargetFlags) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setTargetFlags;

        [NativeTypeName("void (int, SlangFloatingPointMode) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setTargetFloatingPointMode;

        [NativeTypeName("void (int, SlangMatrixLayoutMode) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setTargetMatrixLayoutMode;

        [NativeTypeName("void (SlangMatrixLayoutMode) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setMatrixLayoutMode;

        [NativeTypeName("void (SlangDebugInfoLevel) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setDebugInfoLevel;

        [NativeTypeName("void (SlangOptimizationLevel) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setOptimizationLevel;

        [NativeTypeName("void (SlangContainerFormat) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setOutputContainerFormat;

        [NativeTypeName("void (SlangPassThrough) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setPassThrough;

        [NativeTypeName("void (SlangDiagnosticCallback, const void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setDiagnosticCallback;

        [NativeTypeName("void (SlangWriterChannel, ISlangWriter *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setWriter;

        [NativeTypeName("ISlangWriter *(SlangWriterChannel) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getWriter;

        [NativeTypeName("void (const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addSearchPath;

        [NativeTypeName("void (const char *, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addPreprocessorDefine;

        [NativeTypeName("SlangResult (const char *const *, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr processCommandLineArguments;

        [NativeTypeName("int (SlangSourceLanguage, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addTranslationUnit;

        [NativeTypeName("void (const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setDefaultModuleName;

        [NativeTypeName("void (int, const char *, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addTranslationUnitPreprocessorDefine;

        [NativeTypeName("void (int, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addTranslationUnitSourceFile;

        [NativeTypeName("void (int, const char *, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addTranslationUnitSourceString;

        [NativeTypeName("SlangResult (const void *, size_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addLibraryReference;

        [NativeTypeName("void (int, const char *, const char *, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addTranslationUnitSourceStringSpan;

        [NativeTypeName("void (int, const char *, ISlangBlob *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addTranslationUnitSourceBlob;

        [NativeTypeName("int (int, const char *, SlangStage) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addEntryPoint;

        [NativeTypeName("int (int, const char *, SlangStage, int, const char **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addEntryPointEx;

        [NativeTypeName("SlangResult (int, const char **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setGlobalGenericArgs;

        [NativeTypeName("SlangResult (int, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setTypeNameForGlobalExistentialTypeParam;

        [NativeTypeName("SlangResult (int, int, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setTypeNameForEntryPointExistentialTypeParam;

        [NativeTypeName("SlangResult () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr compile;

        [NativeTypeName("const char *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDiagnosticOutput;

        [NativeTypeName("SlangResult (ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDiagnosticOutputBlob;

        [NativeTypeName("int () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDependencyFileCount;

        [NativeTypeName("const char *(int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDependencyFilePath;

        [NativeTypeName("int () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getTranslationUnitCount;

        [NativeTypeName("const char *(int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryPointSource;

        [NativeTypeName("const void *(int, size_t *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryPointCode;

        [NativeTypeName("SlangResult (int, int, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryPointCodeBlob;

        [NativeTypeName("SlangResult (int, int, ISlangSharedLibrary **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryPointHostCallable;

        [NativeTypeName("SlangResult (int, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getTargetCodeBlob;

        [NativeTypeName("SlangResult (int, ISlangSharedLibrary **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getTargetHostCallable;

        [NativeTypeName("const void *(size_t *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getCompileRequestCode;

        [NativeTypeName("ISlangMutableFileSystem *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getCompileRequestResultAsFileSystem;

        [NativeTypeName("SlangResult (ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getContainerCode;

        [NativeTypeName("SlangResult (ISlangFileSystem *, const void *, size_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr loadRepro;

        [NativeTypeName("SlangResult (ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr saveRepro;

        [NativeTypeName("SlangResult () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr enableReproCapture;

        [NativeTypeName("SlangResult (slang::IComponentType **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getProgram;

        [NativeTypeName("SlangResult (SlangInt, slang::IComponentType **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryPoint;

        [NativeTypeName("SlangResult (SlangInt, slang::IModule **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getModule;

        [NativeTypeName("SlangResult (slang::ISession **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getSession;

        [NativeTypeName("SlangReflection *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getReflection;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setCommandLineCompilerMode;

        [NativeTypeName("SlangResult (SlangInt, SlangCapabilityID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addTargetCapability;

        [NativeTypeName("SlangResult (slang::IComponentType **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getProgramWithEntryPoints;

        [NativeTypeName("SlangResult (SlangInt, SlangInt, SlangParameterCategory, SlangUInt, SlangUInt, bool &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr isParameterLocationUsed;

        [NativeTypeName("void (SlangInt, SlangLineDirectiveMode) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setTargetLineDirectiveMode;

        [NativeTypeName("void (int, bool) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setTargetForceGLSLScalarBufferLayout;

        [NativeTypeName("void (SlangInt, SlangSeverity) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr overrideDiagnosticSeverity;

        [NativeTypeName("SlangDiagnosticFlags () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDiagnosticFlags;

        [NativeTypeName("void (SlangDiagnosticFlags) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setDiagnosticFlags;

        [NativeTypeName("void (SlangDebugInfoFormat) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setDebugInfoFormat;

        [NativeTypeName("void (bool) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setEnableEffectAnnotations;

        [NativeTypeName("void (bool) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setReportDownstreamTime;

        [NativeTypeName("void (bool) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setReportPerfBenchmark;
    }
}
