using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ColorTargetState" /> struct.</summary>
public static unsafe partial class ColorTargetStateTests
{
    /// <summary>Validates that the <see cref="ColorTargetState" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ColorTargetState>(), Is.EqualTo(sizeof(ColorTargetState)));
    }

    /// <summary>Validates that the <see cref="ColorTargetState" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ColorTargetState).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ColorTargetState" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ColorTargetState), Is.EqualTo(40));
    }
}
