using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SurfaceInfo" /> struct.</summary>
public static unsafe partial class SurfaceInfoTests
{
    /// <summary>Validates that the <see cref="SurfaceInfo" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SurfaceInfo>(), Is.EqualTo(sizeof(SurfaceInfo)));
    }

    /// <summary>Validates that the <see cref="SurfaceInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SurfaceInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SurfaceInfo" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SurfaceInfo), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(SurfaceInfo), Is.EqualTo(16));
        }
    }
}
