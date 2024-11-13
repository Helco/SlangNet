using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="MultisampleState" /> struct.</summary>
public static unsafe partial class MultisampleStateTests
{
    /// <summary>Validates that the <see cref="MultisampleState" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MultisampleState>(), Is.EqualTo(sizeof(MultisampleState)));
    }

    /// <summary>Validates that the <see cref="MultisampleState" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MultisampleState).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MultisampleState" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MultisampleState), Is.EqualTo(12));
    }
}
