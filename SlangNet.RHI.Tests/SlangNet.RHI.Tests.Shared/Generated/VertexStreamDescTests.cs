using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="VertexStreamDesc" /> struct.</summary>
public static unsafe partial class VertexStreamDescTests
{
    /// <summary>Validates that the <see cref="VertexStreamDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VertexStreamDesc>(), Is.EqualTo(sizeof(VertexStreamDesc)));
    }

    /// <summary>Validates that the <see cref="VertexStreamDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VertexStreamDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VertexStreamDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VertexStreamDesc), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(VertexStreamDesc), Is.EqualTo(12));
        }
    }
}
