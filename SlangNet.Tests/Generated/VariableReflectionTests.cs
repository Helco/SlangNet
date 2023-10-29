using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="VariableReflection" /> struct.</summary>
public static unsafe partial class VariableReflectionTests
{
    /// <summary>Validates that the <see cref="VariableReflection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VariableReflection>(), Is.EqualTo(sizeof(VariableReflection)));
    }

    /// <summary>Validates that the <see cref="VariableReflection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VariableReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VariableReflection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(VariableReflection), Is.EqualTo(1));
    }
}
