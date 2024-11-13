using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="BufferRange" /> struct.</summary>
public static unsafe partial class BufferRangeTests
{
    /// <summary>Validates that the <see cref="BufferRange" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BufferRange>(), Is.EqualTo(sizeof(BufferRange)));
    }

    /// <summary>Validates that the <see cref="BufferRange" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BufferRange).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="BufferRange" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BufferRange), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(BufferRange), Is.EqualTo(8));
        }
    }
}
