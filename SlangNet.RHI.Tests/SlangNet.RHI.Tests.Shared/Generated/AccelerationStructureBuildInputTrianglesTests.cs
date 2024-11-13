using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureBuildInputTriangles" /> struct.</summary>
public static unsafe partial class AccelerationStructureBuildInputTrianglesTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureBuildInputTriangles" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureBuildInputTriangles>(), Is.EqualTo(sizeof(AccelerationStructureBuildInputTriangles)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureBuildInputTriangles" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureBuildInputTriangles).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureBuildInputTriangles" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(AccelerationStructureBuildInputTriangles), Is.EqualTo(88));
        }
        else
        {
            Assert.That(sizeof(AccelerationStructureBuildInputTriangles), Is.EqualTo(52));
        }
    }
}
