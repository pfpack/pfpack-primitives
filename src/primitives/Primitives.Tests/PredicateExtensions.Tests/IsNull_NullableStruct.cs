#nullable enable

using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class PredicateExtensionsTests
    {
        [Test]
        public void IsNull_NullableStructIsNull_CallStructOverload_ExpectTrue()
        {
            int? source = null;

            var actual = source.IsNull();
            Assert.True(actual);
        }

        [Test]
        public void IsNull_NullableStructIsNull_CallObjectOverload_ExpectTrue()
        {
            int? source = null;

            var actual = source.IsNull<object>();
            Assert.True(actual);
        }

        // Test both zero and non-zero values
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_NullableStructIsNotNull_CallStructOverload_ExpectFalse(int? source)
        {
            var actual = source.IsNull();
            Assert.False(actual);
        }

        // Test both zero and non-zero values
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_NullableStructIsNotNull_CallObjectOverload_ExpectFalse(int? source)
        {
            var actual = source.IsNull<object>();
            Assert.False(actual);
        }
    }
}
