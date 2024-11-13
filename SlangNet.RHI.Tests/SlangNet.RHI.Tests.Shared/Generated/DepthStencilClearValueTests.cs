using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="DepthStencilClearValue" /> struct.</summary>
public static unsafe partial class DepthStencilClearValueTests
{
    /// <summary>Validates that the <see cref="DepthStencilClearValue" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DepthStencilClearValue>(), Is.EqualTo(sizeof(DepthStencilClearValue)));
    }

    /// <summary>Validates that the <see cref="DepthStencilClearValue" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DepthStencilClearValue).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DepthStencilClearValue" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DepthStencilClearValue), Is.EqualTo(8));
    }
}
