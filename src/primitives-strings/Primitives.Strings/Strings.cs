using System.Runtime.CompilerServices;

namespace System;

public static class Strings
{
    public const string Empty = "";

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GetEmpty() => Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string OrEmpty(string? value)
        =>
        value ?? Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? OrNullIfEmpty(string? value)
        =>
        string.IsNullOrEmpty(value)
            ? null
            : value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? OrNullIfWhiteSpace(string? value)
        =>
        string.IsNullOrWhiteSpace(value)
            ? null
            : value;
}
