using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IDevice" /> struct.</summary>
public static unsafe partial class IDeviceTests
{
    /// <summary>Validates that the <see cref="IDevice" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDevice>(), Is.EqualTo(sizeof(IDevice)));
    }

    /// <summary>Validates that the <see cref="IDevice" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDevice).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDevice" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDevice), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDevice), Is.EqualTo(4));
        }
    }
}
