using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="TypeParameterReflection" /> struct.</summary>
public static unsafe partial class TypeParameterReflectionTests
{
    /// <summary>Validates that the <see cref="TypeParameterReflection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TypeParameterReflection>(), Is.EqualTo(sizeof(TypeParameterReflection)));
    }

    /// <summary>Validates that the <see cref="TypeParameterReflection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TypeParameterReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TypeParameterReflection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TypeParameterReflection), Is.EqualTo(1));
    }
}
