using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureBuildInputMotionOptions" /> struct.</summary>
public static unsafe partial class AccelerationStructureBuildInputMotionOptionsTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureBuildInputMotionOptions" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureBuildInputMotionOptions>(), Is.EqualTo(sizeof(AccelerationStructureBuildInputMotionOptions)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureBuildInputMotionOptions" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureBuildInputMotionOptions).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureBuildInputMotionOptions" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AccelerationStructureBuildInputMotionOptions), Is.EqualTo(12));
    }
}
