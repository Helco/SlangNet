using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SubresourceData" /> struct.</summary>
public static unsafe partial class SubresourceDataTests
{
    /// <summary>Validates that the <see cref="SubresourceData" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SubresourceData>(), Is.EqualTo(sizeof(SubresourceData)));
    }

    /// <summary>Validates that the <see cref="SubresourceData" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SubresourceData).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SubresourceData" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SubresourceData), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(SubresourceData), Is.EqualTo(12));
        }
    }
}
