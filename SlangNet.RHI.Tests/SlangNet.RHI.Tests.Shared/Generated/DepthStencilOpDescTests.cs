using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="DepthStencilOpDesc" /> struct.</summary>
public static unsafe partial class DepthStencilOpDescTests
{
    /// <summary>Validates that the <see cref="DepthStencilOpDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DepthStencilOpDesc>(), Is.EqualTo(sizeof(DepthStencilOpDesc)));
    }

    /// <summary>Validates that the <see cref="DepthStencilOpDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DepthStencilOpDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DepthStencilOpDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DepthStencilOpDesc), Is.EqualTo(4));
    }
}
