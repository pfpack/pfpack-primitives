using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

partial class PredicateExtensionsTests
{
    [Test]
    public void IsNull_RefValueIsNull_ExpectTrue()
    {
        object source = null!;

        var actual = source.IsNull();
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsNull_RefValueIsNotNull_ExpectFalse()
    {
        var source = ZeroIdRefType;

        var actual = source.IsNull();
        Assert.That(actual, Is.False);
    }
}
