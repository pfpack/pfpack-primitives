#nullable enable

using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class PredicateExtensionsTests
    {
        [Test]
        public void IsNotNull_ValueIsNull_ExpectFalse()
        {
            RefType source = null!;

            var actual = source.IsNotNull();
            Assert.False(actual);
        }

        [Test]
        public void IsNotNull_ValueIsNotNull_ExpectTrue()
        {
            var source = MinusFifteenIdRefType;

            var actual = source.IsNotNull();
            Assert.True(actual);
        }

        [Test]
        public void IsNotNull_NullableStructIsNull_ExpectFalse()
        {
            int? source = null;

            // Test both nullable struct and common overloads:
            
            {
                var actual = source.IsNotNull();
                Assert.False(actual);
            }

            {
                var actual = ((object?)source).IsNotNull();
                Assert.False(actual);
            }
        }

        // Test both zero and non-zero values
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_NullableStructIsNotNull_ExpectTrue(int? source)
        {
            // Test both nullable struct and common overloads:

            {
                var actual = source.IsNotNull();
                Assert.True(actual);
            }

            {
                var actual = ((object?)source).IsNotNull();
                Assert.True(actual);
            }
        }

        // Test both zero and non-zero values
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNotNull_NonnullableStruct_ExpectTrue(int source)
        {
            var actual = source.IsNotNull();
            Assert.True(actual);
        }
    }
}
