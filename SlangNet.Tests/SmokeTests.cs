using System;
using NUnit.Framework;

namespace SlangNet.Tests;

internal unsafe class SmokeTests
{
    [Test]
    public void CanCreateGlobalSession()
    {
        IGlobalSession* globalSession = null;
        var result = Slang.slang_createGlobalSession(0, &globalSession);
        Assert.Zero(result);
        Assert.True(globalSession != null, "createGlobalSession returned a null pointer");
        globalSession->release();
    }
}
