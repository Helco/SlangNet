using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="EntryPointReflection" /> struct.</summary>
public static unsafe partial class EntryPointReflectionTests
{
    /// <summary>Validates that the <see cref="EntryPointReflection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EntryPointReflection>(), Is.EqualTo(sizeof(EntryPointReflection)));
    }

    /// <summary>Validates that the <see cref="EntryPointReflection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EntryPointReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="EntryPointReflection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EntryPointReflection), Is.EqualTo(1));
    }
}
