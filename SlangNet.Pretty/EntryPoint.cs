using System;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe sealed class EntryPoint : ComponentType
{
    public new IEntryPoint* Pointer => (IEntryPoint*)base.Pointer;

    internal EntryPoint(IEntryPoint* pointer) : base((IComponentType*)pointer)
    {
    }
}
