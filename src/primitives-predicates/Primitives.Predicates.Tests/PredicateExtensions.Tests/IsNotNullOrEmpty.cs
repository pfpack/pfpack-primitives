﻿#nullable enable

using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class PredicateExtensionsTests
    {
        [Test]
        public void IsNotNullOrEmpty_SourceIsNull_ExpectFalse()
        {
            string? source = null;

            var actual = source.IsNotNullOrEmpty();
            Assert.False(actual);
        }

        [Test]
        public void IsNotNullOrEmpty_SourceIsEmpty_ExpectFalse()
        {
            string source = string.Empty;

            var actual = source.IsNotNullOrEmpty();
            Assert.False(actual);
        }

        [Test]
        [TestCase(WhiteSpaceString)]
        [TestCase(TabString)]
        [TestCase(SomeString)]
        public void IsNotNullOrEmpty_SourceIsNotEmpty_ExpectTrue(
            string source)
        {
            var actual = source.IsNotNullOrEmpty();
            Assert.True(actual);
        }
    }
}
