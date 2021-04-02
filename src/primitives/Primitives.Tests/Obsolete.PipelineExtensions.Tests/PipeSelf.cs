#nullable enable

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace PrimeFuncPack.Primitives.Tests
{
    partial class ObsoletePipelineExtensionsTests
    {
        [Obsolete]
        [Test]
        public void PipeSelf_ExpectIsObsolete()
        {
            const string expectedObsoleteMessage
                = "This extension method is obsolete. Call System.PipelineExtensions.Pipe instead.";

            IReadOnlyCollection<MethodInfo> methods =
                typeof(PipelineExtensions) // PrimeFuncPack.PipelineExtensions
                .GetMethods(
                    BindingFlags.Public | BindingFlags.Static)
                .Where(
                    method => method.Name == nameof(PipelineExtensions.PipeSelf)) // PrimeFuncPack.PipelineExtensions.PipeSelf
                .ToArray();

            Assert.AreEqual(1, methods.Count);

            Assert.True(
                methods.All(
                    method => method.CustomAttributes.Any(
                        attr
                        =>
                        attr.AttributeType == typeof(ObsoleteAttribute) &&
                        attr.ConstructorArguments.Count == 2 &&
                        attr.ConstructorArguments[0].Value is expectedObsoleteMessage &&
                        attr.ConstructorArguments[1].Value is true)));

            Assert.True(
                methods.All(
                    method => method.CustomAttributes.Any(
                        attr
                        =>
                        attr.AttributeType == typeof(DoesNotReturnAttribute))));
        }
    }
}
