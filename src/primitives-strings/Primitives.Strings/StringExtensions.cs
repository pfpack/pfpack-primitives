using System.Runtime.CompilerServices;

namespace System;

public static class StringExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string OrEmpty(this string? value)
        =>
        Strings.OrEmpty(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? OrNullIfEmpty(this string? value)
        =>
        Strings.OrNullIfEmpty(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? OrNullIfWhiteSpace(this string? value)
        =>
        Strings.OrNullIfWhiteSpace(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ToStringOrEmpty<T>(this T? value)
        =>
        Strings.ToStringOrEmpty(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ToStringOrEmpty<T>(this T? value) where T : struct
        =>
        Strings.ToStringOrEmpty(value);
}
