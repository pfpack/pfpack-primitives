#nullable enable

using NUnit.Framework;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class PipelineExtensions
    {
        [Test]
        [TestCaseSource(nameof(ValueTestSource))]
        public void PipeSelf_ExpectMappedSourceValue(
            object? sourceValue)
        {
            var actual = sourceValue.PipeSelf(value => (value, PlusFifteen));
            var expected = (sourceValue, PlusFifteen);
            Assert.AreSame(expected.sourceValue, sourceValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
