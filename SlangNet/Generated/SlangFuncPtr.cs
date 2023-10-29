using System.Runtime.InteropServices;

namespace SlangNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void SlangFuncPtr();
