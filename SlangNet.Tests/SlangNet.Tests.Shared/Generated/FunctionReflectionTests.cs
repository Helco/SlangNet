using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="FunctionReflection" /> struct.</summary>
public static unsafe partial class FunctionReflectionTests
{
    /// <summary>Validates that the <see cref="FunctionReflection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FunctionReflection>(), Is.EqualTo(sizeof(FunctionReflection)));
    }

    /// <summary>Validates that the <see cref="FunctionReflection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FunctionReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="FunctionReflection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FunctionReflection), Is.EqualTo(1));
    }
}
