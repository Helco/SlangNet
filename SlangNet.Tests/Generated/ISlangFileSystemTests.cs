using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="ISlangFileSystem" /> struct.</summary>
public static unsafe partial class ISlangFileSystemTests
{
    /// <summary>Validates that the <see cref="ISlangFileSystem" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISlangFileSystem>(), Is.EqualTo(sizeof(ISlangFileSystem)));
    }

    /// <summary>Validates that the <see cref="ISlangFileSystem" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISlangFileSystem).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISlangFileSystem" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISlangFileSystem), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISlangFileSystem), Is.EqualTo(4));
        }
    }
}
