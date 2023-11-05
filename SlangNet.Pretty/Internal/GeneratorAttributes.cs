using System;

namespace SlangNet;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
internal sealed class GenerateThrowingMethodsAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Method)]
internal sealed class IgnoreThrowingMethodAttribute : Attribute
{
}
