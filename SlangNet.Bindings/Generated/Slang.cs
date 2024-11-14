using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

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
    public const uint kDefaultTargetFlags = (uint)(SLANG_TARGET_FLAG_GENERATE_SPIRV_DIRECTLY);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetBuildTagString"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetBuildTagString", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetBuildTagString();

    [NativeTypeName("#define SLANG_FACILITY_WIN_GENERAL 0")]
    public const int SLANG_FACILITY_WIN_GENERAL = 0;

    [NativeTypeName("#define SLANG_FACILITY_WIN_INTERFACE 4")]
    public const int SLANG_FACILITY_WIN_INTERFACE = 4;

    [NativeTypeName("#define SLANG_FACILITY_WIN_API 7")]
    public const int SLANG_FACILITY_WIN_API = 7;

    [NativeTypeName("#define SLANG_FACILITY_BASE 0x200")]
    public const int SLANG_FACILITY_BASE = 0x200;

    [NativeTypeName("#define SLANG_FACILITY_CORE SLANG_FACILITY_BASE")]
    public const int SLANG_FACILITY_CORE = 0x200;

    [NativeTypeName("#define SLANG_FACILITY_INTERNAL SLANG_FACILITY_BASE + 1")]
    public const int SLANG_FACILITY_INTERNAL = 0x200 + 1;

    [NativeTypeName("#define SLANG_FACILITY_EXTERNAL_BASE 0x210")]
    public const int SLANG_FACILITY_EXTERNAL_BASE = 0x210;

    [NativeTypeName("#define SLANG_OK 0")]
    public const int SLANG_OK = 0;

    [NativeTypeName("#define SLANG_FAIL SLANG_MAKE_ERROR(SLANG_FACILITY_WIN_GENERAL, 0x4005)")]
    public const int SLANG_FAIL = unchecked((((int)(0)) << 16) | ((int)(0x4005)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_NOT_IMPLEMENTED SLANG_MAKE_WIN_GENERAL_ERROR(0x4001)")]
    public const int SLANG_E_NOT_IMPLEMENTED = unchecked((((int)(0)) << 16) | ((int)(0x4001)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_NO_INTERFACE SLANG_MAKE_WIN_GENERAL_ERROR(0x4002)")]
    public const int SLANG_E_NO_INTERFACE = unchecked((((int)(0)) << 16) | ((int)(0x4002)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_ABORT SLANG_MAKE_WIN_GENERAL_ERROR(0x4004)")]
    public const int SLANG_E_ABORT = unchecked((((int)(0)) << 16) | ((int)(0x4004)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_INVALID_HANDLE SLANG_MAKE_ERROR(SLANG_FACILITY_WIN_API, 6)")]
    public const int SLANG_E_INVALID_HANDLE = unchecked((((int)(7)) << 16) | ((int)(6)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_INVALID_ARG SLANG_MAKE_ERROR(SLANG_FACILITY_WIN_API, 0x57)")]
    public const int SLANG_E_INVALID_ARG = unchecked((((int)(7)) << 16) | ((int)(0x57)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_OUT_OF_MEMORY SLANG_MAKE_ERROR(SLANG_FACILITY_WIN_API, 0xe)")]
    public const int SLANG_E_OUT_OF_MEMORY = unchecked((((int)(7)) << 16) | ((int)(0xe)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_BUFFER_TOO_SMALL SLANG_MAKE_CORE_ERROR(1)")]
    public const int SLANG_E_BUFFER_TOO_SMALL = unchecked((((int)(0x200)) << 16) | ((int)(1)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_UNINITIALIZED SLANG_MAKE_CORE_ERROR(2)")]
    public const int SLANG_E_UNINITIALIZED = unchecked((((int)(0x200)) << 16) | ((int)(2)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_PENDING SLANG_MAKE_CORE_ERROR(3)")]
    public const int SLANG_E_PENDING = unchecked((((int)(0x200)) << 16) | ((int)(3)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_CANNOT_OPEN SLANG_MAKE_CORE_ERROR(4)")]
    public const int SLANG_E_CANNOT_OPEN = unchecked((((int)(0x200)) << 16) | ((int)(4)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_NOT_FOUND SLANG_MAKE_CORE_ERROR(5)")]
    public const int SLANG_E_NOT_FOUND = unchecked((((int)(0x200)) << 16) | ((int)(5)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_INTERNAL_FAIL SLANG_MAKE_CORE_ERROR(6)")]
    public const int SLANG_E_INTERNAL_FAIL = unchecked((((int)(0x200)) << 16) | ((int)(6)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_NOT_AVAILABLE SLANG_MAKE_CORE_ERROR(7)")]
    public const int SLANG_E_NOT_AVAILABLE = unchecked((((int)(0x200)) << 16) | ((int)(7)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_E_TIME_OUT SLANG_MAKE_CORE_ERROR(8)")]
    public const int SLANG_E_TIME_OUT = unchecked((((int)(0x200)) << 16) | ((int)(8)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_API_VERSION 0")]
    public const int SLANG_API_VERSION = 0;

    [NativeTypeName("#define SLANG_ERROR_INSUFFICIENT_BUFFER SLANG_E_BUFFER_TOO_SMALL")]
    public const int SLANG_ERROR_INSUFFICIENT_BUFFER = unchecked((((int)(0x200)) << 16) | ((int)(1)) | (int)(0x80000000));

    [NativeTypeName("#define SLANG_ERROR_INVALID_PARAMETER SLANG_E_INVALID_ARG")]
    public const int SLANG_ERROR_INVALID_PARAMETER = unchecked((((int)(7)) << 16) | ((int)(0x57)) | (int)(0x80000000));

    public const int kSessionFlags_None = 0;

    /// <include file='Slang.xml' path='doc/member[@name="Slang.slang_createGlobalSession"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int slang_createGlobalSession([NativeTypeName("SlangInt")] long apiVersion, [NativeTypeName("slang::IGlobalSession **")] IGlobalSession** outGlobalSession);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.slang_createGlobalSessionWithoutCoreModule"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int slang_createGlobalSessionWithoutCoreModule([NativeTypeName("SlangInt")] long apiVersion, [NativeTypeName("slang::IGlobalSession **")] IGlobalSession** outGlobalSession);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.slang_getEmbeddedCoreModule"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?slang_getEmbeddedCoreModule@@YAPEAUISlangBlob@@XZ", ExactSpelling = true)]
    public static extern ISlangBlob* slang_getEmbeddedCoreModule();

    /// <include file='Slang.xml' path='doc/member[@name="Slang.slang_shutdown"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void slang_shutdown();

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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CreateCompileRequest"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCreateCompileRequest", ExactSpelling = true)]
    [return: NativeTypeName("SlangCompileRequest *")]
    public static extern void* CreateCompileRequest([NativeTypeName("SlangSession *")] IGlobalSession* session);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.DestroyCompileRequest"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spDestroyCompileRequest", ExactSpelling = true)]
    public static extern void DestroyCompileRequest([NativeTypeName("SlangCompileRequest *")] void* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetFileSystem"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetFileSystem", ExactSpelling = true)]
    public static extern void SetFileSystem([NativeTypeName("SlangCompileRequest *")] void* request, ISlangFileSystem* fileSystem);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetCompileFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetCompileFlags", ExactSpelling = true)]
    public static extern void SetCompileFlags([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("SlangCompileFlags")] uint flags);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetCompileFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetCompileFlags", ExactSpelling = true)]
    [return: NativeTypeName("SlangCompileFlags")]
    public static extern uint GetCompileFlags([NativeTypeName("SlangCompileRequest *")] void* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDumpIntermediates"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDumpIntermediates", ExactSpelling = true)]
    public static extern void SetDumpIntermediates([NativeTypeName("SlangCompileRequest *")] void* request, int enable);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDumpIntermediatePrefix"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDumpIntermediatePrefix", ExactSpelling = true)]
    public static extern void SetDumpIntermediatePrefix([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("const char *")] sbyte* prefix);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetLineDirectiveMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetLineDirectiveMode", ExactSpelling = true)]
    public static extern void SetLineDirectiveMode([NativeTypeName("SlangCompileRequest *")] void* request, SlangLineDirectiveMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetLineDirectiveMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetLineDirectiveMode", ExactSpelling = true)]
    public static extern void SetTargetLineDirectiveMode([NativeTypeName("SlangCompileRequest *")] void* request, int targetIndex, SlangLineDirectiveMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetForceGLSLScalarBufferLayout"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetForceGLSLScalarBufferLayout", ExactSpelling = true)]
    public static extern void SetTargetForceGLSLScalarBufferLayout([NativeTypeName("SlangCompileRequest *")] void* request, int targetIndex, [NativeTypeName("bool")] byte forceScalarLayout);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetUseMinimumSlangOptimization"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetUseMinimumSlangOptimization", ExactSpelling = true)]
    public static extern void SetTargetUseMinimumSlangOptimization([NativeTypeName("slang::ICompileRequest *")] void* request, int targetIndex, [NativeTypeName("bool")] byte val);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetIgnoreCapabilityCheck"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetIgnoreCapabilityCheck", ExactSpelling = true)]
    public static extern void SetIgnoreCapabilityCheck([NativeTypeName("slang::ICompileRequest *")] void* request, [NativeTypeName("bool")] byte val);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetCodeGenTarget"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetCodeGenTarget", ExactSpelling = true)]
    public static extern void SetCodeGenTarget([NativeTypeName("SlangCompileRequest *")] void* request, SlangCompileTarget target);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddCodeGenTarget"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddCodeGenTarget", ExactSpelling = true)]
    public static extern int AddCodeGenTarget([NativeTypeName("SlangCompileRequest *")] void* request, SlangCompileTarget target);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetProfile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetProfile", ExactSpelling = true)]
    public static extern void SetTargetProfile([NativeTypeName("SlangCompileRequest *")] void* request, int targetIndex, SlangProfileID profile);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetFlags", ExactSpelling = true)]
    public static extern void SetTargetFlags([NativeTypeName("SlangCompileRequest *")] void* request, int targetIndex, [NativeTypeName("SlangTargetFlags")] uint flags);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetFloatingPointMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetFloatingPointMode", ExactSpelling = true)]
    public static extern void SetTargetFloatingPointMode([NativeTypeName("SlangCompileRequest *")] void* request, int targetIndex, SlangFloatingPointMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddTargetCapability"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddTargetCapability", ExactSpelling = true)]
    public static extern void AddTargetCapability([NativeTypeName("slang::ICompileRequest *")] void* request, int targetIndex, SlangCapabilityID capability);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTargetMatrixLayoutMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTargetMatrixLayoutMode", ExactSpelling = true)]
    public static extern void SetTargetMatrixLayoutMode([NativeTypeName("SlangCompileRequest *")] void* request, int targetIndex, SlangMatrixLayoutMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetMatrixLayoutMode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetMatrixLayoutMode", ExactSpelling = true)]
    public static extern void SetMatrixLayoutMode([NativeTypeName("SlangCompileRequest *")] void* request, SlangMatrixLayoutMode mode);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDebugInfoLevel"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDebugInfoLevel", ExactSpelling = true)]
    public static extern void SetDebugInfoLevel([NativeTypeName("SlangCompileRequest *")] void* request, SlangDebugInfoLevel level);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDebugInfoFormat"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDebugInfoFormat", ExactSpelling = true)]
    public static extern void SetDebugInfoFormat([NativeTypeName("SlangCompileRequest *")] void* request, SlangDebugInfoFormat format);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetOptimizationLevel"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetOptimizationLevel", ExactSpelling = true)]
    public static extern void SetOptimizationLevel([NativeTypeName("SlangCompileRequest *")] void* request, SlangOptimizationLevel level);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetOutputContainerFormat"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetOutputContainerFormat", ExactSpelling = true)]
    public static extern void SetOutputContainerFormat([NativeTypeName("SlangCompileRequest *")] void* request, SlangContainerFormat format);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetPassThrough"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetPassThrough", ExactSpelling = true)]
    public static extern void SetPassThrough([NativeTypeName("SlangCompileRequest *")] void* request, SlangPassThrough passThrough);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDiagnosticCallback"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDiagnosticCallback", ExactSpelling = true)]
    public static extern void SetDiagnosticCallback([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("SlangDiagnosticCallback")] IntPtr callback, [NativeTypeName("const void *")] void* userData);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetWriter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetWriter", ExactSpelling = true)]
    public static extern void SetWriter([NativeTypeName("SlangCompileRequest *")] void* request, SlangWriterChannel channel, ISlangWriter* writer);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetWriter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetWriter", ExactSpelling = true)]
    public static extern ISlangWriter* GetWriter([NativeTypeName("SlangCompileRequest *")] void* request, SlangWriterChannel channel);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddSearchPath"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddSearchPath", ExactSpelling = true)]
    public static extern void AddSearchPath([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("const char *")] sbyte* searchDir);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddPreprocessorDefine"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddPreprocessorDefine", ExactSpelling = true)]
    public static extern void AddPreprocessorDefine([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ProcessCommandLineArguments"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spProcessCommandLineArguments", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int ProcessCommandLineArguments([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("const char *const *")] sbyte** args, int argCount);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddTranslationUnit"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddTranslationUnit", ExactSpelling = true)]
    public static extern int AddTranslationUnit([NativeTypeName("SlangCompileRequest *")] void* request, SlangSourceLanguage language, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDefaultModuleName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDefaultModuleName", ExactSpelling = true)]
    public static extern void SetDefaultModuleName([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("const char *")] sbyte* defaultModuleName);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.TranslationUnit_addPreprocessorDefine"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spTranslationUnit_addPreprocessorDefine", ExactSpelling = true)]
    public static extern void TranslationUnit_addPreprocessorDefine([NativeTypeName("SlangCompileRequest *")] void* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddTranslationUnitSourceFile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddTranslationUnitSourceFile", ExactSpelling = true)]
    public static extern void AddTranslationUnitSourceFile([NativeTypeName("SlangCompileRequest *")] void* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddTranslationUnitSourceString"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddTranslationUnitSourceString", ExactSpelling = true)]
    public static extern void AddTranslationUnitSourceString([NativeTypeName("SlangCompileRequest *")] void* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* source);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddLibraryReference"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddLibraryReference", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int AddLibraryReference([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("const char *")] sbyte* basePath, [NativeTypeName("const void *")] void* libData, [NativeTypeName("size_t")] UIntPtr libDataSize);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddTranslationUnitSourceStringSpan"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddTranslationUnitSourceStringSpan", ExactSpelling = true)]
    public static extern void AddTranslationUnitSourceStringSpan([NativeTypeName("SlangCompileRequest *")] void* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* sourceBegin, [NativeTypeName("const char *")] sbyte* sourceEnd);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddTranslationUnitSourceBlob"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddTranslationUnitSourceBlob", ExactSpelling = true)]
    public static extern void AddTranslationUnitSourceBlob([NativeTypeName("SlangCompileRequest *")] void* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* path, ISlangBlob* sourceBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.FindProfile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spFindProfile", ExactSpelling = true)]
    public static extern SlangProfileID FindProfile([NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.FindCapability"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spFindCapability", ExactSpelling = true)]
    public static extern SlangCapabilityID FindCapability([NativeTypeName("SlangSession *")] IGlobalSession* session, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddEntryPoint"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddEntryPoint", ExactSpelling = true)]
    public static extern int AddEntryPoint([NativeTypeName("SlangCompileRequest *")] void* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* name, SlangStage stage);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.AddEntryPointEx"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spAddEntryPointEx", ExactSpelling = true)]
    public static extern int AddEntryPointEx([NativeTypeName("SlangCompileRequest *")] void* request, int translationUnitIndex, [NativeTypeName("const char *")] sbyte* name, SlangStage stage, int genericArgCount, [NativeTypeName("const char **")] sbyte** genericArgs);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetGlobalGenericArgs"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetGlobalGenericArgs", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int SetGlobalGenericArgs([NativeTypeName("SlangCompileRequest *")] void* request, int genericArgCount, [NativeTypeName("const char **")] sbyte** genericArgs);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTypeNameForGlobalExistentialTypeParam"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTypeNameForGlobalExistentialTypeParam", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int SetTypeNameForGlobalExistentialTypeParam([NativeTypeName("SlangCompileRequest *")] void* request, int slotIndex, [NativeTypeName("const char *")] sbyte* typeName);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetTypeNameForEntryPointExistentialTypeParam"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetTypeNameForEntryPointExistentialTypeParam", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int SetTypeNameForEntryPointExistentialTypeParam([NativeTypeName("SlangCompileRequest *")] void* request, int entryPointIndex, int slotIndex, [NativeTypeName("const char *")] sbyte* typeName);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Compile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCompile", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int Compile([NativeTypeName("SlangCompileRequest *")] void* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetDiagnosticOutput"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetDiagnosticOutput", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetDiagnosticOutput([NativeTypeName("SlangCompileRequest *")] void* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetDiagnosticOutputBlob"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetDiagnosticOutputBlob", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetDiagnosticOutputBlob([NativeTypeName("SlangCompileRequest *")] void* request, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetDependencyFileCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetDependencyFileCount", ExactSpelling = true)]
    public static extern int GetDependencyFileCount([NativeTypeName("SlangCompileRequest *")] void* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetDependencyFilePath"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetDependencyFilePath", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetDependencyFilePath([NativeTypeName("SlangCompileRequest *")] void* request, int index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetTranslationUnitCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetTranslationUnitCount", ExactSpelling = true)]
    public static extern int GetTranslationUnitCount([NativeTypeName("SlangCompileRequest *")] void* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetEntryPointSource"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetEntryPointSource", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetEntryPointSource([NativeTypeName("SlangCompileRequest *")] void* request, int entryPointIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetEntryPointCode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetEntryPointCode", ExactSpelling = true)]
    [return: NativeTypeName("const void *")]
    public static extern void* GetEntryPointCode([NativeTypeName("SlangCompileRequest *")] void* request, int entryPointIndex, [NativeTypeName("size_t *")] UIntPtr* outSize);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetEntryPointCodeBlob"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetEntryPointCodeBlob", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetEntryPointCodeBlob([NativeTypeName("SlangCompileRequest *")] void* request, int entryPointIndex, int targetIndex, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetEntryPointHostCallable"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetEntryPointHostCallable", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetEntryPointHostCallable([NativeTypeName("SlangCompileRequest *")] void* request, int entryPointIndex, int targetIndex, ISlangSharedLibrary** outSharedLibrary);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetTargetCodeBlob"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetTargetCodeBlob", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetTargetCodeBlob([NativeTypeName("SlangCompileRequest *")] void* request, int targetIndex, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetTargetHostCallable"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetTargetHostCallable", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetTargetHostCallable([NativeTypeName("SlangCompileRequest *")] void* request, int targetIndex, ISlangSharedLibrary** outSharedLibrary);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetCompileRequestCode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetCompileRequestCode", ExactSpelling = true)]
    [return: NativeTypeName("const void *")]
    public static extern void* GetCompileRequestCode([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("size_t *")] UIntPtr* outSize);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetContainerCode"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetContainerCode", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetContainerCode([NativeTypeName("SlangCompileRequest *")] void* request, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.LoadRepro"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spLoadRepro", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int LoadRepro([NativeTypeName("SlangCompileRequest *")] void* request, ISlangFileSystem* fileSystem, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr size);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SaveRepro"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSaveRepro", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int SaveRepro([NativeTypeName("SlangCompileRequest *")] void* request, ISlangBlob** outBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.EnableReproCapture"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spEnableReproCapture", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int EnableReproCapture([NativeTypeName("SlangCompileRequest *")] void* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetCompileTimeProfile"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetCompileTimeProfile", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int GetCompileTimeProfile([NativeTypeName("SlangCompileRequest *")] void* request, ISlangProfiler** compileTimeProfile, [NativeTypeName("bool")] byte shouldClear);

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
    public static extern void OverrideDiagnosticSeverity([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("SlangInt")] long messageID, SlangSeverity overrideSeverity);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetDiagnosticFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetDiagnosticFlags", ExactSpelling = true)]
    [return: NativeTypeName("SlangDiagnosticFlags")]
    public static extern int GetDiagnosticFlags([NativeTypeName("SlangCompileRequest *")] void* request);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.SetDiagnosticFlags"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spSetDiagnosticFlags", ExactSpelling = true)]
    public static extern void SetDiagnosticFlags([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("SlangDiagnosticFlags")] int flags);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetReflection"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetReflection", ExactSpelling = true)]
    [return: NativeTypeName("SlangReflection *")]
    public static extern SlangProgramLayout* GetReflection([NativeTypeName("SlangCompileRequest *")] void* request);

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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_applySpecializations"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_applySpecializations", ExactSpelling = true)]
    public static extern SlangReflectionType* ReflectionType_applySpecializations(SlangReflectionType* type, SlangReflectionGeneric* generic);

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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetFullName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetFullName", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int ReflectionType_GetFullName(SlangReflectionType* type, ISlangBlob** outNameBlob);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionType_GetGenericContainer"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionType_GetGenericContainer", ExactSpelling = true)]
    public static extern SlangReflectionGeneric* ReflectionType_GetGenericContainer(SlangReflectionType* type);

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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_GetFieldCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_GetFieldCount", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint ReflectionTypeLayout_GetFieldCount(SlangReflectionTypeLayout* type);

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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_isBindingRangeSpecializable"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_isBindingRangeSpecializable", ExactSpelling = true)]
    [return: NativeTypeName("SlangInt")]
    public static extern long ReflectionTypeLayout_isBindingRangeSpecializable(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionTypeLayout_getBindingRangeImageFormat"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionTypeLayout_getBindingRangeImageFormat", ExactSpelling = true)]
    public static extern SlangImageFormat ReflectionTypeLayout_getBindingRangeImageFormat(SlangReflectionTypeLayout* typeLayout, [NativeTypeName("SlangInt")] long index);

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
    public static extern SlangReflectionUserAttribute* ReflectionVariable_FindUserAttributeByName(SlangReflectionVariable* var, [NativeTypeName("SlangSession *")] IGlobalSession* globalSession, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariable_HasDefaultValue"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariable_HasDefaultValue", ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte ReflectionVariable_HasDefaultValue(SlangReflectionVariable* inVar);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariable_GetGenericContainer"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariable_GetGenericContainer", ExactSpelling = true)]
    public static extern SlangReflectionGeneric* ReflectionVariable_GetGenericContainer(SlangReflectionVariable* var);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionVariable_applySpecializations"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionVariable_applySpecializations", ExactSpelling = true)]
    public static extern SlangReflectionVariable* ReflectionVariable_applySpecializations(SlangReflectionVariable* var, SlangReflectionGeneric* generic);

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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_asDecl"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_asDecl", ExactSpelling = true)]
    public static extern SlangReflectionDecl* ReflectionFunction_asDecl(SlangReflectionFunction* func);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_GetName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_GetName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionFunction_GetName(SlangReflectionFunction* func);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_FindModifier"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_FindModifier", ExactSpelling = true)]
    public static extern SlangReflectionModifier* ReflectionFunction_FindModifier(SlangReflectionFunction* var, SlangModifierID modifierID);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_GetUserAttributeCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_GetUserAttributeCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionFunction_GetUserAttributeCount(SlangReflectionFunction* func);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_GetUserAttribute"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_GetUserAttribute", ExactSpelling = true)]
    public static extern SlangReflectionUserAttribute* ReflectionFunction_GetUserAttribute(SlangReflectionFunction* func, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_FindUserAttributeByName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_FindUserAttributeByName", ExactSpelling = true)]
    public static extern SlangReflectionUserAttribute* ReflectionFunction_FindUserAttributeByName(SlangReflectionFunction* func, [NativeTypeName("SlangSession *")] IGlobalSession* globalSession, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_GetParameterCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_GetParameterCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionFunction_GetParameterCount(SlangReflectionFunction* func);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_GetParameter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_GetParameter", ExactSpelling = true)]
    public static extern SlangReflectionVariable* ReflectionFunction_GetParameter(SlangReflectionFunction* func, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_GetResultType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_GetResultType", ExactSpelling = true)]
    public static extern SlangReflectionType* ReflectionFunction_GetResultType(SlangReflectionFunction* func);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_GetGenericContainer"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_GetGenericContainer", ExactSpelling = true)]
    public static extern SlangReflectionGeneric* ReflectionFunction_GetGenericContainer(SlangReflectionFunction* func);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_applySpecializations"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_applySpecializations", ExactSpelling = true)]
    public static extern SlangReflectionFunction* ReflectionFunction_applySpecializations(SlangReflectionFunction* func, SlangReflectionGeneric* generic);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_specializeWithArgTypes"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_specializeWithArgTypes", ExactSpelling = true)]
    public static extern SlangReflectionFunction* ReflectionFunction_specializeWithArgTypes(SlangReflectionFunction* func, [NativeTypeName("SlangInt")] long argTypeCount, [NativeTypeName("SlangReflectionType *const *")] SlangReflectionType** argTypes);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_isOverloaded"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_isOverloaded", ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte ReflectionFunction_isOverloaded(SlangReflectionFunction* func);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_getOverloadCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_getOverloadCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionFunction_getOverloadCount(SlangReflectionFunction* func);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionFunction_getOverload"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionFunction_getOverload", ExactSpelling = true)]
    public static extern SlangReflectionFunction* ReflectionFunction_getOverload(SlangReflectionFunction* func, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionDecl_getChildrenCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionDecl_getChildrenCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionDecl_getChildrenCount(SlangReflectionDecl* parentDecl);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionDecl_getChild"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionDecl_getChild", ExactSpelling = true)]
    public static extern SlangReflectionDecl* ReflectionDecl_getChild(SlangReflectionDecl* parentDecl, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionDecl_getName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionDecl_getName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionDecl_getName(SlangReflectionDecl* decl);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionDecl_getKind"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionDecl_getKind", ExactSpelling = true)]
    public static extern SlangDeclKind ReflectionDecl_getKind(SlangReflectionDecl* decl);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionDecl_castToFunction"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionDecl_castToFunction", ExactSpelling = true)]
    public static extern SlangReflectionFunction* ReflectionDecl_castToFunction(SlangReflectionDecl* decl);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionDecl_castToVariable"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionDecl_castToVariable", ExactSpelling = true)]
    public static extern SlangReflectionVariable* ReflectionDecl_castToVariable(SlangReflectionDecl* decl);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionDecl_castToGeneric"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionDecl_castToGeneric", ExactSpelling = true)]
    public static extern SlangReflectionGeneric* ReflectionDecl_castToGeneric(SlangReflectionDecl* decl);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_getTypeFromDecl"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_getTypeFromDecl", ExactSpelling = true)]
    public static extern SlangReflectionType* Reflection_getTypeFromDecl(SlangReflectionDecl* decl);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionDecl_getParent"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionDecl_getParent", ExactSpelling = true)]
    public static extern SlangReflectionDecl* ReflectionDecl_getParent(SlangReflectionDecl* decl);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_asDecl"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_asDecl", ExactSpelling = true)]
    public static extern SlangReflectionDecl* ReflectionGeneric_asDecl(SlangReflectionGeneric* generic);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_GetName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_GetName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionGeneric_GetName(SlangReflectionGeneric* generic);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_GetTypeParameterCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_GetTypeParameterCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionGeneric_GetTypeParameterCount(SlangReflectionGeneric* generic);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_GetTypeParameter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_GetTypeParameter", ExactSpelling = true)]
    public static extern SlangReflectionVariable* ReflectionGeneric_GetTypeParameter(SlangReflectionGeneric* generic, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_GetValueParameterCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_GetValueParameterCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionGeneric_GetValueParameterCount(SlangReflectionGeneric* generic);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_GetValueParameter"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_GetValueParameter", ExactSpelling = true)]
    public static extern SlangReflectionVariable* ReflectionGeneric_GetValueParameter(SlangReflectionGeneric* generic, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_GetTypeParameterConstraintCount"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_GetTypeParameterConstraintCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ReflectionGeneric_GetTypeParameterConstraintCount(SlangReflectionGeneric* generic, SlangReflectionVariable* typeParam);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_GetTypeParameterConstraintType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_GetTypeParameterConstraintType", ExactSpelling = true)]
    public static extern SlangReflectionType* ReflectionGeneric_GetTypeParameterConstraintType(SlangReflectionGeneric* generic, SlangReflectionVariable* typeParam, [NativeTypeName("unsigned int")] uint index);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_GetInnerKind"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_GetInnerKind", ExactSpelling = true)]
    public static extern SlangDeclKind ReflectionGeneric_GetInnerKind(SlangReflectionGeneric* generic);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_GetInnerDecl"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_GetInnerDecl", ExactSpelling = true)]
    public static extern SlangReflectionDecl* ReflectionGeneric_GetInnerDecl(SlangReflectionGeneric* generic);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_GetOuterGenericContainer"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_GetOuterGenericContainer", ExactSpelling = true)]
    public static extern SlangReflectionGeneric* ReflectionGeneric_GetOuterGenericContainer(SlangReflectionGeneric* generic);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_GetConcreteType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_GetConcreteType", ExactSpelling = true)]
    public static extern SlangReflectionType* ReflectionGeneric_GetConcreteType(SlangReflectionGeneric* generic, SlangReflectionVariable* typeParam);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_GetConcreteIntVal"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_GetConcreteIntVal", ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern long ReflectionGeneric_GetConcreteIntVal(SlangReflectionGeneric* generic, SlangReflectionVariable* valueParam);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionGeneric_applySpecializations"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionGeneric_applySpecializations", ExactSpelling = true)]
    public static extern SlangReflectionGeneric* ReflectionGeneric_applySpecializations(SlangReflectionGeneric* currGeneric, SlangReflectionGeneric* generic);

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
    public static extern int IsParameterLocationUsed([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("SlangInt")] long targetIndex, SlangParameterCategory category, [NativeTypeName("SlangUInt")] ulong spaceIndex, [NativeTypeName("SlangUInt")] ulong registerIndex, [NativeTypeName("bool &")] bool* outUsed);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_getName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_getName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionEntryPoint_getName([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_getNameOverride"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_getNameOverride", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ReflectionEntryPoint_getNameOverride([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_getFunction"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_getFunction", ExactSpelling = true)]
    public static extern SlangReflectionFunction* ReflectionEntryPoint_getFunction([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint);

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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.ReflectionEntryPoint_getComputeWaveSize"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflectionEntryPoint_getComputeWaveSize", ExactSpelling = true)]
    public static extern void ReflectionEntryPoint_getComputeWaveSize([NativeTypeName("SlangReflectionEntryPoint *")] SlangEntryPointLayout* entryPoint, [NativeTypeName("SlangUInt *")] ulong* outWaveSize);

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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_FindFunctionByName"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_FindFunctionByName", ExactSpelling = true)]
    public static extern SlangReflectionFunction* Reflection_FindFunctionByName([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_FindFunctionByNameInType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_FindFunctionByNameInType", ExactSpelling = true)]
    public static extern SlangReflectionFunction* Reflection_FindFunctionByNameInType([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, SlangReflectionType* reflType, [NativeTypeName("const char *")] sbyte* name);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_FindVarByNameInType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_FindVarByNameInType", ExactSpelling = true)]
    public static extern SlangReflectionVariable* Reflection_FindVarByNameInType([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, SlangReflectionType* reflType, [NativeTypeName("const char *")] sbyte* name);

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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_specializeGeneric"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_specializeGeneric", ExactSpelling = true)]
    public static extern SlangReflectionGeneric* Reflection_specializeGeneric([NativeTypeName("SlangReflection *")] SlangProgramLayout* inProgramLayout, SlangReflectionGeneric* generic, [NativeTypeName("SlangInt")] long argCount, [NativeTypeName("const SlangReflectionGenericArgType *")] SlangReflectionGenericArgType* argTypes, [NativeTypeName("const SlangReflectionGenericArg *")] SlangReflectionGenericArg* args, ISlangBlob** outDiagnostics);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_isSubType"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spReflection_isSubType", ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte Reflection_isSubType([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection, SlangReflectionType* subType, SlangReflectionType* superType);

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

    /// <include file='Slang.xml' path='doc/member[@name="Slang.GetTranslationUnitSource"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spGetTranslationUnitSource", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetTranslationUnitSource([NativeTypeName("SlangCompileRequest *")] void* request, int translationUnitIndex);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.Reflection_GetSession"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?spReflection_GetSession@@YAPEAUISession@slang@@PEAUSlangProgramLayout@@@Z", ExactSpelling = true)]
    [return: NativeTypeName("slang::ISession *")]
    public static extern ISession* Reflection_GetSession([NativeTypeName("SlangReflection *")] SlangProgramLayout* reflection);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CompileRequest_getProgram"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCompileRequest_getProgram", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int CompileRequest_getProgram([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("slang::IComponentType **")] IComponentType** outProgram);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CompileRequest_getProgramWithEntryPoints"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCompileRequest_getProgramWithEntryPoints", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int CompileRequest_getProgramWithEntryPoints([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("slang::IComponentType **")] IComponentType** outProgram);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CompileRequest_getEntryPoint"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCompileRequest_getEntryPoint", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int CompileRequest_getEntryPoint([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("SlangInt")] long entryPointIndex, [NativeTypeName("slang::IComponentType **")] IComponentType** outEntryPoint);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CompileRequest_getModule"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCompileRequest_getModule", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int CompileRequest_getModule([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("SlangInt")] long translationUnitIndex, [NativeTypeName("slang::IModule **")] IModule** outModule);

    /// <include file='Slang.xml' path='doc/member[@name="Slang.CompileRequest_getSession"]/*' />
    [DllImport("slang", CallingConvention = CallingConvention.Cdecl, EntryPoint = "spCompileRequest_getSession", ExactSpelling = true)]
    [return: NativeTypeName("SlangResult")]
    public static extern int CompileRequest_getSession([NativeTypeName("SlangCompileRequest *")] void* request, [NativeTypeName("slang::ISession **")] ISession** outSession);
}
