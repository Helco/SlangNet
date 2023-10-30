using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IGlobalSession" /> struct.</summary>
public static unsafe partial class IGlobalSessionTests
{
    /// <summary>Validates that the <see cref="IGlobalSession" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IGlobalSession>(), Is.EqualTo(sizeof(IGlobalSession)));
    }

    /// <summary>Validates that the <see cref="IGlobalSession" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IGlobalSession).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IGlobalSession" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IGlobalSession), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IGlobalSession), Is.EqualTo(4));
        }
    }
}
