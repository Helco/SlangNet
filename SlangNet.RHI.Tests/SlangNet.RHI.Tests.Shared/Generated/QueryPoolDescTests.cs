using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="QueryPoolDesc" /> struct.</summary>
public static unsafe partial class QueryPoolDescTests
{
    /// <summary>Validates that the <see cref="QueryPoolDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<QueryPoolDesc>(), Is.EqualTo(sizeof(QueryPoolDesc)));
    }

    /// <summary>Validates that the <see cref="QueryPoolDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(QueryPoolDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="QueryPoolDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(QueryPoolDesc), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(QueryPoolDesc), Is.EqualTo(12));
        }
    }
}
