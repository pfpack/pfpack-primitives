#nullable enable

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System;

partial class Predicates
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNotNullOrEmpty([NotNullWhen(true)][MaybeNullWhen(false)] string? value)
        =>
        string.IsNullOrEmpty(value) is false;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNullOrEmpty([NotNullWhen(false)][MaybeNullWhen(true)] string? value)
        =>
        string.IsNullOrEmpty(value);
}
