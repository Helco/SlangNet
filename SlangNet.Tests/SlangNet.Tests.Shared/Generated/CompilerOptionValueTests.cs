using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="CompilerOptionValue" /> struct.</summary>
public static unsafe partial class CompilerOptionValueTests
{
    /// <summary>Validates that the <see cref="CompilerOptionValue" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CompilerOptionValue>(), Is.EqualTo(sizeof(CompilerOptionValue)));
    }

    /// <summary>Validates that the <see cref="CompilerOptionValue" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CompilerOptionValue).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CompilerOptionValue" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CompilerOptionValue), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(CompilerOptionValue), Is.EqualTo(20));
        }
    }
}
