using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="BufferWithOffset" /> struct.</summary>
public static unsafe partial class BufferWithOffsetTests
{
    /// <summary>Validates that the <see cref="BufferWithOffset" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BufferWithOffset>(), Is.EqualTo(sizeof(BufferWithOffset)));
    }

    /// <summary>Validates that the <see cref="BufferWithOffset" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BufferWithOffset).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="BufferWithOffset" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BufferWithOffset), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(BufferWithOffset), Is.EqualTo(8));
        }
    }
}
