using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IResource" /> struct.</summary>
public static unsafe partial class IResourceTests
{
    /// <summary>Validates that the <see cref="IResource" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IResource>(), Is.EqualTo(sizeof(IResource)));
    }

    /// <summary>Validates that the <see cref="IResource" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IResource).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IResource" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IResource), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IResource), Is.EqualTo(4));
        }
    }
}
