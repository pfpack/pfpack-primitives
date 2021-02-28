#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace System
{
    partial class PredicateExtensions
    {
        public static bool IsNotNullOrEmpty([NotNullWhen(true)] this string? value)
            =>
            string.IsNullOrEmpty(value) is false;

        public static bool IsNullOrEmpty([NotNullWhen(false)] this string? value)
            =>
            string.IsNullOrEmpty(value);
    }
}
