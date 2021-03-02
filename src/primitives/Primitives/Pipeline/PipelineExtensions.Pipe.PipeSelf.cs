#nullable enable

namespace System
{
    partial class PipelineExtensions
    {
        public static TResult Pipe<T, TResult>(this T value, Func<T, TResult> pipe)
        {
            _ = pipe ?? throw new ArgumentNullException(nameof(pipe));
            return pipe.Invoke(value);
        }
    }
}

namespace PrimeFuncPack
{
    using System;

    partial class PipelineExtensions
    {
        public static TResult PipeSelf<T, TResult>(this T value, Func<T, TResult> pipe)
        {
            _ = pipe ?? throw new ArgumentNullException(nameof(pipe));
            return pipe.Invoke(value);
        }
    }
}
