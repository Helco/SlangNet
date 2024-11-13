using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="RenderPassColorAttachment" /> struct.</summary>
public static unsafe partial class RenderPassColorAttachmentTests
{
    /// <summary>Validates that the <see cref="RenderPassColorAttachment" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RenderPassColorAttachment>(), Is.EqualTo(sizeof(RenderPassColorAttachment)));
    }

    /// <summary>Validates that the <see cref="RenderPassColorAttachment" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RenderPassColorAttachment).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="RenderPassColorAttachment" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(RenderPassColorAttachment), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(RenderPassColorAttachment), Is.EqualTo(32));
        }
    }
}
