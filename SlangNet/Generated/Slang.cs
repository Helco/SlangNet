using System;
using System.Runtime.InteropServices;

namespace SlangNet;

public static unsafe partial class Slang
{
    public const int SLANG_DIAGNOSTIC_FLAG_VERBOSE_PATHS = 0x01;
    public const int SLANG_DIAGNOSTIC_FLAG_TREAT_WARNINGS_AS_ERRORS = 0x02;

    public const int SLANG_COMPILE_FLAG_NO_MANGLING = 1 << 3;
    public const int SLANG_COMPILE_FLAG_NO_CODEGEN = 1 << 4;
    public const int SLANG_COMPILE_FLAG_OBFUSCATE = 1 << 5;
    public const int SLANG_COMPILE_FLAG_NO_CHECKING = 0;
    public const int SLANG_COMPILE_FLAG_SPLIT_MIXED_TYPES = 0;

    public const int SLANG_TARGET_FLAG_PARAMETER_BLOCKS_USE_REGISTER_SPACES = 1 << 4;
    public const int SLANG_TARGET_FLAG_GENERATE_WHOLE_PROGRAM = 1 << 8;
    public const int SLANG_TARGET_FLAG_DUMP_IR = 1 << 9;
    public const int SLANG_TARGET_FLAG_GENERATE_SPIRV_DIRECTLY = 1 << 10;

