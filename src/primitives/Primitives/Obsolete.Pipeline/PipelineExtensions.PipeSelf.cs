#nullable enable

using System;
using System.Diagnostics.CodeAnalysis;

namespace PrimeFuncPack
{
    partial class PipelineExtensions
    {
        [Obsolete(ObsoleteMessages.ExtensionMethodPipeSelf, error: true)]
        [DoesNotReturn]
        public static TResult PipeSelf<T, TResult>(this T value, Func<T, TResult> pipe)
            =>
            throw new NotImplementedException(ObsoleteMessages.ExtensionMethodPipeSelf);
    }
}
