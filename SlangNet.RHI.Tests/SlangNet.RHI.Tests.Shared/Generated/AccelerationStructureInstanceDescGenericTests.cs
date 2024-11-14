using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureInstanceDescGeneric" /> struct.</summary>
public static unsafe partial class AccelerationStructureInstanceDescGenericTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescGeneric" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureInstanceDescGeneric>(), Is.EqualTo(sizeof(AccelerationStructureInstanceDescGeneric)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescGeneric" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureInstanceDescGeneric).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescGeneric" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AccelerationStructureInstanceDescGeneric), Is.EqualTo(64));
    }
}