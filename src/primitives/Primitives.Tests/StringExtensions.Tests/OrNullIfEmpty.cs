#nullable enable

using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class StringExtensionsTests
    {
        [Test]
        public void OrNullIfEmpty_SourceIsEmpty_ExpectNull()
        {
            string? source = string.Empty;

            var actual = source.OrNullIfEmpty();
            Assert.IsNull(actual);
        }

        [Test]
        [TestCase(null)]
        [TestCase(WhiteSpaceString)]
        [TestCase(TabString)]
        [TestCase(SomeString)]
        public void OrNullIfEmpty_SourceIsNotEmpty_ExpectSourceValue(
            string? source)
        {
            var actual = source.OrNullIfEmpty();
            Assert.AreSame(source, actual);
        }
    }
}
