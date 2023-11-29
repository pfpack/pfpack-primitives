using NUnit.Framework;
using System;

namespace PrimeFuncPack.Primitives.Tests;

partial class StringsTests
{
    [Test]
    public void Empty_ExpectEmptyString()
    {
        var actual = Strings.Empty;
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void GetEmpty_ExpectEmptyString()
    {
        var actual = Strings.GetEmpty();
        Assert.That(actual, Is.Empty);
    }
}
