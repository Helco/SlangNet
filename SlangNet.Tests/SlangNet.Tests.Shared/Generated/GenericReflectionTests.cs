using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="GenericReflection" /> struct.</summary>
public static unsafe partial class GenericReflectionTests
{
    /// <summary>Validates that the <see cref="GenericReflection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GenericReflection>(), Is.EqualTo(sizeof(GenericReflection)));
    }

    /// <summary>Validates that the <see cref="GenericReflection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GenericReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="GenericReflection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(GenericReflection), Is.EqualTo(1));
    }
}
