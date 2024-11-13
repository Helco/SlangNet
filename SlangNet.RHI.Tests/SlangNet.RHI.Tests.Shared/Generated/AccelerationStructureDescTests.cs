using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureDesc" /> struct.</summary>
public static unsafe partial class AccelerationStructureDescTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureDesc>(), Is.EqualTo(sizeof(AccelerationStructureDesc)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(AccelerationStructureDesc), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(AccelerationStructureDesc), Is.EqualTo(8));
        }
    }
}
