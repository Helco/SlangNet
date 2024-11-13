using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ColorClearValue" /> struct.</summary>
public static unsafe partial class ColorClearValueTests
{
    /// <summary>Validates that the <see cref="ColorClearValue" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ColorClearValue>(), Is.EqualTo(sizeof(ColorClearValue)));
    }

    /// <summary>Validates that the <see cref="ColorClearValue" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(ColorClearValue).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref="ColorClearValue" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ColorClearValue), Is.EqualTo(16));
    }
}
