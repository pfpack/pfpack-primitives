using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

partial class StringsTests
{
    [Test]
    public void ToStringOrEmpty_Ref_SourceIsNull_ExpectEmpty()
    {
        ToStringStubRefType? source = null;

        var actual = Strings.ToStringOrEmpty(source);
        Assert.IsEmpty(actual);
    }

    [Test]
    public void ToStringOrEmpty_Ref_SourceToStringIsNull_ExpectEmpty()
    {
        ToStringStubRefType? source = new(null);

        var actual = Strings.ToStringOrEmpty(source);
        Assert.IsEmpty(actual);
    }

    [Test]
    [TestCase(EmptyString)]
    [TestCase(WhiteSpaceString)]
    [TestCase(TabString)]
    [TestCase(SomeString)]
    public void ToStringOrEmpty_Ref_SourceToStringIsNotNull_ExpectActualToStringValue(
        string sourceToStringValue)
    {
        ToStringStubRefType? source = new(sourceToStringValue);

        var actual = Strings.ToStringOrEmpty(source);
        Assert.AreEqual(sourceToStringValue, actual);
    }
}
