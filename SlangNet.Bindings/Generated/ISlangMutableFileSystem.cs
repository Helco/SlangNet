using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

/// <include file='ISlangMutableFileSystem.xml' path='doc/member[@name="ISlangMutableFileSystem"]/*' />
[NativeTypeName("struct ISlangMutableFileSystem : ISlangFileSystemExt")]
public unsafe partial struct ISlangMutableFileSystem
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISlangMutableFileSystem* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISlangMutableFileSystem* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISlangMutableFileSystem* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void* _castAs(ISlangMutableFileSystem* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* guid);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _loadFile(ISlangMutableFileSystem* pThis, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** outBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getFileUniqueIdentity(ISlangMutableFileSystem* pThis, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** outUniqueIdentity);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _calcCombinedPath(ISlangMutableFileSystem* pThis, SlangPathType fromPathType, [NativeTypeName("const char *")] sbyte* fromPath, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** pathOut);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getPathType(ISlangMutableFileSystem* pThis, [NativeTypeName("const char *")] sbyte* path, SlangPathType* pathTypeOut);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getPath(ISlangMutableFileSystem* pThis, PathKind kind, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** outPath);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _clearCache(ISlangMutableFileSystem* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _enumeratePathContents(ISlangMutableFileSystem* pThis, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("FileSystemContentsCallBack")] IntPtr callback, void* userData);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate OSPathKind _getOSPathKind(ISlangMutableFileSystem* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _saveFile(ISlangMutableFileSystem* pThis, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _saveFileBlob(ISlangMutableFileSystem* pThis, [NativeTypeName("const char *")] sbyte* path, ISlangBlob* dataBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _remove(ISlangMutableFileSystem* pThis, [NativeTypeName("const char *")] sbyte* path);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _createDirectory(ISlangMutableFileSystem* pThis, [NativeTypeName("const char *")] sbyte* path);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangCastable.castAs" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void* castAs([NativeTypeName("const SlangUUID &")] SlangUUID* guid)
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_castAs>(lpVtbl->castAs)(pThis, guid);
        }
    }

    /// <inheritdoc cref="ISlangFileSystem.loadFile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int loadFile([NativeTypeName("const char *")] sbyte* path, ISlangBlob** outBlob)
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadFile>(lpVtbl->loadFile)(pThis, path, outBlob);
        }
    }

    /// <inheritdoc cref="ISlangFileSystemExt.getFileUniqueIdentity" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getFileUniqueIdentity([NativeTypeName("const char *")] sbyte* path, ISlangBlob** outUniqueIdentity)
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getFileUniqueIdentity>(lpVtbl->getFileUniqueIdentity)(pThis, path, outUniqueIdentity);
        }
    }

    /// <inheritdoc cref="ISlangFileSystemExt.calcCombinedPath" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int calcCombinedPath(SlangPathType fromPathType, [NativeTypeName("const char *")] sbyte* fromPath, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** pathOut)
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_calcCombinedPath>(lpVtbl->calcCombinedPath)(pThis, fromPathType, fromPath, path, pathOut);
        }
    }

    /// <inheritdoc cref="ISlangFileSystemExt.getPathType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getPathType([NativeTypeName("const char *")] sbyte* path, SlangPathType* pathTypeOut)
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getPathType>(lpVtbl->getPathType)(pThis, path, pathTypeOut);
        }
    }

    /// <inheritdoc cref="ISlangFileSystemExt.getPath" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int getPath(PathKind kind, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** outPath)
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getPath>(lpVtbl->getPath)(pThis, kind, path, outPath);
        }
    }

    /// <inheritdoc cref="ISlangFileSystemExt.clearCache" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void clearCache()
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_clearCache>(lpVtbl->clearCache)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangFileSystemExt.enumeratePathContents" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int enumeratePathContents([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("FileSystemContentsCallBack")] IntPtr callback, void* userData)
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_enumeratePathContents>(lpVtbl->enumeratePathContents)(pThis, path, callback, userData);
        }
    }

    /// <inheritdoc cref="ISlangFileSystemExt.getOSPathKind" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public OSPathKind getOSPathKind()
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getOSPathKind>(lpVtbl->getOSPathKind)(pThis);
        }
    }

    /// <include file='ISlangMutableFileSystem.xml' path='doc/member[@name="ISlangMutableFileSystem.saveFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int saveFile([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr size)
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_saveFile>(lpVtbl->saveFile)(pThis, path, data, size);
        }
    }

    /// <include file='ISlangMutableFileSystem.xml' path='doc/member[@name="ISlangMutableFileSystem.saveFileBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int saveFileBlob([NativeTypeName("const char *")] sbyte* path, ISlangBlob* dataBlob)
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_saveFileBlob>(lpVtbl->saveFileBlob)(pThis, path, dataBlob);
        }
    }

    /// <include file='ISlangMutableFileSystem.xml' path='doc/member[@name="ISlangMutableFileSystem.remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int remove([NativeTypeName("const char *")] sbyte* path)
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_remove>(lpVtbl->remove)(pThis, path);
        }
    }

    /// <include file='ISlangMutableFileSystem.xml' path='doc/member[@name="ISlangMutableFileSystem.createDirectory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int createDirectory([NativeTypeName("const char *")] sbyte* path)
    {
        fixed (ISlangMutableFileSystem* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createDirectory>(lpVtbl->createDirectory)(pThis, path);
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

        [NativeTypeName("void *(const SlangUUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr castAs;

        [NativeTypeName("SlangResult (const char *, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr loadFile;

        [NativeTypeName("SlangResult (const char *, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getFileUniqueIdentity;

        [NativeTypeName("SlangResult (SlangPathType, const char *, const char *, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr calcCombinedPath;

        [NativeTypeName("SlangResult (const char *, SlangPathType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getPathType;

        [NativeTypeName("SlangResult (PathKind, const char *, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getPath;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr clearCache;

        [NativeTypeName("SlangResult (const char *, FileSystemContentsCallBack, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr enumeratePathContents;

        [NativeTypeName("OSPathKind () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getOSPathKind;

        [NativeTypeName("SlangResult (const char *, const void *, size_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr saveFile;

        [NativeTypeName("SlangResult (const char *, ISlangBlob *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr saveFileBlob;

        [NativeTypeName("SlangResult (const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr remove;

        [NativeTypeName("SlangResult (const char *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createDirectory;
    }
}
