using NUnit.Framework;
using System.Runtime.InteropServices;

namespace SlangNet.Unsafe.UnitTests;

/// <summary>Provides validation of the <see cref="UserAttribute" /> struct.</summary>
public static unsafe partial class UserAttributeTests
{
    /// <summary>Validates that the <see cref="UserAttribute" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<UserAttribute>(), Is.EqualTo(sizeof(UserAttribute)));
    }

    /// <summary>Validates that the <see cref="UserAttribute" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(UserAttribute).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="UserAttribute" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(UserAttribute), Is.EqualTo(1));
    }
}
