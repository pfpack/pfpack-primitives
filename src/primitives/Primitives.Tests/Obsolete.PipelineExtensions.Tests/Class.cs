#nullable enable

using NUnit.Framework;
using System;
using System.Linq;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class ObsoletePipelineExtensionsTests
    {
        [Obsolete]
        [Test]
        public void ClassPipelineExtensions_ExpectIsObsolete()
        {
            const string expectedObsoleteMessage
                = "This class is obsolete. Use System.PipelineExtensions instead.";

            var classType = typeof(PipelineExtensions); // PrimeFuncPack.PipelineExtensions

            Assert.True(
                classType.CustomAttributes.Any(
                    attr
                    =>
                    attr.AttributeType == typeof(ObsoleteAttribute) &&
                    attr.ConstructorArguments.Count == 2 &&
                    attr.ConstructorArguments[0].Value is expectedObsoleteMessage &&
                    attr.ConstructorArguments[1].Value is true));
        }
    }
}
