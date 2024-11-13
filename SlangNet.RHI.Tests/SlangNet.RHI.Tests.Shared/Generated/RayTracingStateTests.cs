using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="RayTracingState" /> struct.</summary>
public static unsafe partial class RayTracingStateTests
{
    /// <summary>Validates that the <see cref="RayTracingState" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RayTracingState>(), Is.EqualTo(sizeof(RayTracingState)));
    }

    /// <summary>Validates that the <see cref="RayTracingState" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RayTracingState).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="RayTracingState" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(RayTracingState), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(RayTracingState), Is.EqualTo(12));
        }
    }
}
