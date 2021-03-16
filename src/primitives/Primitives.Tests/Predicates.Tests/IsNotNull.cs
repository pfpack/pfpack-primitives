﻿#nullable enable

using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests
{
    public sealed partial class PredicatesTests
    {
        [Test]
        public void IsNotNull_ValueIsNull_ExpectFalse()
        {
            object source = null!;

            var actual = Predicates.IsNotNull(source);
            Assert.False(actual);
        }

        [Test]
        public void IsNotNull_ValueIsNotNull_ExpectTrue()
        {
            var source = PlusFifteenIdRefType;

            var actual = Predicates.IsNotNull(source);
            Assert.True(actual);
        }

        [Test]
        public void IsNotNull_NullableStructIsNull_CallStructOverload_ExpectFalse()
        {
            int? source = null;

            var actual = Predicates.IsNotNull(source);
            Assert.False(actual);
        }

        [Test]
        public void IsNotNull_NullableStructIsNull_CallObjectOverload_ExpectFalse()
        {
            int? source = null;

            var actual = Predicates.IsNotNull<object>(source);
            Assert.False(actual);
        }

        // Test both zero and non-zero values
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_NullableStructIsNotNull_CallStructOverload_ExpectTrue(int? source)
        {
            var actual = Predicates.IsNotNull(source);
            Assert.True(actual);
        }

        // Test both zero and non-zero values
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_NullableStructIsNotNull_CallObjectOverload_ExpectTrue(int? source)
        {
            var actual = Predicates.IsNotNull<object>(source);
            Assert.True(actual);
        }

        // Test both zero and non-zero values
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_NonnullableStruct_ExpectTrue(int source)
        {
            var actual = Predicates.IsNotNull(source);
            Assert.True(actual);
        }
    }
}
