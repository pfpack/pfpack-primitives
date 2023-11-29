using NUnit.Framework;
using System.Linq;

namespace PrimeFuncPack.Primitives.Tests;

partial class YieldExtensionsTest
{
    [Test]
    [TestCaseSource(typeof(ObjectTestData), nameof(ObjectTestData.NullableObjectTestSource))]
    public void YieldSingle_ExpectCollectionLengthEqualsOne(
        object? sourceValue)
    {
        var actual = sourceValue.YieldSingle();

        var actualLength = actual.Count();
        Assert.That(actualLength, Is.EqualTo(1));
    }

    [Test]
    [TestCaseSource(typeof(ObjectTestData), nameof(ObjectTestData.NullableObjectTestSource))]
    public void YieldSingle_ExpectFirstItemIsSameAsSourceValue(
        object? sourceValue)
    {
        var actual = sourceValue.YieldSingle();

        var actualFirst = actual.FirstOrDefault();
        Assert.That(actualFirst, Is.SameAs(sourceValue));
    }
}
