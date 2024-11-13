using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AdapterList" /> struct.</summary>
public static unsafe partial class AdapterListTests
{
    /// <summary>Validates that the <see cref="AdapterList" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AdapterList>(), Is.EqualTo(sizeof(AdapterList)));
    }

    /// <summary>Validates that the <see cref="AdapterList" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AdapterList).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AdapterList" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(AdapterList), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(AdapterList), Is.EqualTo(4));
        }
    }
}
