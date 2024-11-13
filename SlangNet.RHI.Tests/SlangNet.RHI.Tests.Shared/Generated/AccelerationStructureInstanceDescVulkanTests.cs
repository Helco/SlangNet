using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureInstanceDescVulkan" /> struct.</summary>
public static unsafe partial class AccelerationStructureInstanceDescVulkanTests
{
    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescVulkan" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureInstanceDescVulkan>(), Is.EqualTo(sizeof(AccelerationStructureInstanceDescVulkan)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescVulkan" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureInstanceDescVulkan).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescVulkan" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AccelerationStructureInstanceDescVulkan), Is.EqualTo(64));
    }
}
