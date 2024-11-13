using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IndirectDrawIndexedArguments" /> struct.</summary>
public static unsafe partial class IndirectDrawIndexedArgumentsTests
{
    /// <summary>Validates that the <see cref="IndirectDrawIndexedArguments" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IndirectDrawIndexedArguments>(), Is.EqualTo(sizeof(IndirectDrawIndexedArguments)));
    }

    /// <summary>Validates that the <see cref="IndirectDrawIndexedArguments" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IndirectDrawIndexedArguments).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IndirectDrawIndexedArguments" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IndirectDrawIndexedArguments), Is.EqualTo(20));
    }
}
