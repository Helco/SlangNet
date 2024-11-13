using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="AdapterLUID" /> struct.</summary>
public static unsafe partial class AdapterLUIDTests
{
    /// <summary>Validates that the <see cref="AdapterLUID" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AdapterLUID>(), Is.EqualTo(sizeof(AdapterLUID)));
    }

    /// <summary>Validates that the <see cref="AdapterLUID" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AdapterLUID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AdapterLUID" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AdapterLUID), Is.EqualTo(16));
    }
}
