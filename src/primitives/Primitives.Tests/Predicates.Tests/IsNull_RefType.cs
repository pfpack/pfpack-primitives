#nullable enable

using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class PredicatesTests
    {
        [Test]
        public void IsNull_RefValueIsNull_ExpectTrue()
        {
            RefType source = null!;

            var actual = Predicates.IsNull(source);
            Assert.True(actual);
        }

        [Test]
        public void IsNull_RefValueIsNull_ExpectFalse()
        {
            var source = MinusFifteenIdRefType;

            var actual = Predicates.IsNull(source);
            Assert.False(actual);
        }
    }
}
