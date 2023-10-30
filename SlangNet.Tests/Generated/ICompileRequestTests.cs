using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ICompileRequest" /> struct.</summary>
public static unsafe partial class ICompileRequestTests
{
    /// <summary>Validates that the <see cref="ICompileRequest" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICompileRequest>(), Is.EqualTo(sizeof(ICompileRequest)));
    }

    /// <summary>Validates that the <see cref="ICompileRequest" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICompileRequest).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ICompileRequest" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICompileRequest), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICompileRequest), Is.EqualTo(4));
        }
    }
}
