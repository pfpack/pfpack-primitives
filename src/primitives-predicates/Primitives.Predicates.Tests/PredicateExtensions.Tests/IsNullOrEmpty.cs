using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

partial class PredicateExtensionsTests
{
    [Test]
    public void IsNullOrEmpty_SourceIsNull_ExpectTrue()
    {
        string? source = null;

        var actual = source.IsNullOrEmpty();
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsNullOrEmpty_SourceIsEmpty_ExpectTrue()
    {
        string source = string.Empty;

        var actual = source.IsNullOrEmpty();
        Assert.That(actual, Is.True);
    }

    [Test]
    [TestCase(WhiteSpaceString)]
    [TestCase(TabString)]
    [TestCase(SomeString)]
    public void IsNullOrEmpty_SourceIsNotEmpty_ExpectFalse(
        string source)
    {
        var actual = source.IsNullOrEmpty();
        Assert.That(actual, Is.False);
    }
}
