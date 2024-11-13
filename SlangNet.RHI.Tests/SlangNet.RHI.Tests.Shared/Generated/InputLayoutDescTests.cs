using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="InputLayoutDesc" /> struct.</summary>
public static unsafe partial class InputLayoutDescTests
{
    /// <summary>Validates that the <see cref="InputLayoutDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<InputLayoutDesc>(), Is.EqualTo(sizeof(InputLayoutDesc)));
    }

    /// <summary>Validates that the <see cref="InputLayoutDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(InputLayoutDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="InputLayoutDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(InputLayoutDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(InputLayoutDesc), Is.EqualTo(16));
        }
    }
}
