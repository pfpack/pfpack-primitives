using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

partial class StringExtensionsTests
{
    [Test]
    [TestCase(EmptyString)]
    [TestCase(WhiteSpaceString)]
    [TestCase(ThreeWhiteSpacesString)]
    [TestCase(TabString)]
    public void OrNullIfWhiteSpace_SourceIsWhiteSpace_ExpectNull(
        string? source)
    {
        var actual = source.OrNullIfWhiteSpace();
        Assert.That(actual, Is.Null);
    }

    [Test]
    [TestCase(null)]
    [TestCase(SomeString)]
    public void OrNullIfWhiteSpace_SourceIsNotWhiteSpace_ExpectSourceValue(
        string? source)
    {
        var actual = source.OrNullIfWhiteSpace();
        Assert.That(actual, Is.SameAs(source));
    }
}
