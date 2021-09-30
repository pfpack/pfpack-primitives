#nullable enable

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System;

partial class PredicateExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNotNullOrWhiteSpace([NotNullWhen(true)][MaybeNullWhen(false)] this string? value)
        =>
        string.IsNullOrWhiteSpace(value) is false;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNullOrWhiteSpace([NotNullWhen(false)][MaybeNullWhen(true)] this string? value)
        =>
        string.IsNullOrWhiteSpace(value);
}
