using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System;

partial class Predicates
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNotNullOrWhiteSpace([NotNullWhen(true)][MaybeNullWhen(false)] string? value)
        =>
        string.IsNullOrWhiteSpace(value) is false;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNullOrWhiteSpace([NotNullWhen(false)][MaybeNullWhen(true)] string? value)
        =>
        string.IsNullOrWhiteSpace(value);
}
