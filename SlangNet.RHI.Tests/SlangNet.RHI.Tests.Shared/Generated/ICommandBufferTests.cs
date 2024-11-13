using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ICommandBuffer" /> struct.</summary>
public static unsafe partial class ICommandBufferTests
{
    /// <summary>Validates that the <see cref="ICommandBuffer" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICommandBuffer>(), Is.EqualTo(sizeof(ICommandBuffer)));
    }

    /// <summary>Validates that the <see cref="ICommandBuffer" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICommandBuffer).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ICommandBuffer" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICommandBuffer), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICommandBuffer), Is.EqualTo(4));
        }
    }
}
