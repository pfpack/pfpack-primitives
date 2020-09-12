﻿#nullable enable

using NUnit.Framework;
using System;

namespace PrimeFuncPack.Core.Objects.Tests
{
    partial class StringPredicatesTests
    {
        [Test]
        public void IsNullOrWhiteSpace_SourceIsNull_ExpectTrue()
        {
            string? source = null;

            var actual = StringPredicates.IsNullOrWhiteSpace(source);
            Assert.True(actual);
        }

        [Test]
        public void IsNullOrWhiteSpace_SourceIsEmpty_ExpectTrue()
        {
            string source = string.Empty;

            var actual = StringPredicates.IsNullOrWhiteSpace(source);
            Assert.True(actual);
        }

        [Test]
        [TestCase(" ")]
        [TestCase("   ")]
        [TestCase("\t")]
        public void IsNullOrWhiteSpace_SourceIsWhiteSpace_ExpectTrue(
            in string source)
        {
            var actual = StringPredicates.IsNullOrWhiteSpace(source);
            Assert.True(actual);
        }

        [Test]
        [TestCase(" t")]
        [TestCase("some")]
        public void IsNullOrWhiteSpace_SourceIsNotWhiteSpace_ExpectFalse(
            in string source)
        {
            var actual = StringPredicates.IsNullOrWhiteSpace(source);
            Assert.False(actual);
        }
    }
}