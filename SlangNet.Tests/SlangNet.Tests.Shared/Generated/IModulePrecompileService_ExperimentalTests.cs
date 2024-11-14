using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="IModulePrecompileService_Experimental" /> struct.</summary>
public static unsafe partial class IModulePrecompileService_ExperimentalTests
{
    /// <summary>Validates that the <see cref="IModulePrecompileService_Experimental" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IModulePrecompileService_Experimental>(), Is.EqualTo(sizeof(IModulePrecompileService_Experimental)));
    }

    /// <summary>Validates that the <see cref="IModulePrecompileService_Experimental" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IModulePrecompileService_Experimental).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IModulePrecompileService_Experimental" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IModulePrecompileService_Experimental), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IModulePrecompileService_Experimental), Is.EqualTo(4));
        }
    }
}
