using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="Offset3D" /> struct.</summary>
public static unsafe partial class Offset3DTests
{
    /// <summary>Validates that the <see cref="Offset3D" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Offset3D>(), Is.EqualTo(sizeof(Offset3D)));
    }

    /// <summary>Validates that the <see cref="Offset3D" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Offset3D).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="Offset3D" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Offset3D), Is.EqualTo(12));
    }
}
