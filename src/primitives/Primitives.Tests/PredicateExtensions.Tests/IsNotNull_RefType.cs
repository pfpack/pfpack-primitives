﻿#nullable enable

using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class PredicateExtensionsTests
    {
        [Test]
        public void IsNotNull_RefValueIsNull_ExpectFalse()
        {
            RefType source = null!;

            var actual = source.IsNotNull();
            Assert.False(actual);
        }

        [Test]
        public void IsNotNull_RefValueIsNotNull_ExpectTrue()
        {
            var source = MinusFifteenIdRefType;

            var actual = source.IsNotNull();
            Assert.True(actual);
        }
    }
}
