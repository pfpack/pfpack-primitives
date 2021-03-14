#nullable enable

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System
{
    partial class Predicates
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNotNullOrWhiteSpace([NotNullWhen(true)] string? value)
            =>
            string.IsNullOrWhiteSpace(value) is false;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrWhiteSpace([NotNullWhen(false)] string? value)
            =>
            string.IsNullOrWhiteSpace(value);
    }
}
