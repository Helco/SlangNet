using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void FileSystemContentsCallBack(SlangPathType pathType, [NativeTypeName("const char *")] sbyte* name, void* userData);
