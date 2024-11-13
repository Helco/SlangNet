using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IDebugCallback" /> struct.</summary>
public static unsafe partial class IDebugCallbackTests
{
    /// <summary>Validates that the <see cref="IDebugCallback" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDebugCallback>(), Is.EqualTo(sizeof(IDebugCallback)));
    }

    /// <summary>Validates that the <see cref="IDebugCallback" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDebugCallback).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDebugCallback" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDebugCallback), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDebugCallback), Is.EqualTo(4));
        }
    }
}
