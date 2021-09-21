#nullable enable

using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;

namespace PrimeFuncPack.Primitives.Tests
{
    public sealed partial class PredicatesTests
    {
        [Test]
        public void IsNull_StringIsNull_ExpectTrue()
        {
            string source = null!;

            var actual = Predicates.IsNull(source);
            Assert.True(actual);
        }

        [Test]
        [TestCase(TestData.EmptyString)]
        [TestCase(TestData.WhiteSpaceString)]
        [TestCase(TestData.TabString)]
        [TestCase(TestData.SomeString)]
        public void IsNull_StringIsNotNull_ExpectFalse(string? source)
        {
            var actual = Predicates.IsNull(source);
            Assert.False(actual);
        }
    }
}
