#nullable enable

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System;

partial class PredicateExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNotNull<T>([NotNullWhen(true)] this T? value) where T : struct
        =>
        value is not null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNull<T>([NotNullWhen(false)] this T? value) where T : struct
        =>
        value is null;
}
