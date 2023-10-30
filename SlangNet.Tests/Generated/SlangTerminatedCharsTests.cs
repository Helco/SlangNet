using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SlangTerminatedChars" /> struct.</summary>
public static unsafe partial class SlangTerminatedCharsTests
{
    /// <summary>Validates that the <see cref="SlangTerminatedChars" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangTerminatedChars>(), Is.EqualTo(sizeof(SlangTerminatedChars)));
    }

    /// <summary>Validates that the <see cref="SlangTerminatedChars" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SlangTerminatedChars).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangTerminatedChars" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SlangTerminatedChars), Is.EqualTo(1));
    }
}
