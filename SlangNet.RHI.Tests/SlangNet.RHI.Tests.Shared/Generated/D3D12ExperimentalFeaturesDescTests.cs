using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="D3D12ExperimentalFeaturesDesc" /> struct.</summary>
public static unsafe partial class D3D12ExperimentalFeaturesDescTests
{
    /// <summary>Validates that the <see cref="D3D12ExperimentalFeaturesDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12ExperimentalFeaturesDesc>(), Is.EqualTo(sizeof(D3D12ExperimentalFeaturesDesc)));
    }

    /// <summary>Validates that the <see cref="D3D12ExperimentalFeaturesDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12ExperimentalFeaturesDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="D3D12ExperimentalFeaturesDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12ExperimentalFeaturesDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(D3D12ExperimentalFeaturesDesc), Is.EqualTo(20));
        }
    }
}
