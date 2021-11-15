using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PrimeFuncPack.Primitives.Tests;

partial class StringExtensionsTests
{
    [Test]
    public void ToStringOrEmpty_ExpectIsObsoleteWithError()
    {
        const string expectedObsoleteMessage = "This method is obsolete. Consider to call obj?.ToString().OrEmpty() instead.";

        IReadOnlyCollection<MethodInfo> methods = typeof(StringExtensions)
            .GetMethods(BindingFlags.Public | BindingFlags.Static)
            .Where(method => method.Name == nameof(StringExtensions.ToStringOrEmpty))
            .ToArray();

        Assert.AreEqual(2, methods.Count);

        Assert.IsTrue(
            methods.All(
                method => method.CustomAttributes.Any(
                    attr
                    =>
                    attr.AttributeType == typeof(ObsoleteAttribute) &&
                    attr.ConstructorArguments.Count == 2 &&
                    attr.ConstructorArguments[0].ArgumentType == typeof(string) &&
                    attr.ConstructorArguments[0].Value is expectedObsoleteMessage &&
                    attr.ConstructorArguments[1].ArgumentType == typeof(bool) &&
                    attr.ConstructorArguments[1].Value is true)));
    }
}
