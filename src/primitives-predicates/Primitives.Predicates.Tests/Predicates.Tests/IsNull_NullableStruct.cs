using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;

namespace PrimeFuncPack.Primitives.Tests;

partial class PredicatesTests
{
    [Test]
    public void IsNull_NullableStructIsNull_CallStructOverload_ExpectTrue()
    {
        int? source = null;

        var actual = Predicates.IsNull(source);
        Assert.True(actual);
    }

    [Test]
    public void IsNull_NullableStructIsNull_CallObjectOverload_ExpectTrue()
    {
        int? source = null;

        var actual = Predicates.IsNull<object>(source);
        Assert.True(actual);
    }

    // Test both some specific cases
    [Test]
    [TestCase(TestData.MinusOne)]
    [TestCase(TestData.Zero)]
    [TestCase(TestData.One)]
    public void IsNull_NullableStructIsNotNull_CallStructOverload_ExpectFalse(int? source)
    {
        var actual = Predicates.IsNull(source);
        Assert.False(actual);
    }

    // Test both some specific cases
    [Test]
    [TestCase(TestData.MinusOne)]
    [TestCase(TestData.Zero)]
    [TestCase(TestData.One)]
    public void IsNull_NullableStructIsNotNull_CallObjectOverload_ExpectFalse(int? source)
    {
        var actual = Predicates.IsNull<object>(source);
        Assert.False(actual);
    }
}
