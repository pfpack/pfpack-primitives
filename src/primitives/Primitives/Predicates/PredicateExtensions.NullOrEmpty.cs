#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace System
{
    partial class PredicateExtensions
    {
        public static bool IsNullOrEmpty([NotNullWhen(false)] this string? value)
            =>
            string.IsNullOrEmpty(value);
    }
}
