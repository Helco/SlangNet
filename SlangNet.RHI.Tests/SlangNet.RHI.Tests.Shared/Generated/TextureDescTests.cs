using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="TextureDesc" /> struct.</summary>
public static unsafe partial class TextureDescTests
{
    /// <summary>Validates that the <see cref="TextureDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TextureDesc>(), Is.EqualTo(sizeof(TextureDesc)));
    }

    /// <summary>Validates that the <see cref="TextureDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TextureDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TextureDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TextureDesc), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(TextureDesc), Is.EqualTo(60));
        }
    }
}
