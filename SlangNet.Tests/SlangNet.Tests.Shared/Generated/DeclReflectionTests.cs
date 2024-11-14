using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="DeclReflection" /> struct.</summary>
public static unsafe partial class DeclReflectionTests
{
    /// <summary>Validates that the <see cref="DeclReflection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DeclReflection>(), Is.EqualTo(sizeof(DeclReflection)));
    }

    /// <summary>Validates that the <see cref="DeclReflection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DeclReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DeclReflection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DeclReflection), Is.EqualTo(1));
    }
}
