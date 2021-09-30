#nullable enable

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System;

partial class PredicateExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNotNull<T>([NotNullWhen(true)][MaybeNullWhen(false)] this T? value)
        =>
        value is not null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNull<T>([NotNullWhen(false)][MaybeNullWhen(true)] this T? value)
        =>
        value is null;
}
