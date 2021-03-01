#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace System
{
    partial class Predicates
    {
        public static bool IsNotNullOrWhiteSpace([NotNullWhen(true)] string? value)
            =>
            string.IsNullOrWhiteSpace(value) is false;

        public static bool IsNullOrWhiteSpace([NotNullWhen(false)] string? value)
            =>
            string.IsNullOrWhiteSpace(value);
    }
}
