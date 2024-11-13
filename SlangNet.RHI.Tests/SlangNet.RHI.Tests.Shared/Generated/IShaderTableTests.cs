using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IShaderTable" /> struct.</summary>
public static unsafe partial class IShaderTableTests
{
    /// <summary>Validates that the <see cref="IShaderTable" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IShaderTable>(), Is.EqualTo(sizeof(IShaderTable)));
    }

    /// <summary>Validates that the <see cref="IShaderTable" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IShaderTable).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IShaderTable" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IShaderTable), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IShaderTable), Is.EqualTo(4));
        }
    }
}
