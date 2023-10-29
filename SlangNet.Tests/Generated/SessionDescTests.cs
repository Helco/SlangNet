using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="SessionDesc" /> struct.</summary>
public static unsafe partial class SessionDescTests
{
    /// <summary>Validates that the <see cref="SessionDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SessionDesc>(), Is.EqualTo(sizeof(SessionDesc)));
    }

    /// <summary>Validates that the <see cref="SessionDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SessionDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SessionDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SessionDesc), Is.EqualTo(80));
        }
        else
        {
            Assert.That(sizeof(SessionDesc), Is.EqualTo(64));
        }
    }
}
