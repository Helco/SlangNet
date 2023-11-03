using System;
using SlangNet.Unsafe;

namespace SlangNet;

public unsafe sealed class TypeConformance : ComponentType
{
    public new ITypeConformance* Pointer => (ITypeConformance*)base.Pointer;

    internal TypeConformance(ITypeConformance* pointer) : base((IComponentType*)pointer)
    {
    }
}
