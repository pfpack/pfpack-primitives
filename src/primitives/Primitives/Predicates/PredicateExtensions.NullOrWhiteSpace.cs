#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace System
{
    partial class PredicateExtensions
    {
        public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? value)
            =>
            string.IsNullOrWhiteSpace(value);
    }
}
