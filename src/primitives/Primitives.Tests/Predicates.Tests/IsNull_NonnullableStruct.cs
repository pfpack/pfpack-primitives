#nullable enable

using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class PredicatesTests
    {
        // Test both some specific cases
        [Test]
        [TestCase(TestData.MinusOne)]
        [TestCase(TestData.Zero)]
        [TestCase(TestData.One)]
        public void IsNull_NonnullableStruct_ExpectFalse(int source)
        {
            var actual = Predicates.IsNull(source);
            Assert.False(actual);
        }
    }
}
