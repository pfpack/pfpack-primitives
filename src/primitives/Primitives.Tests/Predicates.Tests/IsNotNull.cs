#nullable enable

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
        public void IsNotNull_NullableStructIsNull_ExpectFalse()
        {
            int? source = null;

            // Test both nullable struct and common overloads:
            
            {
                var actual = Predicates.IsNotNull(source);
                Assert.False(actual);
            }

            {
                var actual = Predicates.IsNotNull((object?)source);
                Assert.False(actual);
            }
        }

        [Test]
        public void IsNotNull_NullableStructIsNotNull_ExpectTrue()
        {
            int? source = 0;

            // Test both nullable struct and common overloads:

            {
                var actual = Predicates.IsNotNull(source);
                Assert.True(actual);
            }

            {
                var actual = Predicates.IsNotNull((object?)source);
                Assert.True(actual);
            }
        }

        [Test]
        public void IsNotNull_NonnullableStruct_ExpectTrue()
        {
            int source = 0;

            var actual = Predicates.IsNotNull(source);
            Assert.True(actual);
        }
    }
}
