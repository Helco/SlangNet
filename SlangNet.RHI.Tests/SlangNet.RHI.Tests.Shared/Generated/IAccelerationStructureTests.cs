using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IAccelerationStructure" /> struct.</summary>
public static unsafe partial class IAccelerationStructureTests
{
    /// <summary>Validates that the <see cref="IAccelerationStructure" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAccelerationStructure>(), Is.EqualTo(sizeof(IAccelerationStructure)));
    }

    /// <summary>Validates that the <see cref="IAccelerationStructure" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAccelerationStructure).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IAccelerationStructure" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAccelerationStructure), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAccelerationStructure), Is.EqualTo(4));
        }
    }
}
