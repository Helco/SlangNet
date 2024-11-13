using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ITexture" /> struct.</summary>
public static unsafe partial class ITextureTests
{
    /// <summary>Validates that the <see cref="ITexture" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITexture>(), Is.EqualTo(sizeof(ITexture)));
    }

    /// <summary>Validates that the <see cref="ITexture" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITexture).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ITexture" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITexture), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITexture), Is.EqualTo(4));
        }
    }
}
