using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="PreprocessorMacroDesc" /> struct.</summary>
public static unsafe partial class PreprocessorMacroDescTests
{
    /// <summary>Validates that the <see cref="PreprocessorMacroDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PreprocessorMacroDesc>(), Is.EqualTo(sizeof(PreprocessorMacroDesc)));
    }

    /// <summary>Validates that the <see cref="PreprocessorMacroDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PreprocessorMacroDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="PreprocessorMacroDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PreprocessorMacroDesc), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(PreprocessorMacroDesc), Is.EqualTo(8));
        }
    }
}
