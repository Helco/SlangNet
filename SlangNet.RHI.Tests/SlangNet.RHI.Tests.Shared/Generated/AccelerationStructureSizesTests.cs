using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureSizes" /> struct.</summary>
public static unsafe partial class AccelerationStructureSizesTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureSizes" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureSizes>(), Is.EqualTo(sizeof(AccelerationStructureSizes)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureSizes" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureSizes).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureSizes" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(AccelerationStructureSizes), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(AccelerationStructureSizes), Is.EqualTo(12));
        }
    }
}
