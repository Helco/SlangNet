using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="DrawArguments" /> struct.</summary>
public static unsafe partial class DrawArgumentsTests
{
    /// <summary>Validates that the <see cref="DrawArguments" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DrawArguments>(), Is.EqualTo(sizeof(DrawArguments)));
    }

    /// <summary>Validates that the <see cref="DrawArguments" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DrawArguments).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DrawArguments" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DrawArguments), Is.EqualTo(20));
    }
}
