using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IRenderPipeline" /> struct.</summary>
public static unsafe partial class IRenderPipelineTests
{
    /// <summary>Validates that the <see cref="IRenderPipeline" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IRenderPipeline>(), Is.EqualTo(sizeof(IRenderPipeline)));
    }

    /// <summary>Validates that the <see cref="IRenderPipeline" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IRenderPipeline).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IRenderPipeline" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IRenderPipeline), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IRenderPipeline), Is.EqualTo(4));
        }
    }
}
