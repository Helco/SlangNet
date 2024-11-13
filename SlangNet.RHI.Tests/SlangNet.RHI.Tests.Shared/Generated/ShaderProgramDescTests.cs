using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ShaderProgramDesc" /> struct.</summary>
public static unsafe partial class ShaderProgramDescTests
{
    /// <summary>Validates that the <see cref="ShaderProgramDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ShaderProgramDesc>(), Is.EqualTo(sizeof(ShaderProgramDesc)));
    }

    /// <summary>Validates that the <see cref="ShaderProgramDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ShaderProgramDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ShaderProgramDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ShaderProgramDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(ShaderProgramDesc), Is.EqualTo(16));
        }
    }
}
