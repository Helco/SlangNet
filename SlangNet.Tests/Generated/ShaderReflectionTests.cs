using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="ShaderReflection" /> struct.</summary>
public static unsafe partial class ShaderReflectionTests
{
    /// <summary>Validates that the <see cref="ShaderReflection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ShaderReflection>(), Is.EqualTo(sizeof(ShaderReflection)));
    }

    /// <summary>Validates that the <see cref="ShaderReflection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ShaderReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ShaderReflection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ShaderReflection), Is.EqualTo(1));
    }
}
