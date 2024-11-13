using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureInstanceDescMetal" /> struct.</summary>
public static unsafe partial class AccelerationStructureInstanceDescMetalTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescMetal" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureInstanceDescMetal>(), Is.EqualTo(sizeof(AccelerationStructureInstanceDescMetal)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescMetal" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureInstanceDescMetal).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescMetal" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AccelerationStructureInstanceDescMetal), Is.EqualTo(68));
    }
}
