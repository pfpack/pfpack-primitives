#nullable enable

using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class PipelineExtensionsTests
    {
        [Test]
        [TestCaseSource(nameof(ValueTestSource))]
        public void Pipe_ExpectMappedSourceValue(
            object? sourceValue)
        {
            var actual = sourceValue.Pipe(value => (value, PlusFifteen));
            var expected = (sourceValue, PlusFifteen);
            Assert.AreSame(expected.sourceValue, sourceValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
