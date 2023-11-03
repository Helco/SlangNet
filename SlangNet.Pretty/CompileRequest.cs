using System;
using SlangNet.Internal;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe sealed class CompileRequest : COMObject<ICompileRequest>
{
    internal CompileRequest(ICompileRequest* pointer) : base(pointer)
    {
    }
}
