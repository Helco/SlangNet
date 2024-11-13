using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="BufferDesc" /> struct.</summary>
public static unsafe partial class BufferDescTests
{
    /// <summary>Validates that the <see cref="BufferDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BufferDesc>(), Is.EqualTo(sizeof(BufferDesc)));
    }

    /// <summary>Validates that the <see cref="BufferDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BufferDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="BufferDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BufferDesc), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(BufferDesc), Is.EqualTo(32));
        }
    }
}
