using System;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe sealed class Module : ComponentType
{
    public new IModule* Pointer => (IModule*)base.Pointer;

    internal Module(IModule* pointer) : base((IComponentType*)pointer)
    {
    }
}
