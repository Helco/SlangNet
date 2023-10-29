using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="TargetDesc" /> struct.</summary>
public static unsafe partial class TargetDescTests
{
    /// <summary>Validates that the <see cref="TargetDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TargetDesc>(), Is.EqualTo(sizeof(TargetDesc)));
    }

    /// <summary>Validates that the <see cref="TargetDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TargetDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TargetDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TargetDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(TargetDesc), Is.EqualTo(28));
        }
    }
}
