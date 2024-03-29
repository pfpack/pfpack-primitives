﻿using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System;

partial class PredicateExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNotNullOrEmpty([NotNullWhen(true)][MaybeNullWhen(false)] this string? value)
        =>
        string.IsNullOrEmpty(value) is false;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNullOrEmpty([NotNullWhen(false)][MaybeNullWhen(true)] this string? value)
        =>
        string.IsNullOrEmpty(value);
}
