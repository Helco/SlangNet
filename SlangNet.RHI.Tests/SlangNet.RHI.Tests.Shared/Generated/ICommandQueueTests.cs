using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ICommandQueue" /> struct.</summary>
public static unsafe partial class ICommandQueueTests
{
    /// <summary>Validates that the <see cref="ICommandQueue" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICommandQueue>(), Is.EqualTo(sizeof(ICommandQueue)));
    }

    /// <summary>Validates that the <see cref="ICommandQueue" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICommandQueue).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ICommandQueue" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICommandQueue), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICommandQueue), Is.EqualTo(4));
        }
    }
}
