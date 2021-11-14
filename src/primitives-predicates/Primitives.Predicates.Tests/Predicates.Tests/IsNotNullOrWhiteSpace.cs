using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

partial class PredicatesTests
{
    [Test]
    public void IsNotNullOrWhiteSpace_SourceIsNull_ExpectFalse()
    {
        string? source = null;

        var actual = Predicates.IsNotNullOrWhiteSpace(source);
        Assert.False(actual);
    }

    [Test]
    public void IsNotNullOrWhiteSpace_SourceIsEmpty_ExpectFalse()
    {
        string source = string.Empty;

        var actual = Predicates.IsNotNullOrWhiteSpace(source);
        Assert.False(actual);
    }

    [Test]
    [TestCase(WhiteSpaceString)]
    [TestCase(ThreeWhiteSpacesString)]
    [TestCase(TabString)]
    public void IsNotNullOrWhiteSpace_SourceIsWhiteSpace_ExpectFalse(
        string source)
    {
        var actual = Predicates.IsNotNullOrWhiteSpace(source);
        Assert.False(actual);
    }

    [Test]
    public void IsNotNullOrWhiteSpace_SourceIsNotWhiteSpace_ExpectTrue()
    {
        var source = SomeString;

        var actual = Predicates.IsNotNullOrWhiteSpace(source);
        Assert.True(actual);
    }
}
