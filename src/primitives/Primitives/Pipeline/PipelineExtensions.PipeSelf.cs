#nullable enable

using System;
using System.Runtime.CompilerServices;

namespace PrimeFuncPack
{
    partial class PipelineExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult PipeSelf<T, TResult>(this T value, Func<T, TResult> pipe)
        {
            _ = pipe ?? throw new ArgumentNullException(nameof(pipe));
            
            return pipe.Invoke(value);
        }
    }
}
