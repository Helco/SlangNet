using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="Binding" /> struct.</summary>
public static unsafe partial class BindingTests
{
    /// <summary>Validates that the <see cref="Binding" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Binding>(), Is.EqualTo(sizeof(Binding)));
    }

    /// <summary>Validates that the <see cref="Binding" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Binding).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="Binding" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(Binding), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(Binding), Is.EqualTo(20));
        }
    }
}
