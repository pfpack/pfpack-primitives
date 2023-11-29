using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;

namespace PrimeFuncPack.Primitives.Tests;

public sealed partial class PredicatesTests
{
    [Test]
    public void IsNotNull_NullableStructIsNull_CallStructOverload_ExpectFalse()
    {
        int? source = null;

        var actual = Predicates.IsNotNull(source);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsNotNull_NullableStructIsNull_CallObjectOverload_ExpectFalse()
    {
        int? source = null;

        var actual = Predicates.IsNotNull<object>(source);
        Assert.That(actual, Is.False);
    }

    // Test both some specific cases
    [Test]
    [TestCase(TestData.MinusOne)]
    [TestCase(TestData.Zero)]
    [TestCase(TestData.One)]
    public void IsNotNull_NullableStructIsNotNull_CallStructOverload_ExpectTrue(int? source)
    {
        var actual = Predicates.IsNotNull(source);
        Assert.That(actual, Is.True);
    }

    // Test both some specific cases
    [Test]
    [TestCase(TestData.MinusOne)]
    [TestCase(TestData.Zero)]
    [TestCase(TestData.One)]
    public void IsNotNull_NullableStructIsNotNull_CallObjectOverload_ExpectTrue(int? source)
    {
        var actual = Predicates.IsNotNull<object>(source);
        Assert.That(actual, Is.True);
    }
}
