using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ISampler" /> struct.</summary>
public static unsafe partial class ISamplerTests
{
    /// <summary>Validates that the <see cref="ISampler" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISampler>(), Is.EqualTo(sizeof(ISampler)));
    }

    /// <summary>Validates that the <see cref="ISampler" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISampler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISampler" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISampler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISampler), Is.EqualTo(4));
        }
    }
}
