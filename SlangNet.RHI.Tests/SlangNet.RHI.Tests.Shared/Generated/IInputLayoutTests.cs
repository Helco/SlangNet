using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IInputLayout" /> struct.</summary>
public static unsafe partial class IInputLayoutTests
{
    /// <summary>Validates that the <see cref="IInputLayout" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IInputLayout>(), Is.EqualTo(sizeof(IInputLayout)));
    }

    /// <summary>Validates that the <see cref="IInputLayout" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IInputLayout).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IInputLayout" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IInputLayout), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IInputLayout), Is.EqualTo(4));
        }
    }
}
