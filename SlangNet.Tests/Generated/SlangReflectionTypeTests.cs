using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SlangReflectionType" /> struct.</summary>
public static unsafe partial class SlangReflectionTypeTests
{
    /// <summary>Validates that the <see cref="SlangReflectionType" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangReflectionType>(), Is.EqualTo(sizeof(SlangReflectionType)));
    }

    /// <summary>Validates that the <see cref="SlangReflectionType" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SlangReflectionType).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangReflectionType" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SlangReflectionType), Is.EqualTo(1));
    }
}
