#nullable enable

using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class PredicateExtensionsTests
    {
        [Test]
        public void IsNull_ValueIsNull_ExpectTrue()
        {
            object source = null!;

            var actual = source.IsNull();
            Assert.True(actual);
        }

        [Test]
        public void IsNull_ValueIsNotNull_ExpectFalse()
        {
            var source = ZeroIdRefType;

            var actual = source.IsNull();
            Assert.False(actual);
        }

        [Test]
        public void IsNull_NullableStructIsNull_ExpectTrue()
        {
            int? source = null;

            // Test both nullable struct and common overloads:

            {
                var actual = source.IsNull();
                Assert.True(actual);
            }

            {
                var actual = ((object?)source).IsNull();
                Assert.True(actual);
            }
        }

        [Test]
        public void IsNull_NullableStructIsNotNull_ExpectFalse()
        {
            int? source = 0;

            // Test both nullable struct and common overloads:

            {
                var actual = source.IsNull();
                Assert.False(actual);
            }

            {
                var actual = ((object?)source).IsNull();
                Assert.False(actual);
            }
        }

        [Test]
        public void IsNull_NonnullableStruct_ExpectFalse()
        {
            int source = 0;

            var actual = source.IsNull();
            Assert.False(actual);
        }
    }
}
