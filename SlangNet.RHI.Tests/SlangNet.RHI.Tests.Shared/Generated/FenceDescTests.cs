using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="FenceDesc" /> struct.</summary>
public static unsafe partial class FenceDescTests
{
    /// <summary>Validates that the <see cref="FenceDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FenceDesc>(), Is.EqualTo(sizeof(FenceDesc)));
    }

    /// <summary>Validates that the <see cref="FenceDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FenceDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="FenceDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(FenceDesc), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(FenceDesc), Is.EqualTo(16));
        }
    }
}
