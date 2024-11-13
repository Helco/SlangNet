using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IPipeline" /> struct.</summary>
public static unsafe partial class IPipelineTests
{
    /// <summary>Validates that the <see cref="IPipeline" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPipeline>(), Is.EqualTo(sizeof(IPipeline)));
    }

    /// <summary>Validates that the <see cref="IPipeline" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPipeline).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IPipeline" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPipeline), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPipeline), Is.EqualTo(4));
        }
    }
}
