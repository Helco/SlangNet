using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="CompilerOptionEntry" /> struct.</summary>
public static unsafe partial class CompilerOptionEntryTests
{
    /// <summary>Validates that the <see cref="CompilerOptionEntry" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CompilerOptionEntry>(), Is.EqualTo(sizeof(CompilerOptionEntry)));
    }

    /// <summary>Validates that the <see cref="CompilerOptionEntry" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CompilerOptionEntry).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CompilerOptionEntry" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CompilerOptionEntry), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(CompilerOptionEntry), Is.EqualTo(24));
        }
    }
}
