using NUnit.Framework;
using System;

namespace PrimeFuncPack.Primitives.Tests;

partial class PredicateExtensionsTests
{
    // Test both zero and non-zero values
    [Test]
    [TestCase(0)]
    [TestCase(1)]
    public void IsNotNull_NonnullableStruct_ExpectTrue(int source)
    {
        var actual = source.IsNotNull();
        Assert.True(actual);
    }
}
