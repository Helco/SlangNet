using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IndirectDispatchArguments" /> struct.</summary>
public static unsafe partial class IndirectDispatchArgumentsTests
{
    /// <summary>Validates that the <see cref="IndirectDispatchArguments" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IndirectDispatchArguments>(), Is.EqualTo(sizeof(IndirectDispatchArguments)));
    }

    /// <summary>Validates that the <see cref="IndirectDispatchArguments" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IndirectDispatchArguments).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IndirectDispatchArguments" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IndirectDispatchArguments), Is.EqualTo(12));
    }
}
