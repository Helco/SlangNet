using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IComputePipeline" /> struct.</summary>
public static unsafe partial class IComputePipelineTests
{
    /// <summary>Validates that the <see cref="IComputePipeline" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IComputePipeline>(), Is.EqualTo(sizeof(IComputePipeline)));
    }

    /// <summary>Validates that the <see cref="IComputePipeline" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IComputePipeline).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IComputePipeline" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IComputePipeline), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IComputePipeline), Is.EqualTo(4));
        }
    }
}
