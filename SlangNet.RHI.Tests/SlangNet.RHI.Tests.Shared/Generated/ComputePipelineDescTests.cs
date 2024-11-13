using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ComputePipelineDesc" /> struct.</summary>
public static unsafe partial class ComputePipelineDescTests
{
    /// <summary>Validates that the <see cref="ComputePipelineDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ComputePipelineDesc>(), Is.EqualTo(sizeof(ComputePipelineDesc)));
    }

    /// <summary>Validates that the <see cref="ComputePipelineDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ComputePipelineDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ComputePipelineDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ComputePipelineDesc), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(ComputePipelineDesc), Is.EqualTo(8));
        }
    }
}
