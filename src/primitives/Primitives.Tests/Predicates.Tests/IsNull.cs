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
        public void IsNull_ValueIsNull_ExpectTrue()
        {
            RefType source = null!;

            var actual = Predicates.IsNull(source);
            Assert.True(actual);
        }

        [Test]
        public void IsNull_ValueIsNotNull_ExpectFalse()
        {
            var source = new
            {
                Text = SomeTextStructType
            };

            var actual = Predicates.IsNull(source);
            Assert.False(actual);
        }

        [Test]
        public void IsNull_NullableStructIsNull_ExpectTrue()
        {
            int? source = null;

            // Test both nullable struct and common overloads:

            {
                var actual = Predicates.IsNull(source);
                Assert.True(actual);
            }

            {
                var actual = Predicates.IsNull((object?)source);
                Assert.True(actual);
            }
        }

        // Test both zero and non-zero values
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_NullableStructIsNotNull_ExpectFalse(int? source)
        {
            // Test both nullable struct and common overloads:

            {
                var actual = Predicates.IsNull(source);
                Assert.False(actual);
            }

            {
                var actual = Predicates.IsNull((object?)source);
                Assert.False(actual);
            }
        }

        // Test both zero and non-zero values
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void IsNull_NonnullableStruct_ExpectFalse(int source)
        {
            var actual = Predicates.IsNull(source);
            Assert.False(actual);
        }
    }
}
