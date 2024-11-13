using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="InputElementDesc" /> struct.</summary>
public static unsafe partial class InputElementDescTests
{
    /// <summary>Validates that the <see cref="InputElementDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<InputElementDesc>(), Is.EqualTo(sizeof(InputElementDesc)));
    }

    /// <summary>Validates that the <see cref="InputElementDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(InputElementDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="InputElementDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(InputElementDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(InputElementDesc), Is.EqualTo(20));
        }
    }
}
