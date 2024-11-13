using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SurfaceConfig" /> struct.</summary>
public static unsafe partial class SurfaceConfigTests
{
    /// <summary>Validates that the <see cref="SurfaceConfig" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SurfaceConfig>(), Is.EqualTo(sizeof(SurfaceConfig)));
    }

    /// <summary>Validates that the <see cref="SurfaceConfig" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SurfaceConfig).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SurfaceConfig" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SurfaceConfig), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(SurfaceConfig), Is.EqualTo(24));
        }
    }
}
