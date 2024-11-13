using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="HitGroupDesc" /> struct.</summary>
public static unsafe partial class HitGroupDescTests
{
    /// <summary>Validates that the <see cref="HitGroupDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HitGroupDesc>(), Is.EqualTo(sizeof(HitGroupDesc)));
    }

    /// <summary>Validates that the <see cref="HitGroupDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HitGroupDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="HitGroupDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(HitGroupDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(HitGroupDesc), Is.EqualTo(16));
        }
    }
}
