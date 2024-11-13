using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureInstanceDescOptix" /> struct.</summary>
public static unsafe partial class AccelerationStructureInstanceDescOptixTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescOptix" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureInstanceDescOptix>(), Is.EqualTo(sizeof(AccelerationStructureInstanceDescOptix)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescOptix" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureInstanceDescOptix).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescOptix" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AccelerationStructureInstanceDescOptix), Is.EqualTo(80));
    }
}
