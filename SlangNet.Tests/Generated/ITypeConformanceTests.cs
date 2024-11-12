using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ITypeConformance" /> struct.</summary>
public static unsafe partial class ITypeConformanceTests
{
    /// <summary>Validates that the <see cref="ITypeConformance" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITypeConformance>(), Is.EqualTo(sizeof(ITypeConformance)));
    }

    /// <summary>Validates that the <see cref="ITypeConformance" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITypeConformance).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ITypeConformance" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITypeConformance), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITypeConformance), Is.EqualTo(4));
        }
    }
}
