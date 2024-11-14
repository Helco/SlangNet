using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SlangReflectionGeneric" /> struct.</summary>
public static unsafe partial class SlangReflectionGenericTests
{
    /// <summary>Validates that the <see cref="SlangReflectionGeneric" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangReflectionGeneric>(), Is.EqualTo(sizeof(SlangReflectionGeneric)));
    }

    /// <summary>Validates that the <see cref="SlangReflectionGeneric" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SlangReflectionGeneric).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangReflectionGeneric" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SlangReflectionGeneric), Is.EqualTo(1));
    }
}
