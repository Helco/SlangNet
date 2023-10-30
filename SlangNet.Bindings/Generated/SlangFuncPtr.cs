using System.Runtime.InteropServices;

namespace SlangNet.Unsafe;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void SlangFuncPtr();
