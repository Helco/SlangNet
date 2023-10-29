using System;
using System.Runtime.InteropServices;

namespace SlangNet;

/// <include file='ISlangFileSystemExt.xml' path='doc/member[@name="ISlangFileSystemExt"]/*' />
[NativeTypeName("struct ISlangFileSystemExt : ISlangFileSystem")]
public unsafe partial struct ISlangFileSystemExt
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISlangFileSystemExt* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISlangFileSystemExt* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISlangFileSystemExt* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void* _castAs(ISlangFileSystemExt* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* guid);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _loadFile(ISlangFileSystemExt* pThis, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** outBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getFileUniqueIdentity(ISlangFileSystemExt* pThis, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** outUniqueIdentity);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _calcCombinedPath(ISlangFileSystemExt* pThis, SlangPathType fromPathType, [NativeTypeName("const char *")] sbyte* fromPath, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** pathOut);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getPathType(ISlangFileSystemExt* pThis, [NativeTypeName("const char *")] sbyte* path, SlangPathType* pathTypeOut);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _getPath(ISlangFileSystemExt* pThis, PathKind kind, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** outPath);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _clearCache(ISlangFileSystemExt* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _enumeratePathContents(ISlangFileSystemExt* pThis, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("FileSystemContentsCallBack")] IntPtr callback, void* userData);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate OSPathKind _getOSPathKind(ISlangFileSystemExt* pThis);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISlangFileSystemExt* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISlangFileSystemExt* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISlangFileSystemExt* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangCastable.castAs" />
    public void* castAs([NativeTypeName("const SlangUUID &")] SlangUUID* guid)
    {
        fixed (ISlangFileSystemExt* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_castAs>(lpVtbl->castAs)(pThis, guid);
        }
    }

    /// <inheritdoc cref="ISlangFileSystem.loadFile" />
    [return: NativeTypeName("SlangResult")]
    public int loadFile([NativeTypeName("const char *")] sbyte* path, ISlangBlob** outBlob)
    {
        fixed (ISlangFileSystemExt* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadFile>(lpVtbl->loadFile)(pThis, path, outBlob);
        }
    }

    /// <include file='ISlangFileSystemExt.xml' path='doc/member[@name="ISlangFileSystemExt.getFileUniqueIdentity"]/*' />
    [return: NativeTypeName("SlangResult")]
    public int getFileUniqueIdentity([NativeTypeName("const char *")] sbyte* path, ISlangBlob** outUniqueIdentity)
    {
        fixed (ISlangFileSystemExt* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getFileUniqueIdentity>(lpVtbl->getFileUniqueIdentity)(pThis, path, outUniqueIdentity);
        }
    }

    /// <include file='ISlangFileSystemExt.xml' path='doc/member[@name="ISlangFileSystemExt.calcCombinedPath"]/*' />
    [return: NativeTypeName("SlangResult")]
    public int calcCombinedPath(SlangPathType fromPathType, [NativeTypeName("const char *")] sbyte* fromPath, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** pathOut)
    {
        fixed (ISlangFileSystemExt* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_calcCombinedPath>(lpVtbl->calcCombinedPath)(pThis, fromPathType, fromPath, path, pathOut);
        }
    }

    /// <include file='ISlangFileSystemExt.xml' path='doc/member[@name="ISlangFileSystemExt.getPathType"]/*' />
    [return: NativeTypeName("SlangResult")]
    public int getPathType([NativeTypeName("const char *")] sbyte* path, SlangPathType* pathTypeOut)
    {
        fixed (ISlangFileSystemExt* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getPathType>(lpVtbl->getPathType)(pThis, path, pathTypeOut);
        }
    }

    /// <include file='ISlangFileSystemExt.xml' path='doc/member[@name="ISlangFileSystemExt.getPath"]/*' />
    [return: NativeTypeName("SlangResult")]
    public int getPath(PathKind kind, [NativeTypeName("const char *")] sbyte* path, ISlangBlob** outPath)
    {
        fixed (ISlangFileSystemExt* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getPath>(lpVtbl->getPath)(pThis, kind, path, outPath);
        }
    }

    /// <include file='ISlangFileSystemExt.xml' path='doc/member[@name="ISlangFileSystemExt.clearCache"]/*' />
    public void clearCache()
    {
        fixed (ISlangFileSystemExt* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_clearCache>(lpVtbl->clearCache)(pThis);
        }
    }

    /// <include file='ISlangFileSystemExt.xml' path='doc/member[@name="ISlangFileSystemExt.enumeratePathContents"]/*' />
    [return: NativeTypeName("SlangResult")]
    public int enumeratePathContents([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("FileSystemContentsCallBack")] IntPtr callback, void* userData)
    {
        fixed (ISlangFileSystemExt* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_enumeratePathContents>(lpVtbl->enumeratePathContents)(pThis, path, callback, userData);
        }
    }

    /// <include file='ISlangFileSystemExt.xml' path='doc/member[@name="ISlangFileSystemExt.getOSPathKind"]/*' />
    public OSPathKind getOSPathKind()
    {
        fixed (ISlangFileSystemExt* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getOSPathKind>(lpVtbl->getOSPathKind)(pThis);
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
    }
}
