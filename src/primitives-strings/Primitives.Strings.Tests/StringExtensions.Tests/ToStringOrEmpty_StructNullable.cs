using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

partial class StringExtensionsTests
{
    [Obsolete]
    [Test]
    public void ToStringOrEmpty_StructNullable_SourceIsNull_ExpectEmpty()
    {
        ToStringStubStructType? source = null;

        var actual = source.ToStringOrEmpty();
        Assert.That(actual, Is.Empty);
    }

    [Obsolete]
    [Test]
    public void ToStringOrEmpty_StructNullable_SourceToStringIsNull_ExpectEmpty()
    {
        ToStringStubStructType? source = new(null);

        var actual = source.ToStringOrEmpty();
        Assert.That(actual, Is.Empty);
    }

    [Obsolete]
    [Test]
    [TestCase(EmptyString)]
    [TestCase(WhiteSpaceString)]
    [TestCase(TabString)]
    [TestCase(SomeString)]
    public void ToStringOrEmpty_StructNullable_SourceToStringIsNotNull_ExpectActualToStringValue(
        string sourceToStringValue)
    {
        ToStringStubStructType? source = new(sourceToStringValue);

        var actual = source.ToStringOrEmpty();
        Assert.That(actual, Is.EqualTo(sourceToStringValue));
    }
}
