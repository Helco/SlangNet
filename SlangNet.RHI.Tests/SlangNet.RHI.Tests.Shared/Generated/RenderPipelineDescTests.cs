using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="RenderPipelineDesc" /> struct.</summary>
public static unsafe partial class RenderPipelineDescTests
{
    /// <summary>Validates that the <see cref="RenderPipelineDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RenderPipelineDesc>(), Is.EqualTo(sizeof(RenderPipelineDesc)));
    }

    /// <summary>Validates that the <see cref="RenderPipelineDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RenderPipelineDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="RenderPipelineDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(RenderPipelineDesc), Is.EqualTo(104));
        }
        else
        {
            Assert.That(sizeof(RenderPipelineDesc), Is.EqualTo(88));
        }
    }
}
