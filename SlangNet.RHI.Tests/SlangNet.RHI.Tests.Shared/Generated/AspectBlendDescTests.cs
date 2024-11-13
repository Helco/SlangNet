using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AspectBlendDesc" /> struct.</summary>
public static unsafe partial class AspectBlendDescTests
{
    /// <summary>Validates that the <see cref="AspectBlendDesc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AspectBlendDesc>(), Is.EqualTo(sizeof(AspectBlendDesc)));
    }

    /// <summary>Validates that the <see cref="AspectBlendDesc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AspectBlendDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AspectBlendDesc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AspectBlendDesc), Is.EqualTo(12));
    }
}
