using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ISlangProfiler" /> struct.</summary>
public static unsafe partial class ISlangProfilerTests
{
    /// <summary>Validates that the <see cref="ISlangProfiler" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISlangProfiler>(), Is.EqualTo(sizeof(ISlangProfiler)));
    }

    /// <summary>Validates that the <see cref="ISlangProfiler" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISlangProfiler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISlangProfiler" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISlangProfiler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISlangProfiler), Is.EqualTo(4));
        }
    }
}
