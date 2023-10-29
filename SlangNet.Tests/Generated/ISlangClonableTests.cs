using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="ISlangClonable" /> struct.</summary>
public static unsafe partial class ISlangClonableTests
{
    /// <summary>Validates that the <see cref="ISlangClonable" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISlangClonable>(), Is.EqualTo(sizeof(ISlangClonable)));
    }

    /// <summary>Validates that the <see cref="ISlangClonable" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISlangClonable).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISlangClonable" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISlangClonable), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISlangClonable), Is.EqualTo(4));
        }
    }
}
