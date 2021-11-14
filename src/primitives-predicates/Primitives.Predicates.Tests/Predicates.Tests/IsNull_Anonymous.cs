using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

partial class PredicatesTests
{
    [Test]
    public void IsNull_AnonymousValueIsNotNull_ExpectFalse()
    {
        var source = new
        {
            Text = SomeTextStructType
        };

        var actual = Predicates.IsNull(source);
        Assert.False(actual);
    }
}
