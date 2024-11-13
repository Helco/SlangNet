using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureQueryDesc" /> struct.</summary>
public static unsafe partial class AccelerationStructureQueryDescTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureQueryDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureQueryDesc>(), Is.EqualTo(sizeof(AccelerationStructureQueryDesc)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureQueryDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureQueryDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureQueryDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(AccelerationStructureQueryDesc), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(AccelerationStructureQueryDesc), Is.EqualTo(12));
        }
    }
}
