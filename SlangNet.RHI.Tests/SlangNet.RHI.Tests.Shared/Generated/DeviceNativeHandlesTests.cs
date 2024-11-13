using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="DeviceNativeHandles" /> struct.</summary>
public static unsafe partial class DeviceNativeHandlesTests
{
    /// <summary>Validates that the <see cref="DeviceNativeHandles" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DeviceNativeHandles>(), Is.EqualTo(sizeof(DeviceNativeHandles)));
    }

    /// <summary>Validates that the <see cref="DeviceNativeHandles" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DeviceNativeHandles).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DeviceNativeHandles" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DeviceNativeHandles), Is.EqualTo(48));
    }
}
