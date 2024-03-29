﻿using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System.Linq;

namespace PrimeFuncPack.Primitives.Tests;

partial class YielderTest
{
    [Test]
    public void YieldEmpty_ExpectEmptyCollection()
    {
        var actual = Yielder.YieldEmpty<StructType?>();
        Assert.That(actual, Is.Empty);
    }
}
