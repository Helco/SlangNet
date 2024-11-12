using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="SlangEntryPointLayout" /> struct.</summary>
public static unsafe partial class SlangEntryPointLayoutTests
{
    /// <summary>Validates that the <see cref="SlangEntryPointLayout" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SlangEntryPointLayout>(), Is.EqualTo(sizeof(SlangEntryPointLayout)));
    }

    /// <summary>Validates that the <see cref="SlangEntryPointLayout" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SlangEntryPointLayout).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SlangEntryPointLayout" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SlangEntryPointLayout), Is.EqualTo(1));
    }
}
