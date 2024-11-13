using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AccelerationStructureInstanceDescD3D12" /> struct.</summary>
public static unsafe partial class AccelerationStructureInstanceDescD3D12Tests
{
    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescD3D12" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccelerationStructureInstanceDescD3D12>(), Is.EqualTo(sizeof(AccelerationStructureInstanceDescD3D12)));
    }

    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescD3D12" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccelerationStructureInstanceDescD3D12).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccelerationStructureInstanceDescD3D12" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AccelerationStructureInstanceDescD3D12), Is.EqualTo(64));
    }
}
