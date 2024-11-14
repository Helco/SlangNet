using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SlangReflectionGenericArg" /> struct.</summary>
public static unsafe partial class SlangReflectionGenericArgTests
{
    /// <summary>Validates that the <see cref="SlangReflectionGenericArg" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangReflectionGenericArg>(), Is.EqualTo(sizeof(SlangReflectionGenericArg)));
    }

    /// <summary>Validates that the <see cref="SlangReflectionGenericArg" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(SlangReflectionGenericArg).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangReflectionGenericArg" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SlangReflectionGenericArg), Is.EqualTo(8));
    }
}
