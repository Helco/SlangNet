using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SlangReflectionVariable" /> struct.</summary>
public static unsafe partial class SlangReflectionVariableTests
{
    /// <summary>Validates that the <see cref="SlangReflectionVariable" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangReflectionVariable>(), Is.EqualTo(sizeof(SlangReflectionVariable)));
    }

    /// <summary>Validates that the <see cref="SlangReflectionVariable" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SlangReflectionVariable).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangReflectionVariable" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SlangReflectionVariable), Is.EqualTo(1));
    }
}
