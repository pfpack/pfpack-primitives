using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

public sealed partial class PredicatesTests
{
    [Test]
    public void IsNotNull_RefValueIsNull_ExpectFalse()
    {
        object source = null!;

        var actual = Predicates.IsNotNull(source);
        Assert.False(actual);
    }

    [Test]
    public void IsNotNull_RefValueIsNotNull_ExpectTrue()
    {
        var source = PlusFifteenIdRefType;

        var actual = Predicates.IsNotNull(source);
        Assert.True(actual);
    }
}
