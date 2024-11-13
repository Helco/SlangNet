using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureBuildInputProceduralPrimitives" /> struct.</summary>
public static unsafe partial class AccelerationStructureBuildInputProceduralPrimitivesTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureBuildInputProceduralPrimitives" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureBuildInputProceduralPrimitives>(), Is.EqualTo(sizeof(AccelerationStructureBuildInputProceduralPrimitives)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureBuildInputProceduralPrimitives" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureBuildInputProceduralPrimitives).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureBuildInputProceduralPrimitives" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(AccelerationStructureBuildInputProceduralPrimitives), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(AccelerationStructureBuildInputProceduralPrimitives), Is.EqualTo(24));
        }
    }
}
