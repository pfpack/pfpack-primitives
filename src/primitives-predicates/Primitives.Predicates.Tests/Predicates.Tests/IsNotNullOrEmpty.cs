using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

partial class PredicatesTests
{
    [Test]
    public void IsNotNullOrEmpty_SourceIsNull_ExpectFalse()
    {
        string? source = null;

        var actual = Predicates.IsNotNullOrEmpty(source);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsNotNullOrEmpty_SourceIsEmpty_ExpectFalse()
    {
        string source = string.Empty;

        var actual = Predicates.IsNotNullOrEmpty(source);
        Assert.That(actual, Is.False);
    }

    [Test]
    [TestCase(WhiteSpaceString)]
    [TestCase(TabString)]
    [TestCase(SomeString)]
    public void IsNotNullOrEmpty_SourceIsNotEmpty_ExpectTrue(
        string source)
    {
        var actual = Predicates.IsNotNullOrEmpty(source);
        Assert.That(actual, Is.True);
    }
}
