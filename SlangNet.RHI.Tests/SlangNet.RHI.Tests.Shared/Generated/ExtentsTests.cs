using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="Extents" /> struct.</summary>
public static unsafe partial class ExtentsTests
{
    /// <summary>Validates that the <see cref="Extents" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Extents>(), Is.EqualTo(sizeof(Extents)));
    }

    /// <summary>Validates that the <see cref="Extents" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Extents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="Extents" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Extents), Is.EqualTo(12));
    }
}
