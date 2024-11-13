using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ISurface" /> struct.</summary>
public static unsafe partial class ISurfaceTests
{
    /// <summary>Validates that the <see cref="ISurface" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISurface>(), Is.EqualTo(sizeof(ISurface)));
    }

    /// <summary>Validates that the <see cref="ISurface" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISurface).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISurface" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISurface), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISurface), Is.EqualTo(4));
        }
    }
}
