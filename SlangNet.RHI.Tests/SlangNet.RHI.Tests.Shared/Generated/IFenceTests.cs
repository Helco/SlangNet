using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IFence" /> struct.</summary>
public static unsafe partial class IFenceTests
{
    /// <summary>Validates that the <see cref="IFence" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IFence>(), Is.EqualTo(sizeof(IFence)));
    }

    /// <summary>Validates that the <see cref="IFence" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IFence).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IFence" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IFence), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IFence), Is.EqualTo(4));
        }
    }
}
