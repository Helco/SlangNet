using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="Modifier" /> struct.</summary>
public static unsafe partial class ModifierTests
{
    /// <summary>Validates that the <see cref="Modifier" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Modifier>(), Is.EqualTo(sizeof(Modifier)));
    }

    /// <summary>Validates that the <see cref="Modifier" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Modifier).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="Modifier" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Modifier), Is.EqualTo(1));
    }
}
