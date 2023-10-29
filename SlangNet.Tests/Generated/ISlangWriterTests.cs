using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="ISlangWriter" /> struct.</summary>
public static unsafe partial class ISlangWriterTests
{
    /// <summary>Validates that the <see cref="ISlangWriter" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISlangWriter>(), Is.EqualTo(sizeof(ISlangWriter)));
    }

    /// <summary>Validates that the <see cref="ISlangWriter" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISlangWriter).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISlangWriter" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISlangWriter), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISlangWriter), Is.EqualTo(4));
        }
    }
}
