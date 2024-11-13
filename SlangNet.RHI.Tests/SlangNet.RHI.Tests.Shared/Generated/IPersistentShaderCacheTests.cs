using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IPersistentShaderCache" /> struct.</summary>
public static unsafe partial class IPersistentShaderCacheTests
{
    /// <summary>Validates that the <see cref="IPersistentShaderCache" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPersistentShaderCache>(), Is.EqualTo(sizeof(IPersistentShaderCache)));
    }

    /// <summary>Validates that the <see cref="IPersistentShaderCache" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPersistentShaderCache).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IPersistentShaderCache" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPersistentShaderCache), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPersistentShaderCache), Is.EqualTo(4));
        }
    }
}
