using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="WindowHandle" /> struct.</summary>
public static unsafe partial class WindowHandleTests
{
    /// <summary>Validates that the <see cref="WindowHandle" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WindowHandle>(), Is.EqualTo(sizeof(WindowHandle)));
    }

    /// <summary>Validates that the <see cref="WindowHandle" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WindowHandle).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WindowHandle" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WindowHandle), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(WindowHandle), Is.EqualTo(12));
        }
    }
}
