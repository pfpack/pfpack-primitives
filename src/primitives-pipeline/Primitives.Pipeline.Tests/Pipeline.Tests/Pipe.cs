using NUnit.Framework;
using System;

namespace PrimeFuncPack.Primitives.Tests;

partial class PipelineTests
{
    [Test]
    [TestCaseSource(nameof(ValueTestSource))]
    public void Pipe_ExpectSourceValue(
        object? sourceValue)
    {
        var actual = Pipeline.Pipe(sourceValue);
        Assert.That(actual, Is.SameAs(sourceValue));
    }
}
