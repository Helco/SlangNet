using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SlangReflectionDecl" /> struct.</summary>
public static unsafe partial class SlangReflectionDeclTests
{
    /// <summary>Validates that the <see cref="SlangReflectionDecl" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangReflectionDecl>(), Is.EqualTo(sizeof(SlangReflectionDecl)));
    }

    /// <summary>Validates that the <see cref="SlangReflectionDecl" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SlangReflectionDecl).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangReflectionDecl" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SlangReflectionDecl), Is.EqualTo(1));
    }
}
