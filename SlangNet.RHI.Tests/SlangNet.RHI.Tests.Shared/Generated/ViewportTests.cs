using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="Viewport" /> struct.</summary>
public static unsafe partial class ViewportTests
{
    /// <summary>Validates that the <see cref="Viewport" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Viewport>(), Is.EqualTo(sizeof(Viewport)));
    }

    /// <summary>Validates that the <see cref="Viewport" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Viewport).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="Viewport" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Viewport), Is.EqualTo(24));
    }
}
