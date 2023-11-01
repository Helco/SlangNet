using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SlangReflectionModifier" /> struct.</summary>
public static unsafe partial class SlangReflectionModifierTests
{
    /// <summary>Validates that the <see cref="SlangReflectionModifier" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangReflectionModifier>(), Is.EqualTo(sizeof(SlangReflectionModifier)));
    }

    /// <summary>Validates that the <see cref="SlangReflectionModifier" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SlangReflectionModifier).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangReflectionModifier" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SlangReflectionModifier), Is.EqualTo(1));
    }
}
