using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IRHI" /> struct.</summary>
public static unsafe partial class IRHITests
{
    /// <summary>Validates that the <see cref="IRHI" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IRHI>(), Is.EqualTo(sizeof(IRHI)));
    }

    /// <summary>Validates that the <see cref="IRHI" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IRHI).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IRHI" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IRHI), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IRHI), Is.EqualTo(4));
        }
    }
}
