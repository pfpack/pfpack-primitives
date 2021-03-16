#nullable enable

using NUnit.Framework;
using System;

namespace PrimeFuncPack.Primitives.Tests
{
    public sealed partial class PredicatesTests
    {
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
