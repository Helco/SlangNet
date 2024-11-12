using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SpecializationArg" /> struct.</summary>
public static unsafe partial class SpecializationArgTests
{
    /// <summary>Validates that the <see cref="SpecializationArg" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SpecializationArg>(), Is.EqualTo(sizeof(SpecializationArg)));
    }

    /// <summary>Validates that the <see cref="SpecializationArg" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpecializationArg).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SpecializationArg" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SpecializationArg), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SpecializationArg), Is.EqualTo(8));
        }
    }
}
