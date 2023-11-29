using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;

namespace PrimeFuncPack.Primitives.Tests;

public sealed partial class PredicatesTests
{
    [Test]
    public void IsNotNull_StringIsNull_ExpectFalse()
    {
        string source = null!;

        var actual = Predicates.IsNotNull(source);
        Assert.That(actual, Is.False);
    }

    [Test]
    [TestCase(TestData.EmptyString)]
    [TestCase(TestData.WhiteSpaceString)]
    [TestCase(TestData.TabString)]
    [TestCase(TestData.SomeString)]
    public void IsNotNull_StringIsNotNull_ExpectTrue(string? source)
    {
        var actual = Predicates.IsNotNull(source);
        Assert.That(actual, Is.True);
    }
}
