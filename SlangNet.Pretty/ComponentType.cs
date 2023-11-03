using System;
using SlangNet.Internal;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe class ComponentType : COMObject<IComponentType>
{
    internal static ComponentType? CreateFromPointer(IComponentType* pointer)
    {
        if (pointer == null)
            return null;
        throw new NotImplementedException("I have not implemented ComponentType and their derived types");
    }

    protected ComponentType(IComponentType* pointer) : base(pointer) {}
}
