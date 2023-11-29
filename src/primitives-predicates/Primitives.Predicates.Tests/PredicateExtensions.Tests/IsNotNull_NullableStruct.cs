using NUnit.Framework;
using System;

namespace PrimeFuncPack.Primitives.Tests;

partial class PredicateExtensionsTests
{
    [Test]
    public void IsNotNull_NullableStructIsNull_CallStructOverload_ExpectFalse()
    {
        int? source = null;

        var actual = source.IsNotNull();
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsNotNull_NullableStructIsNull_CallObjectOverload_ExpectFalse()
    {
        int? source = null;

        var actual = source.IsNotNull<object>();
        Assert.That(actual, Is.False);
    }

    // Test both zero and non-zero values
    [Test]
    [TestCase(0)]
    [TestCase(1)]
    public void IsNotNull_NullableStructIsNotNull_CallStructOverload_ExpectTrue(int? source)
    {
        var actual = source.IsNotNull();
        Assert.That(actual, Is.True);
    }

    // Test both zero and non-zero values
    [Test]
    [TestCase(0)]
    [TestCase(1)]
    public void IsNotNull_NullableStructIsNotNull_CallObjectOverload_ExpectTrue(int? source)
    {
        var actual = source.IsNotNull<object>();
        Assert.That(actual, Is.True);
    }
}
