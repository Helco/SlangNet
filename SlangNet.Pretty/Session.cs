using System;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe sealed class Session : Internal.COMObject<ISession>
{
    internal Session(ISession* pointer) : base(pointer)
    {
    }
}
