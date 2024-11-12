using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IEntryPoint" /> struct.</summary>
public static unsafe partial class IEntryPointTests
{
    /// <summary>Validates that the <see cref="IEntryPoint" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IEntryPoint>(), Is.EqualTo(sizeof(IEntryPoint)));
    }

    /// <summary>Validates that the <see cref="IEntryPoint" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IEntryPoint).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IEntryPoint" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IEntryPoint), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IEntryPoint), Is.EqualTo(4));
        }
    }
}
