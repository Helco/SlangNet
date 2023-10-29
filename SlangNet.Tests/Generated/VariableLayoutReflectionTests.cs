using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="VariableLayoutReflection" /> struct.</summary>
public static unsafe partial class VariableLayoutReflectionTests
{
    /// <summary>Validates that the <see cref="VariableLayoutReflection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VariableLayoutReflection>(), Is.EqualTo(sizeof(VariableLayoutReflection)));
    }

    /// <summary>Validates that the <see cref="VariableLayoutReflection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VariableLayoutReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VariableLayoutReflection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(VariableLayoutReflection), Is.EqualTo(1));
    }
}
