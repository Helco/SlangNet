using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="DeviceDesc" /> struct.</summary>
public static unsafe partial class DeviceDescTests
{
    /// <summary>Validates that the <see cref="DeviceDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DeviceDesc>(), Is.EqualTo(sizeof(DeviceDesc)));
    }

    /// <summary>Validates that the <see cref="DeviceDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DeviceDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DeviceDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DeviceDesc), Is.EqualTo(208));
        }
        else
        {
            Assert.That(sizeof(DeviceDesc), Is.EqualTo(144));
        }
    }
}