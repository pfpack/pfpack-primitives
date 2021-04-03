#nullable enable

using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class ThisTests
    {
        [Test]
        public void This_RefType_ExpectTheSame()
        {
            var source = TestData.PlusFifteenIdRefType;

            var result = source.This();

            Assert.AreSame(source, result);
        }

        [Test]
        public void This_Struct_ExpectEqual()
        {
            var source = TestData.SomeTextStructType;

            var result = source.This();

            Assert.AreEqual(source, result);
        }
    }
}
