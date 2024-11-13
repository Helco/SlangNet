using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ComputeState" /> struct.</summary>
public static unsafe partial class ComputeStateTests
{
    /// <summary>Validates that the <see cref="ComputeState" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ComputeState>(), Is.EqualTo(sizeof(ComputeState)));
    }

    /// <summary>Validates that the <see cref="ComputeState" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ComputeState).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ComputeState" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ComputeState), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(ComputeState), Is.EqualTo(8));
        }
    }
}
