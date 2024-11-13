using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IRayTracingPipeline" /> struct.</summary>
public static unsafe partial class IRayTracingPipelineTests
{
    /// <summary>Validates that the <see cref="IRayTracingPipeline" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IRayTracingPipeline>(), Is.EqualTo(sizeof(IRayTracingPipeline)));
    }

    /// <summary>Validates that the <see cref="IRayTracingPipeline" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IRayTracingPipeline).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IRayTracingPipeline" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IRayTracingPipeline), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IRayTracingPipeline), Is.EqualTo(4));
        }
    }
}
