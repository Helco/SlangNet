using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureHandle" /> struct.</summary>
public static unsafe partial class AccelerationStructureHandleTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureHandle" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureHandle>(), Is.EqualTo(sizeof(AccelerationStructureHandle)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureHandle" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureHandle).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureHandle" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AccelerationStructureHandle), Is.EqualTo(8));
    }
}
