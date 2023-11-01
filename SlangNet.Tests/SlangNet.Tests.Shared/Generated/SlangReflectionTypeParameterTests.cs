using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SlangReflectionTypeParameter" /> struct.</summary>
public static unsafe partial class SlangReflectionTypeParameterTests
{
    /// <summary>Validates that the <see cref="SlangReflectionTypeParameter" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangReflectionTypeParameter>(), Is.EqualTo(sizeof(SlangReflectionTypeParameter)));
    }

    /// <summary>Validates that the <see cref="SlangReflectionTypeParameter" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SlangReflectionTypeParameter).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangReflectionTypeParameter" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SlangReflectionTypeParameter), Is.EqualTo(1));
    }
}
