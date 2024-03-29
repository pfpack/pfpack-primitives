﻿using System.Runtime.CompilerServices;

namespace System;

public static class PipelineExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TResult Pipe<T, TResult>(this T value, Func<T, TResult> pipe)
    {
        _ = pipe ?? throw new ArgumentNullException(nameof(pipe));

        return pipe.Invoke(value);
    }
}
