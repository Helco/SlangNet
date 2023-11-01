using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ISlangSharedLibrary_Dep1" /> struct.</summary>
public static unsafe partial class ISlangSharedLibrary_Dep1Tests
{
    /// <summary>Validates that the <see cref="ISlangSharedLibrary_Dep1" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISlangSharedLibrary_Dep1>(), Is.EqualTo(sizeof(ISlangSharedLibrary_Dep1)));
    }

    /// <summary>Validates that the <see cref="ISlangSharedLibrary_Dep1" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISlangSharedLibrary_Dep1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISlangSharedLibrary_Dep1" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISlangSharedLibrary_Dep1), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISlangSharedLibrary_Dep1), Is.EqualTo(4));
        }
    }
}
