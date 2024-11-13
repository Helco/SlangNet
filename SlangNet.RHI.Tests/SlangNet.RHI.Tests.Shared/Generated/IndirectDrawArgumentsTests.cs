using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IndirectDrawArguments" /> struct.</summary>
public static unsafe partial class IndirectDrawArgumentsTests
{
    /// <summary>Validates that the <see cref="IndirectDrawArguments" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IndirectDrawArguments>(), Is.EqualTo(sizeof(IndirectDrawArguments)));
    }

    /// <summary>Validates that the <see cref="IndirectDrawArguments" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IndirectDrawArguments).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IndirectDrawArguments" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IndirectDrawArguments), Is.EqualTo(16));
    }
}
