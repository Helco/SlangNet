using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SlangReflectionVariableLayout" /> struct.</summary>
public static unsafe partial class SlangReflectionVariableLayoutTests
{
    /// <summary>Validates that the <see cref="SlangReflectionVariableLayout" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangReflectionVariableLayout>(), Is.EqualTo(sizeof(SlangReflectionVariableLayout)));
    }

    /// <summary>Validates that the <see cref="SlangReflectionVariableLayout" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SlangReflectionVariableLayout).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangReflectionVariableLayout" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SlangReflectionVariableLayout), Is.EqualTo(1));
    }
}
