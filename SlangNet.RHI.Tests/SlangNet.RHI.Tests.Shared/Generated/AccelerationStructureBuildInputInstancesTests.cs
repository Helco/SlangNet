using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureBuildInputInstances" /> struct.</summary>
public static unsafe partial class AccelerationStructureBuildInputInstancesTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureBuildInputInstances" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureBuildInputInstances>(), Is.EqualTo(sizeof(AccelerationStructureBuildInputInstances)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureBuildInputInstances" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureBuildInputInstances).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureBuildInputInstances" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(AccelerationStructureBuildInputInstances), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(AccelerationStructureBuildInputInstances), Is.EqualTo(20));
        }
    }
}
