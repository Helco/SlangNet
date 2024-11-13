using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureBuildDesc" /> struct.</summary>
public static unsafe partial class AccelerationStructureBuildDescTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureBuildDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureBuildDesc>(), Is.EqualTo(sizeof(AccelerationStructureBuildDesc)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureBuildDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureBuildDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureBuildDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(AccelerationStructureBuildDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(AccelerationStructureBuildDesc), Is.EqualTo(28));
        }
    }
}
