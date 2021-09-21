#nullable enable

using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class PredicateExtensionsTests
    {
        [Test]
        public void IsNotNull_AnonymousValueIsNotNull_ExpectTrue()
        {
            var source = new
            {
                Text = SomeTextStructType
            };

            var actual = source.IsNotNull();
            Assert.True(actual);
        }
    }
}
