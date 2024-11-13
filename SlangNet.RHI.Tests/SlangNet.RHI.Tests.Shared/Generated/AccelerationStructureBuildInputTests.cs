using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureBuildInput" /> struct.</summary>
public static unsafe partial class AccelerationStructureBuildInputTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureBuildInput" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureBuildInput>(), Is.EqualTo(sizeof(AccelerationStructureBuildInput)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureBuildInput" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureBuildInput).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureBuildInput" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AccelerationStructureBuildInput), Is.EqualTo(1));
    }
}
