#nullable enable

using System.Runtime.CompilerServices;

namespace System
{
    partial class PipelineExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult Pipe<T, TResult>(this T value, Func<T, TResult> pipe)
        {
            _ = pipe ?? throw new ArgumentNullException(nameof(pipe));
            
            return pipe.Invoke(value);
        }
    }
}
