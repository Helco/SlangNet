#pragma once

// copied from original slang submodule because of some ClangSharp problems

#include "../slang/include/slang.h"

/* DEPRECATED DEFINITIONS

Everything in this file represents deprecated APIs/definition that are only
being kept around for source/binary compatibility with old client code. New
code should not use any of these declarations, and the Slang API will drop these
declarations over time.
*/

#ifdef __cplusplus
extern "C"
{
#endif


    /*!
    @brief Clean up after an instance of the Slang library.
    */
    SLANG_API void spDestroySession(SlangSession* session);

    /** @see slang::IGlobalSession::setSharedLibraryLoader
     */
    SLANG_API void spSessionSetSharedLibraryLoader(
        SlangSession* session,
        ISlangSharedLibraryLoader* loader);

    /** @see slang::IGlobalSession::getSharedLibraryLoader
     */
    SLANG_API ISlangSharedLibraryLoader* spSessionGetSharedLibraryLoader(SlangSession* session);

    /** @see slang::IGlobalSession::checkCompileTargetSupport
     */
    SLANG_API SlangResult
    spSessionCheckCompileTargetSupport(SlangSession* session, SlangCompileTarget target);

    /** @see slang::IGlobalSession::checkPassThroughSupport
     */
    SLANG_API SlangResult
    spSessionCheckPassThroughSupport(SlangSession* session, SlangPassThrough passThrough);

    /** @see slang::IGlobalSession::addBuiltins
     */
    SLANG_API void spAddBuiltins(
        SlangSession* session,
        char const* sourcePath,
        char const* sourceString);

    /* @see slang::IGlobalSession::createCompileRequest
     */
    SLANG_API SlangCompileRequest* spCreateCompileRequest(SlangSession* session);

    /*!
    @brief Destroy a compile request.
    Note a request is a COM object and can be destroyed via 'Release'.
    */
    SLANG_API void spDestroyCompileRequest(SlangCompileRequest* request);

    /*! @see slang::ICompileRequest::setFileSystem */
    SLANG_API void spSetFileSystem(SlangCompileRequest* request, ISlangFileSystem* fileSystem);

    /*! @see slang::ICompileRequest::setCompileFlags */
    SLANG_API void spSetCompileFlags(SlangCompileRequest* request, SlangCompileFlags flags);

    /*! @see slang::ICompileRequest::getCompileFlags */
    SLANG_API SlangCompileFlags spGetCompileFlags(SlangCompileRequest* request);

    /*! @see slang::ICompileRequest::setDumpIntermediates */
    SLANG_API void spSetDumpIntermediates(SlangCompileRequest* request, int enable);

    /*! @see slang::ICompileRequest::setDumpIntermediatePrefix */
    SLANG_API void spSetDumpIntermediatePrefix(SlangCompileRequest* request, const char* prefix);

    /*! DEPRECATED: use `spSetTargetLineDirectiveMode` instead.
        @see slang::ICompileRequest::setLineDirectiveMode */
    SLANG_API void spSetLineDirectiveMode(
        SlangCompileRequest* request,
        SlangLineDirectiveMode mode);

    /*! @see slang::ICompileRequest::setTargetLineDirectiveMode */
    SLANG_API void spSetTargetLineDirectiveMode(
        SlangCompileRequest* request,
        int targetIndex,
        SlangLineDirectiveMode mode);

    /*! @see slang::ICompileRequest::setTargetLineDirectiveMode */
    SLANG_API void spSetTargetForceGLSLScalarBufferLayout(
        SlangCompileRequest* request,
        int targetIndex,
        bool forceScalarLayout);

    /*! @see slang::ICompileRequest::setTargetUseMinimumSlangOptimization */
    SLANG_API void spSetTargetUseMinimumSlangOptimization(
        slang::ICompileRequest* request,
        int targetIndex,
        bool val);

    /*! @see slang::ICompileRequest::setIngoreCapabilityCheck */
    SLANG_API void spSetIgnoreCapabilityCheck(slang::ICompileRequest* request, bool val);

    /*! @see slang::ICompileRequest::setCodeGenTarget */
    SLANG_API void spSetCodeGenTarget(SlangCompileRequest* request, SlangCompileTarget target);

    /*! @see slang::ICompileRequest::addCodeGenTarget */
    SLANG_API int spAddCodeGenTarget(SlangCompileRequest* request, SlangCompileTarget target);

    /*! @see slang::ICompileRequest::setTargetProfile */
    SLANG_API void spSetTargetProfile(
        SlangCompileRequest* request,
        int targetIndex,
        SlangProfileID profile);

    /*! @see slang::ICompileRequest::setTargetFlags */
    SLANG_API void spSetTargetFlags(
        SlangCompileRequest* request,
        int targetIndex,
        SlangTargetFlags flags);


    /*! @see slang::ICompileRequest::setTargetFloatingPointMode */
    SLANG_API void spSetTargetFloatingPointMode(
        SlangCompileRequest* request,
        int targetIndex,
        SlangFloatingPointMode mode);

    /*! @see slang::ICompileRequest::addTargetCapability */
    SLANG_API void spAddTargetCapability(
        slang::ICompileRequest* request,
        int targetIndex,
        SlangCapabilityID capability);

    /* DEPRECATED: use `spSetMatrixLayoutMode` instead. */
    SLANG_API void spSetTargetMatrixLayoutMode(
        SlangCompileRequest* request,
        int targetIndex,
        SlangMatrixLayoutMode mode);

    /*! @see slang::ICompileRequest::setMatrixLayoutMode */
    SLANG_API void spSetMatrixLayoutMode(SlangCompileRequest* request, SlangMatrixLayoutMode mode);

    /*! @see slang::ICompileRequest::setDebugInfoLevel */
    SLANG_API void spSetDebugInfoLevel(SlangCompileRequest* request, SlangDebugInfoLevel level);

    /*! @see slang::ICompileRequest::setDebugInfoFormat */
    SLANG_API void spSetDebugInfoFormat(SlangCompileRequest* request, SlangDebugInfoFormat format);

    /*! @see slang::ICompileRequest::setOptimizationLevel */
    SLANG_API void spSetOptimizationLevel(
        SlangCompileRequest* request,
        SlangOptimizationLevel level);


    /*! @see slang::ICompileRequest::setOutputContainerFormat */
    SLANG_API void spSetOutputContainerFormat(
        SlangCompileRequest* request,
        SlangContainerFormat format);

    /*! @see slang::ICompileRequest::setPassThrough */
    SLANG_API void spSetPassThrough(SlangCompileRequest* request, SlangPassThrough passThrough);

    /*! @see slang::ICompileRequest::setDiagnosticCallback */
    SLANG_API void spSetDiagnosticCallback(
        SlangCompileRequest* request,
        SlangDiagnosticCallback callback,
        void const* userData);

    /*! @see slang::ICompileRequest::setWriter */
    SLANG_API void spSetWriter(
        SlangCompileRequest* request,
        SlangWriterChannel channel,
        ISlangWriter* writer);

    /*! @see slang::ICompileRequest::getWriter */
    SLANG_API ISlangWriter* spGetWriter(SlangCompileRequest* request, SlangWriterChannel channel);

    /*! @see slang::ICompileRequest::addSearchPath */
    SLANG_API void spAddSearchPath(SlangCompileRequest* request, const char* searchDir);

    /*! @see slang::ICompileRequest::addPreprocessorDefine */
    SLANG_API void spAddPreprocessorDefine(
        SlangCompileRequest* request,
        const char* key,
        const char* value);

    /*! @see slang::ICompileRequest::processCommandLineArguments */
    SLANG_API SlangResult spProcessCommandLineArguments(
        SlangCompileRequest* request,
        char const* const* args,
        int argCount);

    /*! @see slang::ICompileRequest::addTranslationUnit */
    SLANG_API int spAddTranslationUnit(
        SlangCompileRequest* request,
        SlangSourceLanguage language,
        char const* name);


    /*! @see slang::ICompileRequest::setDefaultModuleName */
    SLANG_API void spSetDefaultModuleName(
        SlangCompileRequest* request,
        const char* defaultModuleName);

    /*! @see slang::ICompileRequest::addPreprocessorDefine */
    SLANG_API void spTranslationUnit_addPreprocessorDefine(
        SlangCompileRequest* request,
        int translationUnitIndex,
        const char* key,
        const char* value);


    /*! @see slang::ICompileRequest::addTranslationUnitSourceFile */
    SLANG_API void spAddTranslationUnitSourceFile(
        SlangCompileRequest* request,
        int translationUnitIndex,
        char const* path);

    /*! @see slang::ICompileRequest::addTranslationUnitSourceString */
    SLANG_API void spAddTranslationUnitSourceString(
        SlangCompileRequest* request,
        int translationUnitIndex,
        char const* path,
        char const* source);


    /*! @see slang::ICompileRequest::addLibraryReference */
    SLANG_API SlangResult spAddLibraryReference(
        SlangCompileRequest* request,
        const char* basePath,
        const void* libData,
        size_t libDataSize);

    /*! @see slang::ICompileRequest::addTranslationUnitSourceStringSpan */
    SLANG_API void spAddTranslationUnitSourceStringSpan(
        SlangCompileRequest* request,
        int translationUnitIndex,
        char const* path,
        char const* sourceBegin,
        char const* sourceEnd);

    /*! @see slang::ICompileRequest::addTranslationUnitSourceBlob */
    SLANG_API void spAddTranslationUnitSourceBlob(
        SlangCompileRequest* request,
        int translationUnitIndex,
        char const* path,
        ISlangBlob* sourceBlob);

    /*! @see slang::IGlobalSession::findProfile */
    SLANG_API SlangProfileID spFindProfile(SlangSession* session, char const* name);

    /*! @see slang::IGlobalSession::findCapability */
    SLANG_API SlangCapabilityID spFindCapability(SlangSession* session, char const* name);

    /*! @see slang::ICompileRequest::addEntryPoint */
    SLANG_API int spAddEntryPoint(
        SlangCompileRequest* request,
        int translationUnitIndex,
        char const* name,
        SlangStage stage);

    /*! @see slang::ICompileRequest::addEntryPointEx */
    SLANG_API int spAddEntryPointEx(
        SlangCompileRequest* request,
        int translationUnitIndex,
        char const* name,
        SlangStage stage,
        int genericArgCount,
        char const** genericArgs);

    /*! @see slang::ICompileRequest::setGlobalGenericArgs */
    SLANG_API SlangResult spSetGlobalGenericArgs(
        SlangCompileRequest* request,
        int genericArgCount,
        char const** genericArgs);

    /*! @see slang::ICompileRequest::setTypeNameForGlobalExistentialTypeParam */
    SLANG_API SlangResult spSetTypeNameForGlobalExistentialTypeParam(
        SlangCompileRequest* request,
        int slotIndex,
        char const* typeName);

    /*! @see slang::ICompileRequest::setTypeNameForEntryPointExistentialTypeParam */
    SLANG_API SlangResult spSetTypeNameForEntryPointExistentialTypeParam(
        SlangCompileRequest* request,
        int entryPointIndex,
        int slotIndex,
        char const* typeName);

    /*! @see slang::ICompileRequest::compile */
    SLANG_API SlangResult spCompile(SlangCompileRequest* request);


    /*! @see slang::ICompileRequest::getDiagnosticOutput */
    SLANG_API char const* spGetDiagnosticOutput(SlangCompileRequest* request);

    /*! @see slang::ICompileRequest::getDiagnosticOutputBlob */
    SLANG_API SlangResult
    spGetDiagnosticOutputBlob(SlangCompileRequest* request, ISlangBlob** outBlob);


    /*! @see slang::ICompileRequest::getDependencyFileCount */
    SLANG_API int spGetDependencyFileCount(SlangCompileRequest* request);

    /*! @see slang::ICompileRequest::getDependencyFilePath */
    SLANG_API char const* spGetDependencyFilePath(SlangCompileRequest* request, int index);

    /*! @see slang::ICompileRequest::getTranslationUnitCount */
    SLANG_API int spGetTranslationUnitCount(SlangCompileRequest* request);

    /*! @see slang::ICompileRequest::getEntryPointSource */
    SLANG_API char const* spGetEntryPointSource(SlangCompileRequest* request, int entryPointIndex);

    /*! @see slang::ICompileRequest::getEntryPointCode */
    SLANG_API void const* spGetEntryPointCode(
        SlangCompileRequest* request,
        int entryPointIndex,
        size_t* outSize);

    /*! @see slang::ICompileRequest::getEntryPointCodeBlob */
    SLANG_API SlangResult spGetEntryPointCodeBlob(
        SlangCompileRequest* request,
        int entryPointIndex,
        int targetIndex,
        ISlangBlob** outBlob);

    /*! @see slang::ICompileRequest::getEntryPointHostCallable */
    SLANG_API SlangResult spGetEntryPointHostCallable(
        SlangCompileRequest* request,
        int entryPointIndex,
        int targetIndex,
        ISlangSharedLibrary** outSharedLibrary);

    /*! @see slang::ICompileRequest::getTargetCodeBlob */
    SLANG_API SlangResult
    spGetTargetCodeBlob(SlangCompileRequest* request, int targetIndex, ISlangBlob** outBlob);

    /*! @see slang::ICompileRequest::getTargetHostCallable */
    SLANG_API SlangResult spGetTargetHostCallable(
        SlangCompileRequest* request,
        int targetIndex,
        ISlangSharedLibrary** outSharedLibrary);

    /*! @see slang::ICompileRequest::getCompileRequestCode */
    SLANG_API void const* spGetCompileRequestCode(SlangCompileRequest* request, size_t* outSize);

    /*! @see slang::ICompileRequest::getContainerCode */
    SLANG_API SlangResult spGetContainerCode(SlangCompileRequest* request, ISlangBlob** outBlob);

    /*! @see slang::ICompileRequest::loadRepro */
    SLANG_API SlangResult spLoadRepro(
        SlangCompileRequest* request,
        ISlangFileSystem* fileSystem,
        const void* data,
        size_t size);

    /*! @see slang::ICompileRequest::saveRepro */
    SLANG_API SlangResult spSaveRepro(SlangCompileRequest* request, ISlangBlob** outBlob);

    /*! @see slang::ICompileRequest::enableReproCapture */
    SLANG_API SlangResult spEnableReproCapture(SlangCompileRequest* request);

    /*! @see slang::ICompileRequest::getCompileTimeProfile */
    SLANG_API SlangResult spGetCompileTimeProfile(
        SlangCompileRequest* request,
        ISlangProfiler** compileTimeProfile,
        bool shouldClear);


    /** Extract contents of a repro.

    Writes the contained files and manifest with their 'unique' names into fileSystem. For more
    details read the docs/repro.md documentation.

    @param session          The slang session
    @param reproData        Holds the repro data
    @param reproDataSize    The size of the repro data
    @param fileSystem       File system that the contents of the repro will be written to
    @returns                A `SlangResult` to indicate success or failure.
    */
    SLANG_API SlangResult spExtractRepro(
        SlangSession* session,
        const void* reproData,
        size_t reproDataSize,
        ISlangMutableFileSystem* fileSystem);

    /* Turns a repro into a file system.

    Makes the contents of the repro available as a file system - that is able to access the files
    with the same paths as were used on the original repro file system.

    @param session          The slang session
    @param reproData        The repro data
    @param reproDataSize    The size of the repro data
    @param replaceFileSystem  Will attempt to load by unique names from this file system before
    using contents of the repro. Optional.
    @param outFileSystem    The file system that can be used to access contents
    @returns                A `SlangResult` to indicate success or failure.
    */
    SLANG_API SlangResult spLoadReproAsFileSystem(
        SlangSession* session,
        const void* reproData,
        size_t reproDataSize,
        ISlangFileSystem* replaceFileSystem,
        ISlangFileSystemExt** outFileSystem);

    /*! @see slang::ICompileRequest::overrideDiagnosticSeverity */
    SLANG_API void spOverrideDiagnosticSeverity(
        SlangCompileRequest* request,
        SlangInt messageID,
        SlangSeverity overrideSeverity);

    /*! @see slang::ICompileRequest::getDiagnosticFlags */
    SLANG_API SlangDiagnosticFlags spGetDiagnosticFlags(SlangCompileRequest* request);

    /*! @see slang::ICompileRequest::setDiagnosticFlags */
    SLANG_API void spSetDiagnosticFlags(SlangCompileRequest* request, SlangDiagnosticFlags flags);


    // get reflection data from a compilation request
    SLANG_API SlangReflection* spGetReflection(SlangCompileRequest* request);

    // User Attribute
    SLANG_API char const* spReflectionUserAttribute_GetName(SlangReflectionUserAttribute* attrib);
    SLANG_API unsigned int spReflectionUserAttribute_GetArgumentCount(
        SlangReflectionUserAttribute* attrib);
    SLANG_API SlangReflectionType* spReflectionUserAttribute_GetArgumentType(
        SlangReflectionUserAttribute* attrib,
        unsigned int index);
    SLANG_API SlangResult spReflectionUserAttribute_GetArgumentValueInt(
        SlangReflectionUserAttribute* attrib,
        unsigned int index,
        int* rs);
    SLANG_API SlangResult spReflectionUserAttribute_GetArgumentValueFloat(
        SlangReflectionUserAttribute* attrib,
        unsigned int index,
        float* rs);

    /** Returns the string-typed value of a user attribute argument
        The string returned is not null-terminated. The length of the string is returned via
       `outSize`. If index of out of range, or if the specified argument is not a string, the
       function will return nullptr.
    */
    SLANG_API const char* spReflectionUserAttribute_GetArgumentValueString(
        SlangReflectionUserAttribute* attrib,
        unsigned int index,
        size_t* outSize);

    // Type Reflection

    SLANG_API SlangTypeKind spReflectionType_GetKind(SlangReflectionType* type);
    SLANG_API unsigned int spReflectionType_GetUserAttributeCount(SlangReflectionType* type);
    SLANG_API SlangReflectionUserAttribute* spReflectionType_GetUserAttribute(
        SlangReflectionType* type,
        unsigned int index);
    SLANG_API SlangReflectionUserAttribute* spReflectionType_FindUserAttributeByName(
        SlangReflectionType* type,
        char const* name);
    SLANG_API SlangReflectionType* spReflectionType_applySpecializations(
        SlangReflectionType* type,
        SlangReflectionGeneric* generic);

    SLANG_API unsigned int spReflectionType_GetFieldCount(SlangReflectionType* type);
    SLANG_API SlangReflectionVariable* spReflectionType_GetFieldByIndex(
        SlangReflectionType* type,
        unsigned index);

    /** Returns the number of elements in the given type.

    This operation is valid for vector and array types. For other types it returns zero.

    When invoked on an unbounded-size array it will return `SLANG_UNBOUNDED_SIZE`,
    which is defined to be `~size_t(0)`.

    If the size of a type cannot be statically computed, perhaps because it depends on
    a generic parameter that has not been bound to a specific value, this function returns zero.
    */
    SLANG_API size_t spReflectionType_GetElementCount(SlangReflectionType* type);

    SLANG_API SlangReflectionType* spReflectionType_GetElementType(SlangReflectionType* type);

    SLANG_API unsigned int spReflectionType_GetRowCount(SlangReflectionType* type);
    SLANG_API unsigned int spReflectionType_GetColumnCount(SlangReflectionType* type);
    SLANG_API SlangScalarType spReflectionType_GetScalarType(SlangReflectionType* type);

    SLANG_API SlangResourceShape spReflectionType_GetResourceShape(SlangReflectionType* type);
    SLANG_API SlangResourceAccess spReflectionType_GetResourceAccess(SlangReflectionType* type);
    SLANG_API SlangReflectionType* spReflectionType_GetResourceResultType(
        SlangReflectionType* type);

    SLANG_API char const* spReflectionType_GetName(SlangReflectionType* type);
    SLANG_API SlangResult
    spReflectionType_GetFullName(SlangReflectionType* type, ISlangBlob** outNameBlob);
    SLANG_API SlangReflectionGeneric* spReflectionType_GetGenericContainer(
        SlangReflectionType* type);

    // Type Layout Reflection

    SLANG_API SlangReflectionType* spReflectionTypeLayout_GetType(SlangReflectionTypeLayout* type);
    SLANG_API SlangTypeKind spReflectionTypeLayout_getKind(SlangReflectionTypeLayout* type);
    SLANG_API size_t spReflectionTypeLayout_GetSize(
        SlangReflectionTypeLayout* type,
        SlangParameterCategory category);
    SLANG_API size_t spReflectionTypeLayout_GetStride(
        SlangReflectionTypeLayout* type,
        SlangParameterCategory category);
    SLANG_API int32_t spReflectionTypeLayout_getAlignment(
        SlangReflectionTypeLayout* type,
        SlangParameterCategory category);

    SLANG_API uint32_t spReflectionTypeLayout_GetFieldCount(SlangReflectionTypeLayout* type);
    SLANG_API SlangReflectionVariableLayout* spReflectionTypeLayout_GetFieldByIndex(
        SlangReflectionTypeLayout* type,
        unsigned index);

    SLANG_API SlangInt spReflectionTypeLayout_findFieldIndexByName(
        SlangReflectionTypeLayout* typeLayout,
        const char* nameBegin,
        const char* nameEnd);

    SLANG_API SlangReflectionVariableLayout* spReflectionTypeLayout_GetExplicitCounter(
        SlangReflectionTypeLayout* typeLayout);

    SLANG_API size_t spReflectionTypeLayout_GetElementStride(
        SlangReflectionTypeLayout* type,
        SlangParameterCategory category);
    SLANG_API SlangReflectionTypeLayout* spReflectionTypeLayout_GetElementTypeLayout(
        SlangReflectionTypeLayout* type);
    SLANG_API SlangReflectionVariableLayout* spReflectionTypeLayout_GetElementVarLayout(
        SlangReflectionTypeLayout* type);
    SLANG_API SlangReflectionVariableLayout* spReflectionTypeLayout_getContainerVarLayout(
        SlangReflectionTypeLayout* type);

    SLANG_API SlangParameterCategory
    spReflectionTypeLayout_GetParameterCategory(SlangReflectionTypeLayout* type);

    SLANG_API unsigned spReflectionTypeLayout_GetCategoryCount(SlangReflectionTypeLayout* type);
    SLANG_API SlangParameterCategory
    spReflectionTypeLayout_GetCategoryByIndex(SlangReflectionTypeLayout* type, unsigned index);

    SLANG_API SlangMatrixLayoutMode
    spReflectionTypeLayout_GetMatrixLayoutMode(SlangReflectionTypeLayout* type);

    SLANG_API int spReflectionTypeLayout_getGenericParamIndex(SlangReflectionTypeLayout* type);

    SLANG_API SlangReflectionTypeLayout* spReflectionTypeLayout_getPendingDataTypeLayout(
        SlangReflectionTypeLayout* type);

    SLANG_API SlangReflectionVariableLayout*
    spReflectionTypeLayout_getSpecializedTypePendingDataVarLayout(SlangReflectionTypeLayout* type);
    SLANG_API SlangInt spReflectionType_getSpecializedTypeArgCount(SlangReflectionType* type);
    SLANG_API SlangReflectionType* spReflectionType_getSpecializedTypeArgType(
        SlangReflectionType* type,
        SlangInt index);

    SLANG_API SlangInt
    spReflectionTypeLayout_getBindingRangeCount(SlangReflectionTypeLayout* typeLayout);
    SLANG_API SlangBindingType spReflectionTypeLayout_getBindingRangeType(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt index);
    SLANG_API SlangInt spReflectionTypeLayout_isBindingRangeSpecializable(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt index);
    SLANG_API SlangInt spReflectionTypeLayout_getBindingRangeBindingCount(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt index);
    SLANG_API SlangReflectionTypeLayout* spReflectionTypeLayout_getBindingRangeLeafTypeLayout(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt index);
    SLANG_API SlangReflectionVariable* spReflectionTypeLayout_getBindingRangeLeafVariable(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt index);
    SLANG_API SlangImageFormat spReflectionTypeLayout_getBindingRangeImageFormat(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt index);
    SLANG_API SlangInt spReflectionTypeLayout_getFieldBindingRangeOffset(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt fieldIndex);
    SLANG_API SlangInt spReflectionTypeLayout_getExplicitCounterBindingRangeOffset(
        SlangReflectionTypeLayout* inTypeLayout);

    SLANG_API SlangInt spReflectionTypeLayout_getBindingRangeDescriptorSetIndex(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt index);
    SLANG_API SlangInt spReflectionTypeLayout_getBindingRangeFirstDescriptorRangeIndex(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt index);
    SLANG_API SlangInt spReflectionTypeLayout_getBindingRangeDescriptorRangeCount(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt index);

    SLANG_API SlangInt
    spReflectionTypeLayout_getDescriptorSetCount(SlangReflectionTypeLayout* typeLayout);
    SLANG_API SlangInt spReflectionTypeLayout_getDescriptorSetSpaceOffset(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt setIndex);
    SLANG_API SlangInt spReflectionTypeLayout_getDescriptorSetDescriptorRangeCount(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt setIndex);
    SLANG_API SlangInt spReflectionTypeLayout_getDescriptorSetDescriptorRangeIndexOffset(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt setIndex,
        SlangInt rangeIndex);
    SLANG_API SlangInt spReflectionTypeLayout_getDescriptorSetDescriptorRangeDescriptorCount(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt setIndex,
        SlangInt rangeIndex);
    SLANG_API SlangBindingType spReflectionTypeLayout_getDescriptorSetDescriptorRangeType(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt setIndex,
        SlangInt rangeIndex);
    SLANG_API SlangParameterCategory spReflectionTypeLayout_getDescriptorSetDescriptorRangeCategory(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt setIndex,
        SlangInt rangeIndex);

    SLANG_API SlangInt
    spReflectionTypeLayout_getSubObjectRangeCount(SlangReflectionTypeLayout* typeLayout);
    SLANG_API SlangInt spReflectionTypeLayout_getSubObjectRangeBindingRangeIndex(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt subObjectRangeIndex);
    SLANG_API SlangInt spReflectionTypeLayout_getSubObjectRangeSpaceOffset(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt subObjectRangeIndex);
    SLANG_API SlangReflectionVariableLayout* spReflectionTypeLayout_getSubObjectRangeOffset(
        SlangReflectionTypeLayout* typeLayout,
        SlangInt subObjectRangeIndex);

#if 0
    SLANG_API SlangInt spReflectionTypeLayout_getSubObjectRangeCount(SlangReflectionTypeLayout* typeLayout);
    SLANG_API SlangInt spReflectionTypeLayout_getSubObjectRangeObjectCount(SlangReflectionTypeLayout* typeLayout, SlangInt index);
    SLANG_API SlangInt spReflectionTypeLayout_getSubObjectRangeBindingRangeIndex(SlangReflectionTypeLayout* typeLayout, SlangInt index);
    SLANG_API SlangReflectionTypeLayout* spReflectionTypeLayout_getSubObjectRangeTypeLayout(SlangReflectionTypeLayout* typeLayout, SlangInt index);

    SLANG_API SlangInt spReflectionTypeLayout_getSubObjectRangeDescriptorRangeCount(SlangReflectionTypeLayout* typeLayout, SlangInt subObjectRangeIndex);
    SLANG_API SlangBindingType spReflectionTypeLayout_getSubObjectRangeDescriptorRangeBindingType(SlangReflectionTypeLayout* typeLayout, SlangInt subObjectRangeIndex, SlangInt bindingRangeIndexInSubObject);
    SLANG_API SlangInt spReflectionTypeLayout_getSubObjectRangeDescriptorRangeBindingCount(SlangReflectionTypeLayout* typeLayout, SlangInt subObjectRangeIndex, SlangInt bindingRangeIndexInSubObject);
    SLANG_API SlangInt spReflectionTypeLayout_getSubObjectRangeDescriptorRangeIndexOffset(SlangReflectionTypeLayout* typeLayout, SlangInt subObjectRangeIndex, SlangInt bindingRangeIndexInSubObject);
    SLANG_API SlangInt spReflectionTypeLayout_getSubObjectRangeDescriptorRangeSpaceOffset(SlangReflectionTypeLayout* typeLayout, SlangInt subObjectRangeIndex, SlangInt bindingRangeIndexInSubObject);
#endif

    // Variable Reflection

    SLANG_API char const* spReflectionVariable_GetName(SlangReflectionVariable* var);
    SLANG_API SlangReflectionType* spReflectionVariable_GetType(SlangReflectionVariable* var);
    SLANG_API SlangReflectionModifier* spReflectionVariable_FindModifier(
        SlangReflectionVariable* var,
        SlangModifierID modifierID);
    SLANG_API unsigned int spReflectionVariable_GetUserAttributeCount(SlangReflectionVariable* var);
    SLANG_API SlangReflectionUserAttribute* spReflectionVariable_GetUserAttribute(
        SlangReflectionVariable* var,
        unsigned int index);
    SLANG_API SlangReflectionUserAttribute* spReflectionVariable_FindUserAttributeByName(
        SlangReflectionVariable* var,
        SlangSession* globalSession,
        char const* name);
    SLANG_API bool spReflectionVariable_HasDefaultValue(SlangReflectionVariable* inVar);
    SLANG_API SlangReflectionGeneric* spReflectionVariable_GetGenericContainer(
        SlangReflectionVariable* var);
    SLANG_API SlangReflectionVariable* spReflectionVariable_applySpecializations(
        SlangReflectionVariable* var,
        SlangReflectionGeneric* generic);

    // Variable Layout Reflection

    SLANG_API SlangReflectionVariable* spReflectionVariableLayout_GetVariable(
        SlangReflectionVariableLayout* var);

    SLANG_API SlangReflectionTypeLayout* spReflectionVariableLayout_GetTypeLayout(
        SlangReflectionVariableLayout* var);

    SLANG_API size_t spReflectionVariableLayout_GetOffset(
        SlangReflectionVariableLayout* var,
        SlangParameterCategory category);
    SLANG_API size_t spReflectionVariableLayout_GetSpace(
        SlangReflectionVariableLayout* var,
        SlangParameterCategory category);

    SLANG_API char const* spReflectionVariableLayout_GetSemanticName(
        SlangReflectionVariableLayout* var);
    SLANG_API size_t
    spReflectionVariableLayout_GetSemanticIndex(SlangReflectionVariableLayout* var);


    // Function Reflection

    SLANG_API SlangReflectionDecl* spReflectionFunction_asDecl(SlangReflectionFunction* func);
    SLANG_API char const* spReflectionFunction_GetName(SlangReflectionFunction* func);
    SLANG_API SlangReflectionModifier* spReflectionFunction_FindModifier(
        SlangReflectionFunction* var,
        SlangModifierID modifierID);
    SLANG_API unsigned int spReflectionFunction_GetUserAttributeCount(
        SlangReflectionFunction* func);
    SLANG_API SlangReflectionUserAttribute* spReflectionFunction_GetUserAttribute(
        SlangReflectionFunction* func,
        unsigned int index);
    SLANG_API SlangReflectionUserAttribute* spReflectionFunction_FindUserAttributeByName(
        SlangReflectionFunction* func,
        SlangSession* globalSession,
        char const* name);
    SLANG_API unsigned int spReflectionFunction_GetParameterCount(SlangReflectionFunction* func);
    SLANG_API SlangReflectionVariable* spReflectionFunction_GetParameter(
        SlangReflectionFunction* func,
        unsigned index);
    SLANG_API SlangReflectionType* spReflectionFunction_GetResultType(
        SlangReflectionFunction* func);
    SLANG_API SlangReflectionGeneric* spReflectionFunction_GetGenericContainer(
        SlangReflectionFunction* func);
    SLANG_API SlangReflectionFunction* spReflectionFunction_applySpecializations(
        SlangReflectionFunction* func,
        SlangReflectionGeneric* generic);
    SLANG_API SlangReflectionFunction* spReflectionFunction_specializeWithArgTypes(
        SlangReflectionFunction* func,
        SlangInt argTypeCount,
        SlangReflectionType* const* argTypes);
    SLANG_API bool spReflectionFunction_isOverloaded(SlangReflectionFunction* func);
    SLANG_API unsigned int spReflectionFunction_getOverloadCount(SlangReflectionFunction* func);
    SLANG_API SlangReflectionFunction* spReflectionFunction_getOverload(
        SlangReflectionFunction* func,
        unsigned int index);

    // Abstract Decl Reflection

    SLANG_API unsigned int spReflectionDecl_getChildrenCount(SlangReflectionDecl* parentDecl);
    SLANG_API SlangReflectionDecl* spReflectionDecl_getChild(
        SlangReflectionDecl* parentDecl,
        unsigned int index);
    SLANG_API char const* spReflectionDecl_getName(SlangReflectionDecl* decl);
    SLANG_API SlangDeclKind spReflectionDecl_getKind(SlangReflectionDecl* decl);
    SLANG_API SlangReflectionFunction* spReflectionDecl_castToFunction(SlangReflectionDecl* decl);
    SLANG_API SlangReflectionVariable* spReflectionDecl_castToVariable(SlangReflectionDecl* decl);
    SLANG_API SlangReflectionGeneric* spReflectionDecl_castToGeneric(SlangReflectionDecl* decl);
    SLANG_API SlangReflectionType* spReflection_getTypeFromDecl(SlangReflectionDecl* decl);
    SLANG_API SlangReflectionDecl* spReflectionDecl_getParent(SlangReflectionDecl* decl);

    // Generic Reflection

    SLANG_API SlangReflectionDecl* spReflectionGeneric_asDecl(SlangReflectionGeneric* generic);
    SLANG_API char const* spReflectionGeneric_GetName(SlangReflectionGeneric* generic);
    SLANG_API unsigned int spReflectionGeneric_GetTypeParameterCount(
        SlangReflectionGeneric* generic);
    SLANG_API SlangReflectionVariable* spReflectionGeneric_GetTypeParameter(
        SlangReflectionGeneric* generic,
        unsigned index);
    SLANG_API unsigned int spReflectionGeneric_GetValueParameterCount(
        SlangReflectionGeneric* generic);
    SLANG_API SlangReflectionVariable* spReflectionGeneric_GetValueParameter(
        SlangReflectionGeneric* generic,
        unsigned index);
    SLANG_API unsigned int spReflectionGeneric_GetTypeParameterConstraintCount(
        SlangReflectionGeneric* generic,
        SlangReflectionVariable* typeParam);
    SLANG_API SlangReflectionType* spReflectionGeneric_GetTypeParameterConstraintType(
        SlangReflectionGeneric* generic,
        SlangReflectionVariable* typeParam,
        unsigned index);
    SLANG_API SlangDeclKind spReflectionGeneric_GetInnerKind(SlangReflectionGeneric* generic);
    SLANG_API SlangReflectionDecl* spReflectionGeneric_GetInnerDecl(
        SlangReflectionGeneric* generic);
    SLANG_API SlangReflectionGeneric* spReflectionGeneric_GetOuterGenericContainer(
        SlangReflectionGeneric* generic);
    SLANG_API SlangReflectionType* spReflectionGeneric_GetConcreteType(
        SlangReflectionGeneric* generic,
        SlangReflectionVariable* typeParam);
    SLANG_API int64_t spReflectionGeneric_GetConcreteIntVal(
        SlangReflectionGeneric* generic,
        SlangReflectionVariable* valueParam);
    SLANG_API SlangReflectionGeneric* spReflectionGeneric_applySpecializations(
        SlangReflectionGeneric* currGeneric,
        SlangReflectionGeneric* generic);


    /** Get the stage that a variable belongs to (if any).

    A variable "belongs" to a specific stage when it is a varying input/output
    parameter either defined as part of the parameter list for an entry
    point *or* at the global scope of a stage-specific GLSL code file (e.g.,
    an `in` parameter in a GLSL `.vs` file belongs to the vertex stage).
    */
    SLANG_API SlangStage spReflectionVariableLayout_getStage(SlangReflectionVariableLayout* var);


    SLANG_API SlangReflectionVariableLayout* spReflectionVariableLayout_getPendingDataLayout(
        SlangReflectionVariableLayout* var);

    // Shader Parameter Reflection

    SLANG_API unsigned spReflectionParameter_GetBindingIndex(SlangReflectionParameter* parameter);
    SLANG_API unsigned spReflectionParameter_GetBindingSpace(SlangReflectionParameter* parameter);

    SLANG_API SlangResult spIsParameterLocationUsed(
        SlangCompileRequest* request,
        SlangInt entryPointIndex,
        SlangInt targetIndex,
        SlangParameterCategory category, // is this a `t` register? `s` register?
        SlangUInt spaceIndex,            // `space` for D3D12, `set` for Vulkan
        SlangUInt registerIndex,         // `register` for D3D12, `binding` for Vulkan
        bool& outUsed);

    // Entry Point Reflection

    SLANG_API char const* spReflectionEntryPoint_getName(SlangReflectionEntryPoint* entryPoint);

    SLANG_API char const* spReflectionEntryPoint_getNameOverride(
        SlangReflectionEntryPoint* entryPoint);

    SLANG_API SlangReflectionFunction* spReflectionEntryPoint_getFunction(
        SlangReflectionEntryPoint* entryPoint);

    SLANG_API unsigned spReflectionEntryPoint_getParameterCount(
        SlangReflectionEntryPoint* entryPoint);

    SLANG_API SlangReflectionVariableLayout* spReflectionEntryPoint_getParameterByIndex(
        SlangReflectionEntryPoint* entryPoint,
        unsigned index);

    SLANG_API SlangStage spReflectionEntryPoint_getStage(SlangReflectionEntryPoint* entryPoint);

    SLANG_API void spReflectionEntryPoint_getComputeThreadGroupSize(
        SlangReflectionEntryPoint* entryPoint,
        SlangUInt axisCount,
        SlangUInt* outSizeAlongAxis);

    SLANG_API void spReflectionEntryPoint_getComputeWaveSize(
        SlangReflectionEntryPoint* entryPoint,
        SlangUInt* outWaveSize);

    SLANG_API int spReflectionEntryPoint_usesAnySampleRateInput(
        SlangReflectionEntryPoint* entryPoint);

    SLANG_API SlangReflectionVariableLayout* spReflectionEntryPoint_getVarLayout(
        SlangReflectionEntryPoint* entryPoint);

    SLANG_API SlangReflectionVariableLayout* spReflectionEntryPoint_getResultVarLayout(
        SlangReflectionEntryPoint* entryPoint);

    SLANG_API int spReflectionEntryPoint_hasDefaultConstantBuffer(
        SlangReflectionEntryPoint* entryPoint);

    // SlangReflectionTypeParameter
    SLANG_API char const* spReflectionTypeParameter_GetName(
        SlangReflectionTypeParameter* typeParam);
    SLANG_API unsigned spReflectionTypeParameter_GetIndex(SlangReflectionTypeParameter* typeParam);
    SLANG_API unsigned spReflectionTypeParameter_GetConstraintCount(
        SlangReflectionTypeParameter* typeParam);
    SLANG_API SlangReflectionType* spReflectionTypeParameter_GetConstraintByIndex(
        SlangReflectionTypeParameter* typeParam,
        unsigned int index);

    // Shader Reflection

    SLANG_API unsigned spReflection_GetParameterCount(SlangReflection* reflection);
    SLANG_API SlangReflectionParameter* spReflection_GetParameterByIndex(
        SlangReflection* reflection,
        unsigned index);

    SLANG_API unsigned int spReflection_GetTypeParameterCount(SlangReflection* reflection);
    SLANG_API SlangReflectionTypeParameter* spReflection_GetTypeParameterByIndex(
        SlangReflection* reflection,
        unsigned int index);
    SLANG_API SlangReflectionTypeParameter* spReflection_FindTypeParameter(
        SlangReflection* reflection,
        char const* name);

    SLANG_API SlangReflectionType* spReflection_FindTypeByName(
        SlangReflection* reflection,
        char const* name);
    SLANG_API SlangReflectionTypeLayout* spReflection_GetTypeLayout(
        SlangReflection* reflection,
        SlangReflectionType* reflectionType,
        SlangLayoutRules rules);

    SLANG_API SlangReflectionFunction* spReflection_FindFunctionByName(
        SlangReflection* reflection,
        char const* name);
    SLANG_API SlangReflectionFunction* spReflection_FindFunctionByNameInType(
        SlangReflection* reflection,
        SlangReflectionType* reflType,
        char const* name);
    SLANG_API SlangReflectionVariable* spReflection_FindVarByNameInType(
        SlangReflection* reflection,
        SlangReflectionType* reflType,
        char const* name);

    SLANG_API SlangUInt spReflection_getEntryPointCount(SlangReflection* reflection);
    SLANG_API SlangReflectionEntryPoint* spReflection_getEntryPointByIndex(
        SlangReflection* reflection,
        SlangUInt index);
    SLANG_API SlangReflectionEntryPoint* spReflection_findEntryPointByName(
        SlangReflection* reflection,
        char const* name);

    SLANG_API SlangUInt spReflection_getGlobalConstantBufferBinding(SlangReflection* reflection);
    SLANG_API size_t spReflection_getGlobalConstantBufferSize(SlangReflection* reflection);

    SLANG_API SlangReflectionType* spReflection_specializeType(
        SlangReflection* reflection,
        SlangReflectionType* type,
        SlangInt specializationArgCount,
        SlangReflectionType* const* specializationArgs,
        ISlangBlob** outDiagnostics);

    SLANG_API SlangReflectionGeneric* spReflection_specializeGeneric(
        SlangReflection* inProgramLayout,
        SlangReflectionGeneric* generic,
        SlangInt argCount,
        SlangReflectionGenericArgType const* argTypes,
        SlangReflectionGenericArg const* args,
        ISlangBlob** outDiagnostics);

    SLANG_API bool spReflection_isSubType(
        SlangReflection* reflection,
        SlangReflectionType* subType,
        SlangReflectionType* superType);

    /// Get the number of hashed strings
    SLANG_API SlangUInt spReflection_getHashedStringCount(SlangReflection* reflection);

    /// Get a hashed string. The number of chars is written in outCount.
    /// The count does *NOT* including terminating 0. The returned string will be 0 terminated.
    SLANG_API const char* spReflection_getHashedString(
        SlangReflection* reflection,
        SlangUInt index,
        size_t* outCount);

    /// Compute a string hash.
    /// Count should *NOT* include terminating zero.
    SLANG_API SlangUInt32 spComputeStringHash(const char* chars, size_t count);

    /// Get a type layout representing reflection information for the global-scope prameters.
    SLANG_API SlangReflectionTypeLayout* spReflection_getGlobalParamsTypeLayout(
        SlangReflection* reflection);

    /// Get a variable layout representing reflection information for the global-scope prameters.
    SLANG_API SlangReflectionVariableLayout* spReflection_getGlobalParamsVarLayout(
        SlangReflection* reflection);

    SLANG_API char const* spGetTranslationUnitSource(
        SlangCompileRequest* request,
        int translationUnitIndex);
#ifdef __cplusplus
}
#endif

