using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="RasterizerDesc" /> struct.</summary>
public static unsafe partial class RasterizerDescTests
{
    /// <summary>Validates that the <see cref="RasterizerDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RasterizerDesc>(), Is.EqualTo(sizeof(RasterizerDesc)));
    }

    /// <summary>Validates that the <see cref="RasterizerDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RasterizerDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="RasterizerDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RasterizerDesc), Is.EqualTo(28));
    }
}
