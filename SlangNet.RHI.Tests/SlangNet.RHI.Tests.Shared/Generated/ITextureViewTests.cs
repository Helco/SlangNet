using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ITextureView" /> struct.</summary>
public static unsafe partial class ITextureViewTests
{
    /// <summary>Validates that the <see cref="ITextureView" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITextureView>(), Is.EqualTo(sizeof(ITextureView)));
    }

    /// <summary>Validates that the <see cref="ITextureView" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITextureView).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ITextureView" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITextureView), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITextureView), Is.EqualTo(4));
        }
    }
}
