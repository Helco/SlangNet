using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="NativeHandle" /> struct.</summary>
public static unsafe partial class NativeHandleTests
{
    /// <summary>Validates that the <see cref="NativeHandle" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NativeHandle>(), Is.EqualTo(sizeof(NativeHandle)));
    }

    /// <summary>Validates that the <see cref="NativeHandle" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NativeHandle).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="NativeHandle" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(NativeHandle), Is.EqualTo(16));
    }
}
