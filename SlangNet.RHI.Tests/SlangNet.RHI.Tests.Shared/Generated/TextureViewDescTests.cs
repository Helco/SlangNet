using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="TextureViewDesc" /> struct.</summary>
public static unsafe partial class TextureViewDescTests
{
    /// <summary>Validates that the <see cref="TextureViewDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TextureViewDesc>(), Is.EqualTo(sizeof(TextureViewDesc)));
    }

    /// <summary>Validates that the <see cref="TextureViewDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TextureViewDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TextureViewDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TextureViewDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(TextureViewDesc), Is.EqualTo(28));
        }
    }
}
