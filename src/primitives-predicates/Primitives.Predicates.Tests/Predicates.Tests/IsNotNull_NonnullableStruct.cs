using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;

namespace PrimeFuncPack.Primitives.Tests;

public sealed partial class PredicatesTests
{
    // Test both some specific cases
    [Test]
    [TestCase(TestData.MinusOne)]
    [TestCase(TestData.Zero)]
    [TestCase(TestData.One)]
    public void IsNotNull_NonnullableStruct_ExpectTrue(int source)
    {
        var actual = Predicates.IsNotNull(source);
        Assert.That(actual, Is.True);
    }
}
