using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="FormatInfo" /> struct.</summary>
public static unsafe partial class FormatInfoTests
{
    /// <summary>Validates that the <see cref="FormatInfo" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FormatInfo>(), Is.EqualTo(sizeof(FormatInfo)));
    }

    /// <summary>Validates that the <see cref="FormatInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FormatInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="FormatInfo" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(FormatInfo), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(FormatInfo), Is.EqualTo(32));
        }
    }
}
