using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession"]/*' />
[NativeTypeName("struct IGlobalSession : ISlangUnknown")]
public unsafe partial struct IGlobalSession
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(IGlobalSession* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(IGlobalSession* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(IGlobalSession* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _createSession(IGlobalSession* pThis, [NativeTypeName("const SessionDesc &")] SessionDesc* desc, ISession** outSession);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate SlangProfileID _findProfile(IGlobalSession* pThis, [NativeTypeName("const char *")] sbyte* name);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setDownstreamCompilerPath(IGlobalSession* pThis, SlangPassThrough passThrough, [NativeTypeName("const char *")] sbyte* path);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setDownstreamCompilerPrelude(IGlobalSession* pThis, SlangPassThrough passThrough, [NativeTypeName("const char *")] sbyte* preludeText);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _getDownstreamCompilerPrelude(IGlobalSession* pThis, SlangPassThrough passThrough, ISlangBlob** outPrelude);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const char *")]
    public delegate sbyte* _getBuildTagString(IGlobalSession* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _setDefaultDownstreamCompiler(IGlobalSession* pThis, SlangSourceLanguage sourceLanguage, SlangPassThrough defaultCompiler);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate SlangPassThrough _getDefaultDownstreamCompiler(IGlobalSession* pThis, SlangSourceLanguage sourceLanguage);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setLanguagePrelude(IGlobalSession* pThis, SlangSourceLanguage sourceLanguage, [NativeTypeName("const char *")] sbyte* preludeText);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _getLanguagePrelude(IGlobalSession* pThis, SlangSourceLanguage sourceLanguage, ISlangBlob** outPrelude);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _createCompileRequest(IGlobalSession* pThis, [NativeTypeName("slang::ICompileRequest **")] ICompileRequest** outCompileRequest);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _addBuiltins(IGlobalSession* pThis, [NativeTypeName("const char *")] sbyte* sourcePath, [NativeTypeName("const char *")] sbyte* sourceString);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setSharedLibraryLoader(IGlobalSession* pThis, ISlangSharedLibraryLoader* loader);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate ISlangSharedLibraryLoader* _getSharedLibraryLoader(IGlobalSession* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _checkCompileTargetSupport(IGlobalSession* pThis, SlangCompileTarget target);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _checkPassThroughSupport(IGlobalSession* pThis, SlangPassThrough passThrough);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _compileStdLib(IGlobalSession* pThis, [NativeTypeName("slang::CompileStdLibFlags")] uint flags);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _loadStdLib(IGlobalSession* pThis, [NativeTypeName("const void *")] void* stdLib, [NativeTypeName("size_t")] UIntPtr stdLibSizeInBytes);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _saveStdLib(IGlobalSession* pThis, SlangArchiveType archiveType, ISlangBlob** outBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate SlangCapabilityID _findCapability(IGlobalSession* pThis, [NativeTypeName("const char *")] sbyte* name);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _setDownstreamCompilerForTransition(IGlobalSession* pThis, SlangCompileTarget source, SlangCompileTarget target, SlangPassThrough compiler);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate SlangPassThrough _getDownstreamCompilerForTransition(IGlobalSession* pThis, SlangCompileTarget source, SlangCompileTarget target);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _getCompilerElapsedTime(IGlobalSession* pThis, double* outTotalTime, double* outDownstreamTime);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _setSPIRVCoreGrammar(IGlobalSession* pThis, [NativeTypeName("const char *")] sbyte* jsonPath);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.createSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int createSession([NativeTypeName("const SessionDesc &")] SessionDesc* desc, ISession** outSession)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createSession>(lpVtbl->createSession)(pThis, desc, outSession);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.findProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public SlangProfileID findProfile([NativeTypeName("const char *")] sbyte* name)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_findProfile>(lpVtbl->findProfile)(pThis, name);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.setDownstreamCompilerPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setDownstreamCompilerPath(SlangPassThrough passThrough, [NativeTypeName("const char *")] sbyte* path)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setDownstreamCompilerPath>(lpVtbl->setDownstreamCompilerPath)(pThis, passThrough, path);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.setDownstreamCompilerPrelude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setDownstreamCompilerPrelude(SlangPassThrough passThrough, [NativeTypeName("const char *")] sbyte* preludeText)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setDownstreamCompilerPrelude>(lpVtbl->setDownstreamCompilerPrelude)(pThis, passThrough, preludeText);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.getDownstreamCompilerPrelude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void getDownstreamCompilerPrelude(SlangPassThrough passThrough, ISlangBlob** outPrelude)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_getDownstreamCompilerPrelude>(lpVtbl->getDownstreamCompilerPrelude)(pThis, passThrough, outPrelude);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.getBuildTagString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const char *")]
    public sbyte* getBuildTagString()
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getBuildTagString>(lpVtbl->getBuildTagString)(pThis);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.setDefaultDownstreamCompiler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int setDefaultDownstreamCompiler(SlangSourceLanguage sourceLanguage, SlangPassThrough defaultCompiler)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_setDefaultDownstreamCompiler>(lpVtbl->setDefaultDownstreamCompiler)(pThis, sourceLanguage, defaultCompiler);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.getDefaultDownstreamCompiler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public SlangPassThrough getDefaultDownstreamCompiler(SlangSourceLanguage sourceLanguage)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDefaultDownstreamCompiler>(lpVtbl->getDefaultDownstreamCompiler)(pThis, sourceLanguage);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.setLanguagePrelude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setLanguagePrelude(SlangSourceLanguage sourceLanguage, [NativeTypeName("const char *")] sbyte* preludeText)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setLanguagePrelude>(lpVtbl->setLanguagePrelude)(pThis, sourceLanguage, preludeText);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.getLanguagePrelude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void getLanguagePrelude(SlangSourceLanguage sourceLanguage, ISlangBlob** outPrelude)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_getLanguagePrelude>(lpVtbl->getLanguagePrelude)(pThis, sourceLanguage, outPrelude);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.createCompileRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int createCompileRequest([NativeTypeName("slang::ICompileRequest **")] ICompileRequest** outCompileRequest)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createCompileRequest>(lpVtbl->createCompileRequest)(pThis, outCompileRequest);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.addBuiltins"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void addBuiltins([NativeTypeName("const char *")] sbyte* sourcePath, [NativeTypeName("const char *")] sbyte* sourceString)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_addBuiltins>(lpVtbl->addBuiltins)(pThis, sourcePath, sourceString);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.setSharedLibraryLoader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setSharedLibraryLoader(ISlangSharedLibraryLoader* loader)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setSharedLibraryLoader>(lpVtbl->setSharedLibraryLoader)(pThis, loader);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.getSharedLibraryLoader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ISlangSharedLibraryLoader* getSharedLibraryLoader()
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getSharedLibraryLoader>(lpVtbl->getSharedLibraryLoader)(pThis);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.checkCompileTargetSupport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int checkCompileTargetSupport(SlangCompileTarget target)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_checkCompileTargetSupport>(lpVtbl->checkCompileTargetSupport)(pThis, target);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.checkPassThroughSupport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int checkPassThroughSupport(SlangPassThrough passThrough)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_checkPassThroughSupport>(lpVtbl->checkPassThroughSupport)(pThis, passThrough);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.compileStdLib"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int compileStdLib([NativeTypeName("slang::CompileStdLibFlags")] uint flags)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_compileStdLib>(lpVtbl->compileStdLib)(pThis, flags);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.loadStdLib"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int loadStdLib([NativeTypeName("const void *")] void* stdLib, [NativeTypeName("size_t")] UIntPtr stdLibSizeInBytes)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadStdLib>(lpVtbl->loadStdLib)(pThis, stdLib, stdLibSizeInBytes);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.saveStdLib"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int saveStdLib(SlangArchiveType archiveType, ISlangBlob** outBlob)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_saveStdLib>(lpVtbl->saveStdLib)(pThis, archiveType, outBlob);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.findCapability"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public SlangCapabilityID findCapability([NativeTypeName("const char *")] sbyte* name)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_findCapability>(lpVtbl->findCapability)(pThis, name);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.setDownstreamCompilerForTransition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void setDownstreamCompilerForTransition(SlangCompileTarget source, SlangCompileTarget target, SlangPassThrough compiler)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_setDownstreamCompilerForTransition>(lpVtbl->setDownstreamCompilerForTransition)(pThis, source, target, compiler);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.getDownstreamCompilerForTransition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public SlangPassThrough getDownstreamCompilerForTransition(SlangCompileTarget source, SlangCompileTarget target)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDownstreamCompilerForTransition>(lpVtbl->getDownstreamCompilerForTransition)(pThis, source, target);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.getCompilerElapsedTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void getCompilerElapsedTime(double* outTotalTime, double* outDownstreamTime)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_getCompilerElapsedTime>(lpVtbl->getCompilerElapsedTime)(pThis, outTotalTime, outDownstreamTime);
        }
    }

    /// <include file='IGlobalSession.xml' path='doc/member[@name="IGlobalSession.setSPIRVCoreGrammar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int setSPIRVCoreGrammar([NativeTypeName("const char *")] sbyte* jsonPath)
    {
        fixed (IGlobalSession* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_setSPIRVCoreGrammar>(lpVtbl->setSPIRVCoreGrammar)(pThis, jsonPath);
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

        [NativeTypeName("SlangResult (const SessionDesc &, ISession **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createSession;

        [NativeTypeName("SlangProfileID (const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr findProfile;

        [NativeTypeName("void (SlangPassThrough, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setDownstreamCompilerPath;

        [NativeTypeName("void (SlangPassThrough, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setDownstreamCompilerPrelude;

        [NativeTypeName("void (SlangPassThrough, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDownstreamCompilerPrelude;

        [NativeTypeName("const char *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getBuildTagString;

        [NativeTypeName("SlangResult (SlangSourceLanguage, SlangPassThrough) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setDefaultDownstreamCompiler;

        [NativeTypeName("SlangPassThrough (SlangSourceLanguage) __attribute__((stdcall))")]
        public IntPtr getDefaultDownstreamCompiler;

        [NativeTypeName("void (SlangSourceLanguage, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setLanguagePrelude;

        [NativeTypeName("void (SlangSourceLanguage, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getLanguagePrelude;

        [NativeTypeName("SlangResult (slang::ICompileRequest **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createCompileRequest;

        [NativeTypeName("void (const char *, const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addBuiltins;

        [NativeTypeName("void (ISlangSharedLibraryLoader *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setSharedLibraryLoader;

        [NativeTypeName("ISlangSharedLibraryLoader *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getSharedLibraryLoader;

        [NativeTypeName("SlangResult (SlangCompileTarget) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr checkCompileTargetSupport;

        [NativeTypeName("SlangResult (SlangPassThrough) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr checkPassThroughSupport;

        [NativeTypeName("SlangResult (CompileStdLibFlags) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr compileStdLib;

        [NativeTypeName("SlangResult (const void *, size_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr loadStdLib;

        [NativeTypeName("SlangResult (SlangArchiveType, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr saveStdLib;

        [NativeTypeName("SlangCapabilityID (const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr findCapability;

        [NativeTypeName("void (SlangCompileTarget, SlangCompileTarget, SlangPassThrough) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setDownstreamCompilerForTransition;

        [NativeTypeName("SlangPassThrough (SlangCompileTarget, SlangCompileTarget) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDownstreamCompilerForTransition;

        [NativeTypeName("void (double *, double *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getCompilerElapsedTime;

        [NativeTypeName("SlangResult (const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setSPIRVCoreGrammar;
    }
}
