using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ScissorRect" /> struct.</summary>
public static unsafe partial class ScissorRectTests
{
    /// <summary>Validates that the <see cref="ScissorRect" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ScissorRect>(), Is.EqualTo(sizeof(ScissorRect)));
    }

    /// <summary>Validates that the <see cref="ScissorRect" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ScissorRect).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ScissorRect" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ScissorRect), Is.EqualTo(16));
    }
}
