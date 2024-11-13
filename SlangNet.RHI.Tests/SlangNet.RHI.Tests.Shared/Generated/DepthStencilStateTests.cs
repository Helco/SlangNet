using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="DepthStencilState" /> struct.</summary>
public static unsafe partial class DepthStencilStateTests
{
    /// <summary>Validates that the <see cref="DepthStencilState" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DepthStencilState>(), Is.EqualTo(sizeof(DepthStencilState)));
    }

    /// <summary>Validates that the <see cref="DepthStencilState" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DepthStencilState).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DepthStencilState" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DepthStencilState), Is.EqualTo(28));
    }
}
