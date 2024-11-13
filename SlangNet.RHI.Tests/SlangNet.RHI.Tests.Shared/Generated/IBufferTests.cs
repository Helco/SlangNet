using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IBuffer" /> struct.</summary>
public static unsafe partial class IBufferTests
{
    /// <summary>Validates that the <see cref="IBuffer" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IBuffer>(), Is.EqualTo(sizeof(IBuffer)));
    }

    /// <summary>Validates that the <see cref="IBuffer" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IBuffer).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IBuffer" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IBuffer), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IBuffer), Is.EqualTo(4));
        }
    }
}
