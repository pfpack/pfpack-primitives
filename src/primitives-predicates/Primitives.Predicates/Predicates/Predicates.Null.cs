using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System;

partial class Predicates
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNotNull<T>([NotNullWhen(true)][MaybeNullWhen(false)] T? value)
        =>
        value is not null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNull<T>([NotNullWhen(false)][MaybeNullWhen(true)] T? value)
        =>
        value is null;
}
