using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IShaderProgram" /> struct.</summary>
public static unsafe partial class IShaderProgramTests
{
    /// <summary>Validates that the <see cref="IShaderProgram" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IShaderProgram>(), Is.EqualTo(sizeof(IShaderProgram)));
    }

    /// <summary>Validates that the <see cref="IShaderProgram" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IShaderProgram).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IShaderProgram" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IShaderProgram), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IShaderProgram), Is.EqualTo(4));
        }
    }
}
