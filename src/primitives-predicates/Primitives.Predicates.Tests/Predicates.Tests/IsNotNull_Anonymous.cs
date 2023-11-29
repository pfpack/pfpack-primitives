using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests;

public sealed partial class PredicatesTests
{
    [Test]
    public void IsNotNull_AnonymousValueIsNotNull_ExpectTrue()
    {
        var source = new
        {
            Text = SomeTextStructType
        };

        var actual = Predicates.IsNotNull(source);
        Assert.That(actual, Is.True);
    }
}
