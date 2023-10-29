using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="ISlangSharedLibraryLoader" /> struct.</summary>
public static unsafe partial class ISlangSharedLibraryLoaderTests
{
    /// <summary>Validates that the <see cref="ISlangSharedLibraryLoader" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISlangSharedLibraryLoader>(), Is.EqualTo(sizeof(ISlangSharedLibraryLoader)));
    }

    /// <summary>Validates that the <see cref="ISlangSharedLibraryLoader" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISlangSharedLibraryLoader).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISlangSharedLibraryLoader" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISlangSharedLibraryLoader), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISlangSharedLibraryLoader), Is.EqualTo(4));
        }
    }
}
