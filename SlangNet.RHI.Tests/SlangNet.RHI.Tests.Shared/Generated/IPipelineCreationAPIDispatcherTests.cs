using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IPipelineCreationAPIDispatcher" /> struct.</summary>
public static unsafe partial class IPipelineCreationAPIDispatcherTests
{
    /// <summary>Validates that the <see cref="IPipelineCreationAPIDispatcher" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPipelineCreationAPIDispatcher>(), Is.EqualTo(sizeof(IPipelineCreationAPIDispatcher)));
    }

    /// <summary>Validates that the <see cref="IPipelineCreationAPIDispatcher" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPipelineCreationAPIDispatcher).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IPipelineCreationAPIDispatcher" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPipelineCreationAPIDispatcher), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPipelineCreationAPIDispatcher), Is.EqualTo(4));
        }
    }
}
