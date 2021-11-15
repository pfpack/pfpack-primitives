using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

partial class StringExtensionsTests
{
    [Obsolete]
    [Test]
    public void ToStringOrEmpty_Ref_SourceIsNull_ExpectEmpty()
    {
        ToStringStubRefType? source = null;

        var actual = source.ToStringOrEmpty();
        Assert.IsEmpty(actual);
    }

    [Obsolete]
    [Test]
    public void ToStringOrEmpty_Ref_SourceToStringIsNull_ExpectEmpty()
    {
        ToStringStubRefType? source = new(null);

        var actual = source.ToStringOrEmpty();
        Assert.IsEmpty(actual);
    }

    [Obsolete]
    [Test]
    [TestCase(EmptyString)]
    [TestCase(WhiteSpaceString)]
    [TestCase(TabString)]
    [TestCase(SomeString)]
    public void ToStringOrEmpty_Ref_SourceToStringIsNotNull_ExpectActualToStringValue(
        string sourceToStringValue)
    {
        ToStringStubRefType? source = new(sourceToStringValue);

        var actual = source.ToStringOrEmpty();
        Assert.AreEqual(sourceToStringValue, actual);
    }
}
