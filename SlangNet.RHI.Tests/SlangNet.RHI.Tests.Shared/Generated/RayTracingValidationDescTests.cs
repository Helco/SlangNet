using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="RayTracingValidationDesc" /> struct.</summary>
public static unsafe partial class RayTracingValidationDescTests
{
    /// <summary>Validates that the <see cref="RayTracingValidationDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RayTracingValidationDesc>(), Is.EqualTo(sizeof(RayTracingValidationDesc)));
    }

    /// <summary>Validates that the <see cref="RayTracingValidationDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RayTracingValidationDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="RayTracingValidationDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RayTracingValidationDesc), Is.EqualTo(8));
    }
}
