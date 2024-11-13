using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="DeviceInfo" /> struct.</summary>
public static unsafe partial class DeviceInfoTests
{
    /// <summary>Validates that the <see cref="DeviceInfo" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DeviceInfo>(), Is.EqualTo(sizeof(DeviceInfo)));
    }

    /// <summary>Validates that the <see cref="DeviceInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DeviceInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DeviceInfo" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DeviceInfo), Is.EqualTo(184));
        }
        else
        {
            Assert.That(sizeof(DeviceInfo), Is.EqualTo(176));
        }
    }
}
