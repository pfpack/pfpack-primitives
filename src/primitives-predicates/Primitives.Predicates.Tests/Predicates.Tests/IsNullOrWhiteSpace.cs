﻿using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

partial class PredicatesTests
{
    [Test]
    public void IsNullOrWhiteSpace_SourceIsNull_ExpectTrue()
    {
        string? source = null;

        var actual = Predicates.IsNullOrWhiteSpace(source);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsNullOrWhiteSpace_SourceIsEmpty_ExpectTrue()
    {
        string source = string.Empty;

        var actual = Predicates.IsNullOrWhiteSpace(source);
        Assert.That(actual, Is.True);
    }

    [Test]
    [TestCase(WhiteSpaceString)]
    [TestCase(ThreeWhiteSpacesString)]
    [TestCase(TabString)]
    public void IsNullOrWhiteSpace_SourceIsWhiteSpace_ExpectTrue(
        string source)
    {
        var actual = Predicates.IsNullOrWhiteSpace(source);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsNullOrWhiteSpace_SourceIsNotWhiteSpace_ExpectFalse()
    {
        var source = SomeString;

        var actual = Predicates.IsNullOrWhiteSpace(source);
        Assert.That(actual, Is.False);
    }
}
