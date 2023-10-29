using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="SlangReflectionUserAttribute" /> struct.</summary>
public static unsafe partial class SlangReflectionUserAttributeTests
{
    /// <summary>Validates that the <see cref="SlangReflectionUserAttribute" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangReflectionUserAttribute>(), Is.EqualTo(sizeof(SlangReflectionUserAttribute)));
    }

    /// <summary>Validates that the <see cref="SlangReflectionUserAttribute" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SlangReflectionUserAttribute).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangReflectionUserAttribute" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SlangReflectionUserAttribute), Is.EqualTo(1));
    }
}
