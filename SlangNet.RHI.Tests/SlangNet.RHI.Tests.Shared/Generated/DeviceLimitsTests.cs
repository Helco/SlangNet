using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="DeviceLimits" /> struct.</summary>
public static unsafe partial class DeviceLimitsTests
{
    /// <summary>Validates that the <see cref="DeviceLimits" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DeviceLimits>(), Is.EqualTo(sizeof(DeviceLimits)));
    }

    /// <summary>Validates that the <see cref="DeviceLimits" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DeviceLimits).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DeviceLimits" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DeviceLimits), Is.EqualTo(92));
    }
}
