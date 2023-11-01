using System;
using NUnit.Framework;
using SlangNet.Unsafe;

namespace SlangNet.Tests;

internal unsafe class SmokeTests
{
    [Test]
    public void CanCreateGlobalSession()
    {
        IGlobalSession* globalSession = null;
        var result = Slang.slang_createGlobalSession(Slang.SLANG_API_VERSION, &globalSession);
        Assert.That(result, Is.EqualTo(Slang.SLANG_OK));
        Assert.True(globalSession != null, "createGlobalSession returned a null pointer");
        globalSession->release();
    }
}
