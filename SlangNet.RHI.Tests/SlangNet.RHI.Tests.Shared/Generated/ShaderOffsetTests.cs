using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ShaderOffset" /> struct.</summary>
public static unsafe partial class ShaderOffsetTests
{
    /// <summary>Validates that the <see cref="ShaderOffset" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ShaderOffset>(), Is.EqualTo(sizeof(ShaderOffset)));
    }

    /// <summary>Validates that the <see cref="ShaderOffset" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ShaderOffset).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ShaderOffset" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ShaderOffset), Is.EqualTo(16));
    }
}
