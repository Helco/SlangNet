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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CreateSession"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCreateSession", ExactSpelling = true)]
    [return: NativeTypeName("SlangSession *")]
    public static extern IGlobalSession* CreateSession([NativeTypeName("const char *")] sbyte* deprecated = null);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.DestroySession"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spDestroySession", ExactSpelling = true)]
    public static extern void DestroySession([NativeTypeName("SlangSession *")] IGlobalSession* session);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SessionSetSharedLibraryLoader"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSessionSetSharedLibraryLoader", ExactSpelling = true)]
    public static extern void SessionSetSharedLibraryLoader([NativeTypeName("SlangSession *")] IGlobalSession* session, ISlangSharedLibraryLoader* loader);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SessionGetSharedLibraryLoader"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSessionGetSharedLibraryLoader", ExactSpelling = true)]
    public static extern ISlangSharedLibraryLoader* SessionGetSharedLibraryLoader([NativeTypeName("SlangSession *")] IGlobalSession* session);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SessionCheckCompileTargetSupport"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSessionCheckCompileTargetSupport", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int SessionCheckCompileTargetSupport([NativeTypeName("SlangSession *")] IGlobalSession* session, SlangCompileTarget target);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SessionCheckPassThroughSupport"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSessionCheckPassThroughSupport", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int SessionCheckPassThroughSupport([NativeTypeName("SlangSession *")] IGlobalSession* session, SlangPassThrough passThrough);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddBuiltins"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddBuiltins", ExactSpelling = true)]
    public static extern void AddBuiltins([NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const char *")] sbyte* sourcePath, [NativeTypeName("const char *")] sbyte* sourceString);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetBuildTagString"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetBuildTagString", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetBuildTagString();

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CreateCompileRequest"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCreateCompileRequest", ExactSpelling = true)]
    [return: NativeTypeName("SlangCompileRequest *")]
    public static extern ICompileRequest* CreateCompileRequest([NativeTypeName("SlangSession *")] IGlobalSession* session);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.DestroyCompileRequest"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spDestroyCompileRequest", ExactSpelling = true)]
    public static extern void DestroyCompileRequest([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetFileSystem"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetFileSystem", ExactSpelling = true)]
    public static extern void SetFileSystem([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, ISlangFileSystem* fileSystem);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetCompileFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetCompileFlags", ExactSpelling = true)]
    public static extern void SetCompileFlags([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangCompileFlags")] uint flags);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetCompileFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetCompileFlags", ExactSpelling = true)]
    [return: NativeTypeName("SlangCompileFlags")]
    public static extern uint GetCompileFlags([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDumpIntermediates"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDumpIntermediates", ExactSpelling = true)]
    public static extern void SetDumpIntermediates([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int enable);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDumpIntermediatePrefix"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDumpIntermediatePrefix", ExactSpelling = true)]
    public static extern void SetDumpIntermediatePrefix([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("const char *")] sbyte* prefix);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetLineDirectiveMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetLineDirectiveMode", ExactSpelling = true)]
    public static extern void SetLineDirectiveMode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangLineDirectiveMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetLineDirectiveMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetLineDirectiveMode", ExactSpelling = true)]
    public static extern void SetTargetLineDirectiveMode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, SlangLineDirectiveMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetForceGLSLScalarBufferLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetForceGLSLScalarBufferLayout", ExactSpelling = true)]
    public static extern void SetTargetForceGLSLScalarBufferLayout([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, [NativeTypeName("bool")] byte forceScalarLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetCodeGenTarget"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetCodeGenTarget", ExactSpelling = true)]
    public static extern void SetCodeGenTarget([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangCompileTarget target);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddCodeGenTarget"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddCodeGenTarget", ExactSpelling = true)]
    public static extern int AddCodeGenTarget([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangCompileTarget target);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetProfile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetProfile", ExactSpelling = true)]
    public static extern void SetTargetProfile([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, SlangProfileID profile);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetFlags", ExactSpelling = true)]
    public static extern void SetTargetFlags([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, [NativeTypeName("SlangTargetFlags")] uint flags);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetFloatingPointMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetFloatingPointMode", ExactSpelling = true)]
    public static extern void SetTargetFloatingPointMode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, SlangFloatingPointMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddTargetCapability"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddTargetCapability", ExactSpelling = true)]
    public static extern void AddTargetCapability([NativeTypeName("slang::ICompileRequest *")] ICompileRequest* request, int targetIndex, SlangCapabilityID capability);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetMatrixLayoutMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetMatrixLayoutMode", ExactSpelling = true)]
    public static extern void SetTargetMatrixLayoutMode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, SlangMatrixLayoutMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetMatrixLayoutMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetMatrixLayoutMode", ExactSpelling = true)]
    public static extern void SetMatrixLayoutMode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangMatrixLayoutMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDebugInfoLevel"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDebugInfoLevel", ExactSpelling = true)]
    public static extern void SetDebugInfoLevel([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangDebugInfoLevel level);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDebugInfoFormat"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDebugInfoFormat", ExactSpelling = true)]
    public static extern void SetDebugInfoFormat([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangDebugInfoFormat format);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetOptimizationLevel"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetOptimizationLevel", ExactSpelling = true)]
    public static extern void SetOptimizationLevel([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangOptimizationLevel level);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetOutputContainerFormat"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetOutputContainerFormat", ExactSpelling = true)]
    public static extern void SetOutputContainerFormat([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangContainerFormat format);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetPassThrough"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetPassThrough", ExactSpelling = true)]
    public static extern void SetPassThrough([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangPassThrough passThrough);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDiagnosticCallback"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDiagnosticCallback", ExactSpelling = true)]
    public static extern void SetDiagnosticCallback([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangDiagnosticCallback")] IntPtr callback, [NativeTypeName("const void *")] void* userData);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetWriter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetWriter", ExactSpelling = true)]
    public static extern void SetWriter([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangWriterChannel channel, ISlangWriter* writer);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetWriter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetWriter", ExactSpelling = true)]
    public static extern ISlangWriter* GetWriter([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangWriterChannel channel);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddSearchPath"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddSearchPath", ExactSpelling = true)]
    public static extern void AddSearchPath([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("const char *")] sbyte* searchDir);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddPreprocessorDefine"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddPreprocessorDefine", ExactSpelling = true)]
    public static extern void AddPreprocessorDefine([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ProcessCommandLineArguments"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spProcessCommandLineArguments", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int ProcessCommandLineArguments([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("const char *const *")] sbyte** args, int argCount);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddTranslationUnit"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddTranslationUnit", ExactSpelling = true)]
    public static extern int AddTranslationUnit([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, SlangSourceLanguage language, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDefaultModuleName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDefaultModuleName", ExactSpelling = true)]
    public static extern void SetDefaultModuleName([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("const char *")] sbyte* defaultModuleName);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.TranslationUnit_addPreprocessorDefine"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spTranslationUnit_addPreprocessorDefine", ExactSpelling = true)]
    public static extern void TranslationUnit_addPreprocessorDefine([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddTranslationUnitSourceFile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddTranslationUnitSourceFile", ExactSpelling = true)]
    public static extern void AddTranslationUnitSourceFile([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddTranslationUnitSourceString"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddTranslationUnitSourceString", ExactSpelling = true)]
    public static extern void AddTranslationUnitSourceString([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* source);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddLibraryReference"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddLibraryReference", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int AddLibraryReference([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("const void *")] void* libData, [NativeTypeName("size_t")] UIntPtr libDataSize);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddTranslationUnitSourceStringSpan"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddTranslationUnitSourceStringSpan", ExactSpelling = true)]
    public static extern void AddTranslationUnitSourceStringSpan([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* sourceBegin, [NativeTypeName("const char *")] sbyte* sourceEnd);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddTranslationUnitSourceBlob"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddTranslationUnitSourceBlob", ExactSpelling = true)]
    public static extern void AddTranslationUnitSourceBlob([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, ISlangBlob* sourceBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.FindProfile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spFindProfile", ExactSpelling = true)]
    public static extern SlangProfileID FindProfile([NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.FindCapability"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spFindCapability", ExactSpelling = true)]
    public static extern SlangCapabilityID FindCapability([NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddEntryPoint"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddEntryPoint", ExactSpelling = true)]
    public static extern int AddEntryPoint([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* name, SlangStage stage);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddEntryPointEx"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddEntryPointEx", ExactSpelling = true)]
    public static extern int AddEntryPointEx([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* name, SlangStage stage, int genericArgCount, [NativeTypeName("const char **")] sbyte** genericArgs);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetGlobalGenericArgs"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetGlobalGenericArgs", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int SetGlobalGenericArgs([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int genericArgCount, [NativeTypeName("const char **")] sbyte** genericArgs);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTypeNameForGlobalExistentialTypeParam"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTypeNameForGlobalExistentialTypeParam", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int SetTypeNameForGlobalExistentialTypeParam([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int slotIndex, [NativeTypeName("const char *")] sbyte* typeName);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTypeNameForEntryPointExistentialTypeParam"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTypeNameForEntryPointExistentialTypeParam", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int SetTypeNameForEntryPointExistentialTypeParam([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int entryPointIndex, int slotIndex, [NativeTypeName("const char *")] sbyte* typeName);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Compile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCompile", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int Compile([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetDiagnosticOutput"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetDiagnosticOutput", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetDiagnosticOutput([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetDiagnosticOutputBlob"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetDiagnosticOutputBlob", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetDiagnosticOutputBlob([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetDependencyFileCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetDependencyFileCount", ExactSpelling = true)]
    public static extern int GetDependencyFileCount([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetDependencyFilePath"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetDependencyFilePath", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetDependencyFilePath([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetTranslationUnitCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetTranslationUnitCount", ExactSpelling = true)]
    public static extern int GetTranslationUnitCount([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetEntryPointSource"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetEntryPointSource", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetEntryPointSource([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int entryPointIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetEntryPointCode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetEntryPointCode", ExactSpelling = true)]
    [return: NativeTypeName("const void *")]
    public static extern void* GetEntryPointCode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int entryPointIndex, [NativeTypeName("size_t *")] UIntPtr* outSize);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetEntryPointCodeBlob"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetEntryPointCodeBlob", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetEntryPointCodeBlob([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int entryPointIndex, int targetIndex, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetEntryPointHostCallable"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetEntryPointHostCallable", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetEntryPointHostCallable([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetTargetCodeBlob"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetTargetCodeBlob", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetTargetCodeBlob([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetTargetHostCallable"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetTargetHostCallable", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetTargetHostCallable([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int targetIndex, ISlangSharedLibrary** outSharedLibrary);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetCompileRequestCode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetCompileRequestCode", ExactSpelling = true)]
    [return: NativeTypeName("const void *")]
    public static extern void* GetCompileRequestCode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("size_t *")] UIntPtr* outSize);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetContainerCode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetContainerCode", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetContainerCode([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.LoadRepro"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spLoadRepro", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int LoadRepro([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, ISlangFileSystem* fileSystem, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr size);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SaveRepro"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSaveRepro", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int SaveRepro([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.EnableReproCapture"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spEnableReproCapture", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int EnableReproCapture([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ExtractRepro"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spExtractRepro", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int ExtractRepro([NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const void *")] void* reproData, [NativeTypeName("size_t")] UIntPtr reproDataSize, ISlangMutableFileSystem* fileSystem);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.LoadReproAsFileSystem"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spLoadReproAsFileSystem", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int LoadReproAsFileSystem([NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const void *")] void* reproData, [NativeTypeName("size_t")] UIntPtr reproDataSize, ISlangFileSystem* replaceFileSystem, ISlangFileSystemExt** outFileSystem);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.OverrideDiagnosticSeverity"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spOverrideDiagnosticSeverity", ExactSpelling = true)]
    public static extern void OverrideDiagnosticSeverity([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangInt")] long messageID, SlangSeverity overrideSeverity);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetDiagnosticFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetDiagnosticFlags", ExactSpelling = true)]
    [return: NativeTypeName("SlangDiagnosticFlags")]
    public static extern int GetDiagnosticFlags([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDiagnosticFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDiagnosticFlags", ExactSpelling = true)]
    public static extern void SetDiagnosticFlags([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangDiagnosticFlags")] int flags);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetReflection"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetReflection", ExactSpelling = true)]
    [return: NativeTypeName("SlangReflection *")]
    public static extern SlangProgramLayout* GetReflection([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionUserAttribute_GetName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionUserAttribute_GetName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionUserAttribute_GetName(SlangReflectionUserAttribute* attrib);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionUserAttribute_GetArgumentCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionUserAttribute_GetArgumentCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionUserAttribute_GetArgumentCount(SlangReflectionUserAttribute* attrib);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionUserAttribute_GetArgumentType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionUserAttribute_GetArgumentType", ExactSpelling = true)]
    public static extern SlangReflectionType* ReflectionUserAttribute_GetArgumentType(SlangReflectionUserAttribute* attrib, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionUserAttribute_GetArgumentValueInt"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionUserAttribute_GetArgumentValueInt", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int ReflectionUserAttribute_GetArgumentValueInt(SlangReflectionUserAttribute* attrib, [NativeTypeName("unsigned int")] uint index, int* rs);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionUserAttribute_GetArgumentValueFloat"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionUserAttribute_GetArgumentValueFloat", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int ReflectionUserAttribute_GetArgumentValueFloat(SlangReflectionUserAttribute* attrib, [NativeTypeName("unsigned int")] uint index, float* rs);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionUserAttribute_GetArgumentValueString"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionUserAttribute_GetArgumentValueString", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionUserAttribute_GetArgumentValueString(SlangReflectionUserAttribute* attrib, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("size_t *")] UIntPtr* outSize);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetKind"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetKind", ExactSpelling = true)]
    public static extern SlangTypeKind ReflectionType_GetKind(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetUserAttributeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetUserAttributeCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionType_GetUserAttributeCount(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetUserAttribute"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetUserAttribute", ExactSpelling = true)]
    public static extern SlangReflectionUserAttribute* ReflectionType_GetUserAttribute(SlangReflectionType* type, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_FindUserAttributeByName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_FindUserAttributeByName", ExactSpelling = true)]
    public static extern SlangReflectionUserAttribute* ReflectionType_FindUserAttributeByName(SlangReflectionType* type, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetFieldCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetFieldCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionType_GetFieldCount(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetFieldByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetFieldByIndex", ExactSpelling = true)]
    public static extern SlangReflectionVariable* ReflectionType_GetFieldByIndex(SlangReflectionType* type, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetElementCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetElementCount", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr ReflectionType_GetElementCount(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetElementType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetElementType", ExactSpelling = true)]
    public static extern SlangReflectionType* ReflectionType_GetElementType(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetRowCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetRowCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionType_GetRowCount(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetColumnCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetColumnCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionType_GetColumnCount(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetScalarType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetScalarType", ExactSpelling = true)]
    public static extern SlangScalarType ReflectionType_GetScalarType(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetResourceShape"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetResourceShape", ExactSpelling = true)]
    public static extern SlangResourceShape ReflectionType_GetResourceShape(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetResourceAccess"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetResourceAccess", ExactSpelling = true)]
    public static extern SlangResourceAccess ReflectionType_GetResourceAccess(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetResourceResultType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetResourceResultType", ExactSpelling = true)]
    public static extern SlangReflectionType* ReflectionType_GetResourceResultType(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionType_GetName(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetType", ExactSpelling = true)]
    public static extern SlangReflectionType* ReflectionTypeLayout_GetType(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getKind"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getKind", ExactSpelling = true)]
    public static extern SlangTypeKind ReflectionTypeLayout_getKind(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetSize"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetSize", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr ReflectionTypeLayout_GetSize(SlangReflectionTypeLayout* type, SlangParameterCategory category);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetStride"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetStride", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr ReflectionTypeLayout_GetStride(SlangReflectionTypeLayout* type, SlangParameterCategory category);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getAlignment"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getAlignment", ExactSpelling = true)]
    [return: NativeTypeName("int32_t")]
    public static extern int ReflectionTypeLayout_getAlignment(SlangReflectionTypeLayout* type, SlangParameterCategory category);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetFieldByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetFieldByIndex", ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* ReflectionTypeLayout_GetFieldByIndex(SlangReflectionTypeLayout* type, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_findFieldIndexByName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_findFieldIndexByName", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_findFieldIndexByName(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("const char *")] sbyte* nameBegin, [NativeTypeName("const char *")] sbyte* nameEnd);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetExplicitCounter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetExplicitCounter", ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* ReflectionTypeLayout_GetExplicitCounter(SlangReflectionTypeLayout* typeLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetElementStride"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetElementStride", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr ReflectionTypeLayout_GetElementStride(SlangReflectionTypeLayout* type, SlangParameterCategory category);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetElementTypeLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetElementTypeLayout", ExactSpelling = true)]
    public static extern SlangReflectionTypeLayout* ReflectionTypeLayout_GetElementTypeLayout(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetElementVarLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetElementVarLayout", ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* ReflectionTypeLayout_GetElementVarLayout(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getContainerVarLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getContainerVarLayout", ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* ReflectionTypeLayout_getContainerVarLayout(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetParameterCategory"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetParameterCategory", ExactSpelling = true)]
    public static extern SlangParameterCategory ReflectionTypeLayout_GetParameterCategory(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetCategoryCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetCategoryCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionTypeLayout_GetCategoryCount(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetCategoryByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetCategoryByIndex", ExactSpelling = true)]
    public static extern SlangParameterCategory ReflectionTypeLayout_GetCategoryByIndex(SlangReflectionTypeLayout* type, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetMatrixLayoutMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetMatrixLayoutMode", ExactSpelling = true)]
    public static extern SlangMatrixLayoutMode ReflectionTypeLayout_GetMatrixLayoutMode(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getGenericParamIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getGenericParamIndex", ExactSpelling = true)]
    public static extern int ReflectionTypeLayout_getGenericParamIndex(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getPendingDataTypeLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getPendingDataTypeLayout", ExactSpelling = true)]
    public static extern SlangReflectionTypeLayout* ReflectionTypeLayout_getPendingDataTypeLayout(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getSpecializedTypePendingDataVarLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getSpecializedTypePendingDataVarLayout", ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* ReflectionTypeLayout_getSpecializedTypePendingDataVarLayout(SlangReflectionTypeLayout* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_getSpecializedTypeArgCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_getSpecializedTypeArgCount", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionType_getSpecializedTypeArgCount(SlangReflectionType* type);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_getSpecializedTypeArgType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_getSpecializedTypeArgType", ExactSpelling = true)]
    public static extern SlangReflectionType* ReflectionType_getSpecializedTypeArgType(SlangReflectionType* type, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getBindingRangeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getBindingRangeCount", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getBindingRangeCount(SlangReflectionTypeLayout* typeLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getBindingRangeType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getBindingRangeType", ExactSpelling = true)]
    public static extern SlangBindingType ReflectionTypeLayout_getBindingRangeType(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getBindingRangeBindingCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getBindingRangeBindingCount", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getBindingRangeBindingCount(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getBindingRangeLeafTypeLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getBindingRangeLeafTypeLayout", ExactSpelling = true)]
    public static extern SlangReflectionTypeLayout* ReflectionTypeLayout_getBindingRangeLeafTypeLayout(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getBindingRangeLeafVariable"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getBindingRangeLeafVariable", ExactSpelling = true)]
    public static extern SlangReflectionVariable* ReflectionTypeLayout_getBindingRangeLeafVariable(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getFieldBindingRangeOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getFieldBindingRangeOffset", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getFieldBindingRangeOffset(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long fieldIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getExplicitCounterBindingRangeOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getExplicitCounterBindingRangeOffset", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getExplicitCounterBindingRangeOffset(SlangReflectionTypeLayout* inTypeLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getBindingRangeDescriptorSetIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getBindingRangeDescriptorSetIndex", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getBindingRangeDescriptorSetIndex(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getBindingRangeFirstDescriptorRangeIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getBindingRangeFirstDescriptorRangeIndex", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getBindingRangeFirstDescriptorRangeIndex(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getBindingRangeDescriptorRangeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getBindingRangeDescriptorRangeCount", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getBindingRangeDescriptorRangeCount(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getDescriptorSetCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getDescriptorSetCount", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getDescriptorSetCount(SlangReflectionTypeLayout* typeLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getDescriptorSetSpaceOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getDescriptorSetSpaceOffset", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getDescriptorSetSpaceOffset(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long setIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getDescriptorSetDescriptorRangeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getDescriptorSetDescriptorRangeCount", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getDescriptorSetDescriptorRangeCount(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long setIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getDescriptorSetDescriptorRangeIndexOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getDescriptorSetDescriptorRangeIndexOffset", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getDescriptorSetDescriptorRangeIndexOffset(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long setIndex, [NativeTypeName("SlangInt")] long rangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getDescriptorSetDescriptorRangeDescriptorCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getDescriptorSetDescriptorRangeDescriptorCount", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getDescriptorSetDescriptorRangeDescriptorCount(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long setIndex, [NativeTypeName("SlangInt")] long rangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getDescriptorSetDescriptorRangeType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getDescriptorSetDescriptorRangeType", ExactSpelling = true)]
    public static extern SlangBindingType ReflectionTypeLayout_getDescriptorSetDescriptorRangeType(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long setIndex, [NativeTypeName("SlangInt")] long rangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getDescriptorSetDescriptorRangeCategory"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getDescriptorSetDescriptorRangeCategory", ExactSpelling = true)]
    public static extern SlangParameterCategory ReflectionTypeLayout_getDescriptorSetDescriptorRangeCategory(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long setIndex, [NativeTypeName("SlangInt")] long rangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getSubObjectRangeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getSubObjectRangeCount", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getSubObjectRangeCount(SlangReflectionTypeLayout* typeLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getSubObjectRangeBindingRangeIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getSubObjectRangeBindingRangeIndex", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getSubObjectRangeBindingRangeIndex(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long subObjectRangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getSubObjectRangeSpaceOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getSubObjectRangeSpaceOffset", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_getSubObjectRangeSpaceOffset(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long subObjectRangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getSubObjectRangeOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getSubObjectRangeOffset", ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* ReflectionTypeLayout_getSubObjectRangeOffset(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long subObjectRangeIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariable_GetName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariable_GetName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionVariable_GetName(SlangReflectionVariable* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariable_GetType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariable_GetType", ExactSpelling = true)]
    public static extern SlangReflectionType* ReflectionVariable_GetType(SlangReflectionVariable* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariable_FindModifier"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariable_FindModifier", ExactSpelling = true)]
    public static extern SlangReflectionModifier* ReflectionVariable_FindModifier(SlangReflectionVariable* var, SlangModifierID modifierID);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariable_GetUserAttributeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariable_GetUserAttributeCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionVariable_GetUserAttributeCount(SlangReflectionVariable* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariable_GetUserAttribute"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariable_GetUserAttribute", ExactSpelling = true)]
    public static extern SlangReflectionUserAttribute* ReflectionVariable_GetUserAttribute(SlangReflectionVariable* var, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariable_FindUserAttributeByName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariable_FindUserAttributeByName", ExactSpelling = true)]
    public static extern SlangReflectionUserAttribute* ReflectionVariable_FindUserAttributeByName(SlangReflectionVariable* var, [NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariableLayout_GetVariable"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariableLayout_GetVariable", ExactSpelling = true)]
    public static extern SlangReflectionVariable* ReflectionVariableLayout_GetVariable(SlangReflectionVariableLayout* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariableLayout_GetTypeLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariableLayout_GetTypeLayout", ExactSpelling = true)]
    public static extern SlangReflectionTypeLayout* ReflectionVariableLayout_GetTypeLayout(SlangReflectionVariableLayout* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariableLayout_GetOffset"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariableLayout_GetOffset", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr ReflectionVariableLayout_GetOffset(SlangReflectionVariableLayout* var, SlangParameterCategory category);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariableLayout_GetSpace"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariableLayout_GetSpace", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr ReflectionVariableLayout_GetSpace(SlangReflectionVariableLayout* var, SlangParameterCategory category);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariableLayout_GetSemanticName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariableLayout_GetSemanticName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionVariableLayout_GetSemanticName(SlangReflectionVariableLayout* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariableLayout_GetSemanticIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariableLayout_GetSemanticIndex", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr ReflectionVariableLayout_GetSemanticIndex(SlangReflectionVariableLayout* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariableLayout_getStage"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariableLayout_getStage", ExactSpelling = true)]
    public static extern SlangStage ReflectionVariableLayout_getStage(SlangReflectionVariableLayout* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariableLayout_getPendingDataLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariableLayout_getPendingDataLayout", ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* ReflectionVariableLayout_getPendingDataLayout(SlangReflectionVariableLayout* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionParameter_GetBindingIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionParameter_GetBindingIndex", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionParameter_GetBindingIndex([NativeTypeName("SlangReflectionParameter *")] SlangReflectionVariableLayout* parameter);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionParameter_GetBindingSpace"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionParameter_GetBindingSpace", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionParameter_GetBindingSpace([NativeTypeName("SlangReflectionParameter *")] SlangReflectionVariableLayout* parameter);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.IsParameterLocationUsed"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spIsParameterLocationUsed", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int IsParameterLocationUsed([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, SlangParameterCategory category, [NativeTypeName("SlangUInt")] ulong spaceIndex, [NativeTypeName("SlangUInt")] ulong registerIndex, [NativeTypeName("bool &")] bool* outUsed);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_getName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_getName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionEntryPoint_getName([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_getNameOverride"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_getNameOverride", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionEntryPoint_getNameOverride([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_getParameterCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_getParameterCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionEntryPoint_getParameterCount([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_getParameterByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_getParameterByIndex", ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* ReflectionEntryPoint_getParameterByIndex([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_getStage"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_getStage", ExactSpelling = true)]
    public static extern SlangStage ReflectionEntryPoint_getStage([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_getComputeThreadGroupSize"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_getComputeThreadGroupSize", ExactSpelling = true)]
    public static extern void ReflectionEntryPoint_getComputeThreadGroupSize([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint, [NativeTypeName("SlangUInt")] ulong axisCount, [NativeTypeName("SlangUInt *")] ulong* outSizeAlongAxis);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_usesAnySampleRateInput"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_usesAnySampleRateInput", ExactSpelling = true)]
    public static extern int ReflectionEntryPoint_usesAnySampleRateInput([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_getVarLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_getVarLayout", ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* ReflectionEntryPoint_getVarLayout([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_getResultVarLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_getResultVarLayout", ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* ReflectionEntryPoint_getResultVarLayout([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_hasDefaultConstantBuffer"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_hasDefaultConstantBuffer", ExactSpelling = true)]
    public static extern int ReflectionEntryPoint_hasDefaultConstantBuffer([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeParameter_GetName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeParameter_GetName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionTypeParameter_GetName(SlangReflectionTypeParameter* typeParam);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeParameter_GetIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeParameter_GetIndex", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionTypeParameter_GetIndex(SlangReflectionTypeParameter* typeParam);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeParameter_GetConstraintCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeParameter_GetConstraintCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionTypeParameter_GetConstraintCount(SlangReflectionTypeParameter* typeParam);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeParameter_GetConstraintByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeParameter_GetConstraintByIndex", ExactSpelling = true)]
    public static extern SlangReflectionType* ReflectionTypeParameter_GetConstraintByIndex(SlangReflectionTypeParameter* typeParam, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_GetParameterCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_GetParameterCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Reflection_GetParameterCount([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_GetParameterByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_GetParameterByIndex", ExactSpelling = true)]
    [return: NativeTypeName("SlangReflectionParameter *")]
    public static extern SlangReflectionVariableLayout* Reflection_GetParameterByIndex([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_GetTypeParameterCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_GetTypeParameterCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Reflection_GetTypeParameterCount([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_GetTypeParameterByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_GetTypeParameterByIndex", ExactSpelling = true)]
    public static extern SlangReflectionTypeParameter* Reflection_GetTypeParameterByIndex([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_FindTypeParameter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_FindTypeParameter", ExactSpelling = true)]
    public static extern SlangReflectionTypeParameter* Reflection_FindTypeParameter([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_FindTypeByName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_FindTypeByName", ExactSpelling = true)]
    public static extern SlangReflectionType* Reflection_FindTypeByName([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_GetTypeLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_GetTypeLayout", ExactSpelling = true)]
    public static extern SlangReflectionTypeLayout* Reflection_GetTypeLayout([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, SlangReflectionType* reflectionType, SlangLayoutRules rules);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_getEntryPointCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_getEntryPointCount", ExactSpelling = true)]
    [return: NativeTypeName("SlangUInt")]
    public static extern ulong Reflection_getEntryPointCount([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_getEntryPointByIndex"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_getEntryPointByIndex", ExactSpelling = true)]
    [return: NativeTypeName("SlangReflectionEntryPoint *")]
    public static extern SlangEntryPointLayout* Reflection_getEntryPointByIndex([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("SlangUInt")] ulong index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_findEntryPointByName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_findEntryPointByName", ExactSpelling = true)]
    [return: NativeTypeName("SlangReflectionEntryPoint *")]
    public static extern SlangEntryPointLayout* Reflection_findEntryPointByName([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_getGlobalConstantBufferBinding"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_getGlobalConstantBufferBinding", ExactSpelling = true)]
    [return: NativeTypeName("SlangUInt")]
    public static extern ulong Reflection_getGlobalConstantBufferBinding([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_getGlobalConstantBufferSize"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_getGlobalConstantBufferSize", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern UIntPtr Reflection_getGlobalConstantBufferSize([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_specializeType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_specializeType", ExactSpelling = true)]
    public static extern SlangReflectionType* Reflection_specializeType([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, SlangReflectionType* type, [NativeTypeName("SlangInt")] long specializationArgCount, [NativeTypeName("SlangReflectionType *const *")] SlangReflectionType** specializationArgs, ISlangBlob** outDiagnostics);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_getHashedStringCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_getHashedStringCount", ExactSpelling = true)]
    [return: NativeTypeName("SlangUInt")]
    public static extern ulong Reflection_getHashedStringCount([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_getHashedString"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_getHashedString", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* Reflection_getHashedString([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("SlangUInt")] ulong index, [NativeTypeName("size_t *")] UIntPtr* outCount);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ComputeStringHash"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spComputeStringHash", ExactSpelling = true)]
    [return: NativeTypeName("SlangUInt32")]
    public static extern uint ComputeStringHash([NativeTypeName("const char *")] sbyte* chars, [NativeTypeName("size_t")] UIntPtr count);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_getGlobalParamsTypeLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_getGlobalParamsTypeLayout", ExactSpelling = true)]
    public static extern SlangReflectionTypeLayout* Reflection_getGlobalParamsTypeLayout([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_getGlobalParamsVarLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_getGlobalParamsVarLayout", ExactSpelling = true)]
    public static extern SlangReflectionVariableLayout* Reflection_getGlobalParamsVarLayout([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CompileRequest_getProgram"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCompileRequest_getProgram", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int CompileRequest_getProgram([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("slang::IComponentType **")] IComponentType** outProgram);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CompileRequest_getProgramWithEntryPoints"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCompileRequest_getProgramWithEntryPoints", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int CompileRequest_getProgramWithEntryPoints([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("slang::IComponentType **")] IComponentType** outProgram);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CompileRequest_getEntryPoint"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCompileRequest_getEntryPoint", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int CompileRequest_getEntryPoint([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("slang::IComponentType **")] IComponentType** outEntryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CompileRequest_getModule"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCompileRequest_getModule", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int CompileRequest_getModule([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("SlangInt")] long translationUnitIndex, [NativeTypeName("slang::IModule **")] IModule** outModule);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CompileRequest_getSession"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCompileRequest_getSession", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int CompileRequest_getSession([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, [NativeTypeName("slang::ISession **")] ISession** outSession);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetTranslationUnitSource"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetTranslationUnitSource", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetTranslationUnitSource([NativeTypeName("SlangCompileRequest *")] ICompileRequest* request, int translationUnitIndex);
}
