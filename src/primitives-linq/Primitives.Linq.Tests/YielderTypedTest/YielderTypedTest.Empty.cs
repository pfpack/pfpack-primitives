using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System.Linq;

namespace PrimeFuncPack.Primitives.Tests;

partial class YielderTypedTest
{
    [Test]
    public void YieldEmpty_ExpectEmptyCollection()
    {
        var actual = Yielder<StructType?>.YieldEmpty();
        Assert.IsEmpty(actual);
    }
}
