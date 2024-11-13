using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IQueryPool" /> struct.</summary>
public static unsafe partial class IQueryPoolTests
{
    /// <summary>Validates that the <see cref="IQueryPool" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IQueryPool>(), Is.EqualTo(sizeof(IQueryPool)));
    }

    /// <summary>Validates that the <see cref="IQueryPool" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IQueryPool).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IQueryPool" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IQueryPool), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IQueryPool), Is.EqualTo(4));
        }
    }
}
