using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="RenderState" /> struct.</summary>
public static unsafe partial class RenderStateTests
{
    /// <summary>Validates that the <see cref="RenderState" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RenderState>(), Is.EqualTo(sizeof(RenderState)));
    }

    /// <summary>Validates that the <see cref="RenderState" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RenderState).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="RenderState" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(RenderState), Is.EqualTo(960));
        }
        else
        {
            Assert.That(sizeof(RenderState), Is.EqualTo(804));
        }
    }
}
