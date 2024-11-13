using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SubresourceRange" /> struct.</summary>
public static unsafe partial class SubresourceRangeTests
{
    /// <summary>Validates that the <see cref="SubresourceRange" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SubresourceRange>(), Is.EqualTo(sizeof(SubresourceRange)));
    }

    /// <summary>Validates that the <see cref="SubresourceRange" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SubresourceRange).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SubresourceRange" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SubresourceRange), Is.EqualTo(16));
    }
}
