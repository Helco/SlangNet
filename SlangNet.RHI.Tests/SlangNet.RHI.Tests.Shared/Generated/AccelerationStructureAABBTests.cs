using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureAABB" /> struct.</summary>
public static unsafe partial class AccelerationStructureAABBTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureAABB" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureAABB>(), Is.EqualTo(sizeof(AccelerationStructureAABB)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureAABB" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureAABB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureAABB" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AccelerationStructureAABB), Is.EqualTo(24));
    }
}
