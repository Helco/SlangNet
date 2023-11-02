using System;
using SlangNet.Internal;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe sealed class Module : COMObject<IModule>
{
    internal Module(IModule* pointer) : base(pointer)
    {
    }
}