    [NativeTypeName("const SlangTargetFlags")]
    public const uint kDefaultTargetFlags = 0;

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spCreateSession"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangSession *")]
    public static extern IGlobalSession* spCreateSession([NativeTypeName("const char *")] sbyte* deprecated = null);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spDestroySession"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spDestroySession([NativeTypeName("SlangSession *")] IGlobalSession* session);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSessionSetSharedLibraryLoader"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSessionSetSharedLibraryLoader([NativeTypeName("SlangSession *")] IGlobalSession* session, ISlangSharedLibraryLoader* loader);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSessionGetSharedLibraryLoader"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISlangSharedLibraryLoader* spSessionGetSharedLibraryLoader([NativeTypeName("SlangSession *")] IGlobalSession* session);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSessionCheckCompileTargetSupport"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spSessionCheckCompileTargetSupport([NativeTypeName("SlangSession *")] IGlobalSession* session, SlangCompileTarget target);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSessionCheckPassThroughSupport"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spSessionCheckPassThroughSupport([NativeTypeName("SlangSession *")] IGlobalSession* session, SlangPassThrough passThrough);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddBuiltins"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spAddBuiltins([NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const char *")] sbyte* sourcePath, [NativeTypeName("const char *")] sbyte* sourceString);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetBuildTagString"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spGetBuildTagString();

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spCreateCompileRequest"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangCompileRequest *")]
    public static extern ICompileRequest* spCreateCompileRequest([NativeTypeName("SlangSession *")] IGlobalSession* session);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spDestroyCompileRequest"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spDestroyCompileRequest([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetFileSystem"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetFileSystem([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, ISlangFileSystem* fileSystem);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetCompileFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetCompileFlags([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangCompileFlags")] uint flags);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetCompileFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangCompileFlags")]
    public static extern uint spGetCompileFlags([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetDumpIntermediates"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetDumpIntermediates([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int enable);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetDumpIntermediatePrefix"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetDumpIntermediatePrefix([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("const char *")] sbyte* prefix);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetLineDirectiveMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetLineDirectiveMode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangLineDirectiveMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetTargetLineDirectiveMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetTargetLineDirectiveMode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, SlangLineDirectiveMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetTargetForceGLSLScalarBufferLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetTargetForceGLSLScalarBufferLayout([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, [NativeTypeName("bool")] byte forceScalarLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetCodeGenTarget"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetCodeGenTarget([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangCompileTarget target);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddCodeGenTarget"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int spAddCodeGenTarget([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangCompileTarget target);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetTargetProfile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetTargetProfile([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, SlangProfileID profile);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetTargetFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetTargetFlags([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, [NativeTypeName("SlangTargetFlags")] uint flags);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetTargetFloatingPointMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetTargetFloatingPointMode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, SlangFloatingPointMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddTargetCapability"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spAddTargetCapability([NativeTypeName("slang::ICompileRequest *")] ICompileRequest* request, int targetIndex, SlangCapabilityID capability);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetTargetMatrixLayoutMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetTargetMatrixLayoutMode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, SlangMatrixLayoutMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetMatrixLayoutMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetMatrixLayoutMode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangMatrixLayoutMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetDebugInfoLevel"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetDebugInfoLevel([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangDebugInfoLevel level);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetDebugInfoFormat"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetDebugInfoFormat([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangDebugInfoFormat format);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetOptimizationLevel"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetOptimizationLevel([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangOptimizationLevel level);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetOutputContainerFormat"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetOutputContainerFormat([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangContainerFormat format);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetPassThrough"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetPassThrough([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangPassThrough passThrough);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetDiagnosticCallback"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetDiagnosticCallback([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangDiagnosticCallback")] IntPtr callback, [NativeTypeName("const void *")] void* userData);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetWriter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetWriter([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangWriterChannel channel, ISlangWriter* writer);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetWriter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ISlangWriter* spGetWriter([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangWriterChannel channel);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddSearchPath"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spAddSearchPath([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("const char *")] sbyte* searchDir);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddPreprocessorDefine"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spAddPreprocessorDefine([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spProcessCommandLineArguments"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spProcessCommandLineArguments([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("const char *const *")] sbyte** args, int argCount);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddTranslationUnit"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int spAddTranslationUnit([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangSourceLanguage language, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetDefaultModuleName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetDefaultModuleName([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("const char *")] sbyte* defaultModuleName);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spTranslationUnit_addPreprocessorDefine"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spTranslationUnit_addPreprocessorDefine([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddTranslationUnitSourceFile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spAddTranslationUnitSourceFile([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddTranslationUnitSourceString"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spAddTranslationUnitSourceString([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* source);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddLibraryReference"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spAddLibraryReference([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("const void *")] void* libData, [NativeTypeName("size_t")] UIntPtr libDataSize);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddTranslationUnitSourceStringSpan"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spAddTranslationUnitSourceStringSpan([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* sourceBegin, [NativeTypeName("const char *")] sbyte* sourceEnd);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddTranslationUnitSourceBlob"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spAddTranslationUnitSourceBlob([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, ISlangBlob* sourceBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spFindProfile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangProfileID spFindProfile([NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spFindCapability"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangCapabilityID spFindCapability([NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddEntryPoint"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int spAddEntryPoint([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* name, SlangStage stage);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spAddEntryPointEx"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int spAddEntryPointEx([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* name, SlangStage stage, int genericArgCount, [NativeTypeName("const char **")] sbyte** genericArgs);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetGlobalGenericArgs"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spSetGlobalGenericArgs([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int genericArgCount, [NativeTypeName("const char **")] sbyte** genericArgs);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetTypeNameForGlobalExistentialTypeParam"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spSetTypeNameForGlobalExistentialTypeParam([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int slotIndex, [NativeTypeName("const char *")] sbyte* typeName);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetTypeNameForEntryPointExistentialTypeParam"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spSetTypeNameForEntryPointExistentialTypeParam([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int entryPointIndex, int slotIndex, [NativeTypeName("const char *")] sbyte* typeName);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spCompile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spCompile([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetDiagnosticOutput"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spGetDiagnosticOutput([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetDiagnosticOutputBlob"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spGetDiagnosticOutputBlob([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetDependencyFileCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int spGetDependencyFileCount([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetDependencyFilePath"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spGetDependencyFilePath([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetTranslationUnitCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int spGetTranslationUnitCount([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetEntryPointSource"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spGetEntryPointSource([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int entryPointIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetEntryPointCode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const void *")]
    public static extern void* spGetEntryPointCode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int entryPointIndex, [NativeTypeName("size_t *")] UIntPtr* outSize);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetEntryPointCodeBlob"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spGetEntryPointCodeBlob([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int entryPointIndex, int targetIndex, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetEntryPointHostCallable"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spGetEntryPointHostCallable([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetTargetCodeBlob"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spGetTargetCodeBlob([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetTargetHostCallable"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spGetTargetHostCallable([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, ISlangSharedLibrary** outSharedLibrary);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetCompileRequestCode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const void *")]
    public static extern void* spGetCompileRequestCode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("size_t *")] UIntPtr* outSize);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetContainerCode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spGetContainerCode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spLoadRepro"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spLoadRepro([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, ISlangFileSystem* fileSystem, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr size);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSaveRepro"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spSaveRepro([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spEnableReproCapture"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spEnableReproCapture([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spExtractRepro"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spExtractRepro([NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const void *")] void* reproData, [NativeTypeName("size_t")] UIntPtr reproDataSize, ISlangMutableFileSystem* fileSystem);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spLoadReproAsFileSystem"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spLoadReproAsFileSystem([NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const void *")] void* reproData, [NativeTypeName("size_t")] UIntPtr reproDataSize, ISlangFileSystem* replaceFileSystem, ISlangFileSystemExt** outFileSystem);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spOverrideDiagnosticSeverity"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spOverrideDiagnosticSeverity([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangInt")] long messageID, SlangSeverity overrideSeverity);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetDiagnosticFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangDiagnosticFlags")]
    public static extern int spGetDiagnosticFlags([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spSetDiagnosticFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spSetDiagnosticFlags([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangDiagnosticFlags")] int flags);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetReflection"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangReflection *")]
    public static extern SlangProgramLayout* spGetReflection([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionUserAttribute_GetName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spReflectionUserAttribute_GetName(SlangReflectionUserAttribute* attrib);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionUserAttribute_GetArgumentCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflectionUserAttribute_GetArgumentCount(SlangReflectionUserAttribute* attrib);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionUserAttribute_GetArgumentType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionType* spReflectionUserAttribute_GetArgumentType(SlangReflectionUserAttribute* attrib, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionUserAttribute_GetArgumentValueInt"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spReflectionUserAttribute_GetArgumentValueInt(SlangReflectionUserAttribute* attrib, [NativeTypeName("unsigned int")] uint index, int* rs);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionUserAttribute_GetArgumentValueFloat"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spReflectionUserAttribute_GetArgumentValueFloat(SlangReflectionUserAttribute* attrib, [NativeTypeName("unsigned int")] uint index, float* rs);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionUserAttribute_GetArgumentValueString"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spReflectionUserAttribute_GetArgumentValueString(SlangReflectionUserAttribute* attrib, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("size_t *")] UIntPtr* outSize);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetKind"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangTypeKind spReflectionType_GetKind(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetUserAttributeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflectionType_GetUserAttributeCount(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetUserAttribute"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionUserAttribute* spReflectionType_GetUserAttribute(SlangReflectionType* type, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_FindUserAttributeByName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionUserAttribute* spReflectionType_FindUserAttributeByName(SlangReflectionType* type, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetFieldCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflectionType_GetFieldCount(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetFieldByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariable* spReflectionType_GetFieldByIndex(SlangReflectionType* type, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetElementCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr spReflectionType_GetElementCount(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetElementType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionType* spReflectionType_GetElementType(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetRowCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflectionType_GetRowCount(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetColumnCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflectionType_GetColumnCount(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetScalarType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangScalarType spReflectionType_GetScalarType(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetResourceShape"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangResourceShape spReflectionType_GetResourceShape(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetResourceAccess"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangResourceAccess spReflectionType_GetResourceAccess(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetResourceResultType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionType* spReflectionType_GetResourceResultType(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_GetName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spReflectionType_GetName(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_GetType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionType* spReflectionTypeLayout_GetType(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getKind"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangTypeKind spReflectionTypeLayout_getKind(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_GetSize"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr spReflectionTypeLayout_GetSize(SlangReflectionTypeLayout* type, SlangParameterCategory category);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_GetStride"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr spReflectionTypeLayout_GetStride(SlangReflectionTypeLayout* type, SlangParameterCategory category);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getAlignment"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int32_t")]
    public static extern int spReflectionTypeLayout_getAlignment(SlangReflectionTypeLayout* type, SlangParameterCategory category);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_GetFieldByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* spReflectionTypeLayout_GetFieldByIndex(SlangReflectionTypeLayout* type, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_findFieldIndexByName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_findFieldIndexByName(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("const char *")] sbyte* nameBegin, [NativeTypeName("const char *")] sbyte* nameEnd);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_GetExplicitCounter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* spReflectionTypeLayout_GetExplicitCounter(SlangReflectionTypeLayout* typeLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_GetElementStride"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr spReflectionTypeLayout_GetElementStride(SlangReflectionTypeLayout* type, SlangParameterCategory category);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_GetElementTypeLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionTypeLayout* spReflectionTypeLayout_GetElementTypeLayout(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_GetElementVarLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* spReflectionTypeLayout_GetElementVarLayout(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getContainerVarLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* spReflectionTypeLayout_getContainerVarLayout(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_GetParameterCategory"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangParameterCategory spReflectionTypeLayout_GetParameterCategory(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_GetCategoryCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflectionTypeLayout_GetCategoryCount(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_GetCategoryByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangParameterCategory spReflectionTypeLayout_GetCategoryByIndex(SlangReflectionTypeLayout* type, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_GetMatrixLayoutMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangMatrixLayoutMode spReflectionTypeLayout_GetMatrixLayoutMode(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getGenericParamIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int spReflectionTypeLayout_getGenericParamIndex(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getPendingDataTypeLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionTypeLayout* spReflectionTypeLayout_getPendingDataTypeLayout(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getSpecializedTypePendingDataVarLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* spReflectionTypeLayout_getSpecializedTypePendingDataVarLayout(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_getSpecializedTypeArgCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionType_getSpecializedTypeArgCount(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionType_getSpecializedTypeArgType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionType* spReflectionType_getSpecializedTypeArgType(SlangReflectionType* type, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getBindingRangeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getBindingRangeCount(SlangReflectionTypeLayout* typeLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getBindingRangeType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangBindingType spReflectionTypeLayout_getBindingRangeType(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getBindingRangeBindingCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getBindingRangeBindingCount(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getBindingRangeLeafTypeLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionTypeLayout* spReflectionTypeLayout_getBindingRangeLeafTypeLayout(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getBindingRangeLeafVariable"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariable* spReflectionTypeLayout_getBindingRangeLeafVariable(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getFieldBindingRangeOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getFieldBindingRangeOffset(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long fieldIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getExplicitCounterBindingRangeOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getExplicitCounterBindingRangeOffset(SlangReflectionTypeLayout* inTypeLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getBindingRangeDescriptorSetIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getBindingRangeDescriptorSetIndex(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getBindingRangeFirstDescriptorRangeIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getBindingRangeFirstDescriptorRangeIndex(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getBindingRangeDescriptorRangeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getBindingRangeDescriptorRangeCount(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getDescriptorSetCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getDescriptorSetCount(SlangReflectionTypeLayout* typeLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getDescriptorSetSpaceOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getDescriptorSetSpaceOffset(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long setIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getDescriptorSetDescriptorRangeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getDescriptorSetDescriptorRangeCount(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long setIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getDescriptorSetDescriptorRangeIndexOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getDescriptorSetDescriptorRangeIndexOffset(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long setIndex, [NativeTypeName("SlangInt")] long rangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getDescriptorSetDescriptorRangeDescriptorCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getDescriptorSetDescriptorRangeDescriptorCount(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long setIndex, [NativeTypeName("SlangInt")] long rangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getDescriptorSetDescriptorRangeType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangBindingType spReflectionTypeLayout_getDescriptorSetDescriptorRangeType(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long setIndex, [NativeTypeName("SlangInt")] long rangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getDescriptorSetDescriptorRangeCategory"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangParameterCategory spReflectionTypeLayout_getDescriptorSetDescriptorRangeCategory(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long setIndex, [NativeTypeName("SlangInt")] long rangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getSubObjectRangeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getSubObjectRangeCount(SlangReflectionTypeLayout* typeLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getSubObjectRangeBindingRangeIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getSubObjectRangeBindingRangeIndex(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long subObjectRangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getSubObjectRangeSpaceOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long spReflectionTypeLayout_getSubObjectRangeSpaceOffset(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long subObjectRangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeLayout_getSubObjectRangeOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* spReflectionTypeLayout_getSubObjectRangeOffset(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long subObjectRangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariable_GetName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spReflectionVariable_GetName(SlangReflectionVariable* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariable_GetType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionType* spReflectionVariable_GetType(SlangReflectionVariable* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariable_FindModifier"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionModifier* spReflectionVariable_FindModifier(SlangReflectionVariable* var, SlangModifierID modifierID);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariable_GetUserAttributeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflectionVariable_GetUserAttributeCount(SlangReflectionVariable* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariable_GetUserAttribute"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionUserAttribute* spReflectionVariable_GetUserAttribute(SlangReflectionVariable* var, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariable_FindUserAttributeByName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionUserAttribute* spReflectionVariable_FindUserAttributeByName(SlangReflectionVariable* var, [NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariableLayout_GetVariable"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariable* spReflectionVariableLayout_GetVariable(SlangReflectionVariableLayout* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariableLayout_GetTypeLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionTypeLayout* spReflectionVariableLayout_GetTypeLayout(SlangReflectionVariableLayout* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariableLayout_GetOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr spReflectionVariableLayout_GetOffset(SlangReflectionVariableLayout* var, SlangParameterCategory category);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariableLayout_GetSpace"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr spReflectionVariableLayout_GetSpace(SlangReflectionVariableLayout* var, SlangParameterCategory category);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariableLayout_GetSemanticName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spReflectionVariableLayout_GetSemanticName(SlangReflectionVariableLayout* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariableLayout_GetSemanticIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr spReflectionVariableLayout_GetSemanticIndex(SlangReflectionVariableLayout* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariableLayout_getStage"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangStage spReflectionVariableLayout_getStage(SlangReflectionVariableLayout* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionVariableLayout_getPendingDataLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* spReflectionVariableLayout_getPendingDataLayout(SlangReflectionVariableLayout* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionParameter_GetBindingIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflectionParameter_GetBindingIndex([NativeTypeName("SlangReflectionParameter *")] SlangReflectionVariableLayout* parameter);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionParameter_GetBindingSpace"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflectionParameter_GetBindingSpace([NativeTypeName("SlangReflectionParameter *")] SlangReflectionVariableLayout* parameter);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spIsParameterLocationUsed"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spIsParameterLocationUsed([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, SlangParameterCategory category, [NativeTypeName("SlangUInt")] ulong spaceIndex, [NativeTypeName("SlangUInt")] ulong registerIndex, [NativeTypeName("bool &")] bool* outUsed);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionEntryPoint_getName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spReflectionEntryPoint_getName([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionEntryPoint_getNameOverride"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spReflectionEntryPoint_getNameOverride([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionEntryPoint_getParameterCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflectionEntryPoint_getParameterCount([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionEntryPoint_getParameterByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* spReflectionEntryPoint_getParameterByIndex([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionEntryPoint_getStage"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangStage spReflectionEntryPoint_getStage([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionEntryPoint_getComputeThreadGroupSize"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void spReflectionEntryPoint_getComputeThreadGroupSize([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint, [NativeTypeName("SlangUInt")] ulong axisCount, [NativeTypeName("SlangUInt *")] ulong* outSizeAlongAxis);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionEntryPoint_usesAnySampleRateInput"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int spReflectionEntryPoint_usesAnySampleRateInput([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionEntryPoint_getVarLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* spReflectionEntryPoint_getVarLayout([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionEntryPoint_getResultVarLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* spReflectionEntryPoint_getResultVarLayout([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionEntryPoint_hasDefaultConstantBuffer"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int spReflectionEntryPoint_hasDefaultConstantBuffer([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeParameter_GetName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spReflectionTypeParameter_GetName(SlangReflectionTypeParameter* typeParam);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeParameter_GetIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflectionTypeParameter_GetIndex(SlangReflectionTypeParameter* typeParam);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeParameter_GetConstraintCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflectionTypeParameter_GetConstraintCount(SlangReflectionTypeParameter* typeParam);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflectionTypeParameter_GetConstraintByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionType* spReflectionTypeParameter_GetConstraintByIndex(SlangReflectionTypeParameter* typeParam, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_GetParameterCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflection_GetParameterCount([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_GetParameterByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangReflectionParameter *")]
    public static extern SlangReflectionVariableLayout* spReflection_GetParameterByIndex([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_GetTypeParameterCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint spReflection_GetTypeParameterCount([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_GetTypeParameterByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionTypeParameter* spReflection_GetTypeParameterByIndex([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_FindTypeParameter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionTypeParameter* spReflection_FindTypeParameter([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_FindTypeByName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionType* spReflection_FindTypeByName([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_GetTypeLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionTypeLayout* spReflection_GetTypeLayout([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, SlangReflectionType* reflectionType, SlangLayoutRules rules);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_getEntryPointCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangUInt")]
    public static extern ulong spReflection_getEntryPointCount([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_getEntryPointByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangReflectionEntryPoint *")]
    public static extern SlangEntryPointLayout* spReflection_getEntryPointByIndex([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("SlangUInt")] ulong index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_findEntryPointByName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangReflectionEntryPoint *")]
    public static extern SlangEntryPointLayout* spReflection_findEntryPointByName([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_getGlobalConstantBufferBinding"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangUInt")]
    public static extern ulong spReflection_getGlobalConstantBufferBinding([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_getGlobalConstantBufferSize"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr spReflection_getGlobalConstantBufferSize([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_specializeType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionType* spReflection_specializeType([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, SlangReflectionType* type, [NativeTypeName("SlangInt")] long specializationArgCount, [NativeTypeName("SlangReflectionType *const *")] SlangReflectionType** specializationArgs, ISlangBlob** outDiagnostics);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_getHashedStringCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangUInt")]
    public static extern ulong spReflection_getHashedStringCount([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_getHashedString"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spReflection_getHashedString([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("SlangUInt")] ulong index, [NativeTypeName("size_t *")] UIntPtr* outCount);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spComputeStringHash"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangUInt32")]
    public static extern uint spComputeStringHash([NativeTypeName("const char *")] sbyte* chars, [NativeTypeName("size_t")] UIntPtr count);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_getGlobalParamsTypeLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionTypeLayout* spReflection_getGlobalParamsTypeLayout([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spReflection_getGlobalParamsVarLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* spReflection_getGlobalParamsVarLayout([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    public const int kSessionFlags_None = 0;
    public const int kSessionFlag_FalcorCustomSharedKeywordSemantics = 1 << 0;

    /// <include file='Slang.xml' path='doc/member[@name="Slang.slang_createGlobalSession"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int slang_createGlobalSession([NativeTypeName("SlangInt")] long apiVersion, [NativeTypeName("slang::IGlobalSession **")] IGlobalSession** outGlobalSession);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.slang_createGlobalSessionWithoutStdLib"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int slang_createGlobalSessionWithoutStdLib([NativeTypeName("SlangInt")] long apiVersion, [NativeTypeName("slang::IGlobalSession **")] IGlobalSession** outGlobalSession);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.slang_getEmbeddedStdLib"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?slang_getEmbeddedStdLib@@YAPEAUISlangBlob@@XZ", ExactSpelling = true)]
    public static extern ISlangBlob* slang_getEmbeddedStdLib();

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spCompileRequest_getProgram"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spCompileRequest_getProgram([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("slang::IComponentType **")] IComponentType** outProgram);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spCompileRequest_getProgramWithEntryPoints"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spCompileRequest_getProgramWithEntryPoints([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("slang::IComponentType **")] IComponentType** outProgram);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spCompileRequest_getEntryPoint"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spCompileRequest_getEntryPoint([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("slang::IComponentType **")] IComponentType** outEntryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spCompileRequest_getModule"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spCompileRequest_getModule([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangInt")] long translationUnitIndex, [NativeTypeName("slang::IModule **")] IModule** outModule);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spCompileRequest_getSession"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int spCompileRequest_getSession([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("slang::ISession **")] ISession** outSession);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.spGetTranslationUnitSource"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* spGetTranslationUnitSource([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex);
}
