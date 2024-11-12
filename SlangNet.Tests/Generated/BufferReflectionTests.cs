using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="BufferReflection" /> struct.</summary>
public static unsafe partial class BufferReflectionTests
{
    /// <summary>Validates that the <see cref="BufferReflection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BufferReflection>(), Is.EqualTo(sizeof(BufferReflection)));
    }

    /// <summary>Validates that the <see cref="BufferReflection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BufferReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="BufferReflection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BufferReflection), Is.EqualTo(1));
    }
}
