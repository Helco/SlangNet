using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="D3D12DeviceExtendedDesc" /> struct.</summary>
public static unsafe partial class D3D12DeviceExtendedDescTests
{
    /// <summary>Validates that the <see cref="D3D12DeviceExtendedDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12DeviceExtendedDesc>(), Is.EqualTo(sizeof(D3D12DeviceExtendedDesc)));
    }

    /// <summary>Validates that the <see cref="D3D12DeviceExtendedDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12DeviceExtendedDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="D3D12DeviceExtendedDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12DeviceExtendedDesc), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(D3D12DeviceExtendedDesc), Is.EqualTo(16));
        }
    }
}
