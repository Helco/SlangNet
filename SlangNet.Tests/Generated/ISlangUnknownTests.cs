using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ISlangUnknown" /> struct.</summary>
public static unsafe partial class ISlangUnknownTests
{
    /// <summary>Validates that the <see cref="ISlangUnknown" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISlangUnknown>(), Is.EqualTo(sizeof(ISlangUnknown)));
    }

    /// <summary>Validates that the <see cref="ISlangUnknown" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISlangUnknown).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISlangUnknown" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISlangUnknown), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISlangUnknown), Is.EqualTo(4));
        }
    }
}