#ifdef __cplusplus
SLANG_API slang::ISession* spReflection_GetSession(SlangReflection* reflection);

namespace slang
{
struct IComponentType;
struct IModule;
} // namespace slang

extern "C"
{
    /** @see slang::ICompileRequest::getProgram
     */
    SLANG_API SlangResult
    spCompileRequest_getProgram(SlangCompileRequest* request, slang::IComponentType** outProgram);

    /** @see slang::ICompileRequest::getProgramWithEntryPoints
     */
    SLANG_API SlangResult spCompileRequest_getProgramWithEntryPoints(
        SlangCompileRequest* request,
        slang::IComponentType** outProgram);

    /** @see slang::ICompileRequest::getEntryPoint
     */
    SLANG_API SlangResult spCompileRequest_getEntryPoint(
        SlangCompileRequest* request,
        SlangInt entryPointIndex,
        slang::IComponentType** outEntryPoint);

    /** @see slang::ICompileRequest::getModule
     */
    SLANG_API SlangResult spCompileRequest_getModule(
        SlangCompileRequest* request,
        SlangInt translationUnitIndex,
        slang::IModule** outModule);

    /** @see slang::ICompileRequest::getSession
     */
    SLANG_API SlangResult
    spCompileRequest_getSession(SlangCompileRequest* request, slang::ISession** outSession);
}

namespace slang
{

} // namespace slang
#endif
