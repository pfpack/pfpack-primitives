#nullable enable

using NUnit.Framework;
using System;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class PredicatesTests
    {
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
