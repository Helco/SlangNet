using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SamplerDesc" /> struct.</summary>
public static unsafe partial class SamplerDescTests
{
    /// <summary>Validates that the <see cref="SamplerDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SamplerDesc>(), Is.EqualTo(sizeof(SamplerDesc)));
    }

    /// <summary>Validates that the <see cref="SamplerDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SamplerDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SamplerDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SamplerDesc), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(SamplerDesc), Is.EqualTo(68));
        }
    }
}
