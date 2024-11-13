using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SamplePosition" /> struct.</summary>
public static unsafe partial class SamplePositionTests
{
    /// <summary>Validates that the <see cref="SamplePosition" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SamplePosition>(), Is.EqualTo(sizeof(SamplePosition)));
    }

    /// <summary>Validates that the <see cref="SamplePosition" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SamplePosition).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SamplePosition" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SamplePosition), Is.EqualTo(2));
    }
}
