using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

partial class PredicateExtensionsTests
{
    [Test]
    public void IsNotNullOrWhiteSpace_SourceIsNull_ExpectFalse()
    {
        string? source = null;

        var actual = source.IsNotNullOrWhiteSpace();
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsNotNullOrWhiteSpace_SourceIsEmpty_ExpectFalse()
    {
        string source = string.Empty;

        var actual = source.IsNotNullOrWhiteSpace();
        Assert.That(actual, Is.False);
    }

    [Test]
    [TestCase(WhiteSpaceString)]
    [TestCase(ThreeWhiteSpacesString)]
    [TestCase(TabString)]
    public void IsNotNullOrWhiteSpace_SourceIsWhiteSpace_ExpectFalse(
        string source)
    {
        var actual = source.IsNotNullOrWhiteSpace();
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsNotNullOrWhiteSpace_SourceIsNotWhiteSpace_ExpectTrue()
    {
        var source = SomeString;

        var actual = source.IsNotNullOrWhiteSpace();
        Assert.That(actual, Is.True);
    }
}
