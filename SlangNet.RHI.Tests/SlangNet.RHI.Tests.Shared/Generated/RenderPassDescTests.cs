using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="RenderPassDesc" /> struct.</summary>
public static unsafe partial class RenderPassDescTests
{
    /// <summary>Validates that the <see cref="RenderPassDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RenderPassDesc>(), Is.EqualTo(sizeof(RenderPassDesc)));
    }

    /// <summary>Validates that the <see cref="RenderPassDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RenderPassDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="RenderPassDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(RenderPassDesc), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(RenderPassDesc), Is.EqualTo(12));
        }
    }
}
