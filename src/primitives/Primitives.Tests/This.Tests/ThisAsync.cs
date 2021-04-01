#nullable enable

using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using System.Threading.Tasks;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class ThisTests
    {
        [Test]
        public async Task ThisAsync_RefType_ExpectTheSame()
        {
            var source = TestData.PlusFifteenIdRefType;

            var result = await source.ThisAsync();

            Assert.AreSame(source, result);
        }

        [Test]
        public async Task ThisAsync_Struct_ExpectEqual()
        {
            var source = TestData.SomeTextStructType;

            var result = await source.ThisAsync();

            Assert.AreEqual(source, result);
        }
    }
}
