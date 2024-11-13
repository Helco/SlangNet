using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="RayTracingPipelineDesc" /> struct.</summary>
public static unsafe partial class RayTracingPipelineDescTests
{
    /// <summary>Validates that the <see cref="RayTracingPipelineDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RayTracingPipelineDesc>(), Is.EqualTo(sizeof(RayTracingPipelineDesc)));
    }

    /// <summary>Validates that the <see cref="RayTracingPipelineDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RayTracingPipelineDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="RayTracingPipelineDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(RayTracingPipelineDesc), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(RayTracingPipelineDesc), Is.EqualTo(28));
        }
    }
}
