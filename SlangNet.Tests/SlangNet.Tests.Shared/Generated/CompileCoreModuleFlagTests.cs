using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="CompileCoreModuleFlag" /> struct.</summary>
public static unsafe partial class CompileCoreModuleFlagTests
{
    /// <summary>Validates that the <see cref="CompileCoreModuleFlag" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CompileCoreModuleFlag>(), Is.EqualTo(sizeof(CompileCoreModuleFlag)));
    }

    /// <summary>Validates that the <see cref="CompileCoreModuleFlag" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CompileCoreModuleFlag).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CompileCoreModuleFlag" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CompileCoreModuleFlag), Is.EqualTo(1));
    }
}
