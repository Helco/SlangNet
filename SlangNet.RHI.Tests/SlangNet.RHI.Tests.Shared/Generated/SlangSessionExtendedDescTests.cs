using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SlangSessionExtendedDesc" /> struct.</summary>
public static unsafe partial class SlangSessionExtendedDescTests
{
    /// <summary>Validates that the <see cref="SlangSessionExtendedDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangSessionExtendedDesc>(), Is.EqualTo(sizeof(SlangSessionExtendedDesc)));
    }

    /// <summary>Validates that the <see cref="SlangSessionExtendedDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SlangSessionExtendedDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangSessionExtendedDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SlangSessionExtendedDesc), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SlangSessionExtendedDesc), Is.EqualTo(12));
        }
    }
}
