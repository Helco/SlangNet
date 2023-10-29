using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="TypeReflection" /> struct.</summary>
public static unsafe partial class TypeReflectionTests
{
    /// <summary>Validates that the <see cref="TypeReflection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TypeReflection>(), Is.EqualTo(sizeof(TypeReflection)));
    }

    /// <summary>Validates that the <see cref="TypeReflection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TypeReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TypeReflection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TypeReflection), Is.EqualTo(1));
    }
}
