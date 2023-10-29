using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.UnitTests;

/// <summary>Provides validation of the <see cref="CompileStdLibFlag" /> struct.</summary>
public static unsafe partial class CompileStdLibFlagTests
{
    /// <summary>Validates that the <see cref="CompileStdLibFlag" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CompileStdLibFlag>(), Is.EqualTo(sizeof(CompileStdLibFlag)));
    }

    /// <summary>Validates that the <see cref="CompileStdLibFlag" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CompileStdLibFlag).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CompileStdLibFlag" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CompileStdLibFlag), Is.EqualTo(1));
    }
}
