#nullable enable

using NUnit.Framework;
using System.Linq;

namespace PrimeFuncPack.Primitives.Tests;

partial class YielderTypedTest
{
    [Test]
    [TestCaseSource(typeof(ObjectTestData), nameof(ObjectTestData.NullableObjectTestSource))]
    public void YieldSingle_ExpectCollectionLengthEqualsOne(
        object? sourceValue)
    {
        var actual = Yielder<object?>.YieldSingle(sourceValue);

        var actualLength = actual.Count();
        Assert.AreEqual(1, actualLength);
    }

    [Test]
    [TestCaseSource(typeof(ObjectTestData), nameof(ObjectTestData.NullableObjectTestSource))]
    public void YieldSingle_ExpectFirstItemIsSameAsSourceValue(
        object? sourceValue)
    {
        var actual = Yielder<object?>.YieldSingle(sourceValue);

        var actualFirst = actual.FirstOrDefault();
        Assert.AreSame(sourceValue, actualFirst);
    }
}
