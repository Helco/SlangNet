using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IShaderObject" /> struct.</summary>
public static unsafe partial class IShaderObjectTests
{
    /// <summary>Validates that the <see cref="IShaderObject" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IShaderObject>(), Is.EqualTo(sizeof(IShaderObject)));
    }

    /// <summary>Validates that the <see cref="IShaderObject" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IShaderObject).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IShaderObject" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IShaderObject), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IShaderObject), Is.EqualTo(4));
        }
    }
}
