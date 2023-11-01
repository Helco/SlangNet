using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IModule" /> struct.</summary>
public static unsafe partial class IModuleTests
{
    /// <summary>Validates that the <see cref="IModule" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IModule>(), Is.EqualTo(sizeof(IModule)));
    }

    /// <summary>Validates that the <see cref="IModule" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IModule).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IModule" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IModule), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IModule), Is.EqualTo(4));
        }
    }
}
