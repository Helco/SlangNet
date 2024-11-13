using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="ClearValue" /> struct.</summary>
public static unsafe partial class ClearValueTests
{
    /// <summary>Validates that the <see cref="ClearValue" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ClearValue>(), Is.EqualTo(sizeof(ClearValue)));
    }

    /// <summary>Validates that the <see cref="ClearValue" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ClearValue).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ClearValue" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ClearValue), Is.EqualTo(24));
    }
}
