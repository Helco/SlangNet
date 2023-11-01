using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ISlangFileSystemExt" /> struct.</summary>
public static unsafe partial class ISlangFileSystemExtTests
{
    /// <summary>Validates that the <see cref="ISlangFileSystemExt" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISlangFileSystemExt>(), Is.EqualTo(sizeof(ISlangFileSystemExt)));
    }

    /// <summary>Validates that the <see cref="ISlangFileSystemExt" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISlangFileSystemExt).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISlangFileSystemExt" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISlangFileSystemExt), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISlangFileSystemExt), Is.EqualTo(4));
        }
    }
}
