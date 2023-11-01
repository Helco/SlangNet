using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SlangReflectionTypeLayout" /> struct.</summary>
public static unsafe partial class SlangReflectionTypeLayoutTests
{
    /// <summary>Validates that the <see cref="SlangReflectionTypeLayout" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangReflectionTypeLayout>(), Is.EqualTo(sizeof(SlangReflectionTypeLayout)));
    }

    /// <summary>Validates that the <see cref="SlangReflectionTypeLayout" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SlangReflectionTypeLayout).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangReflectionTypeLayout" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SlangReflectionTypeLayout), Is.EqualTo(1));
    }
}
