using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="TypeLayoutReflection" /> struct.</summary>
public static unsafe partial class TypeLayoutReflectionTests
{
    /// <summary>Validates that the <see cref="TypeLayoutReflection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TypeLayoutReflection>(), Is.EqualTo(sizeof(TypeLayoutReflection)));
    }

    /// <summary>Validates that the <see cref="TypeLayoutReflection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TypeLayoutReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TypeLayoutReflection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TypeLayoutReflection), Is.EqualTo(1));
    }
}
