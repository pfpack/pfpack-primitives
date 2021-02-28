#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace System
{
    partial class Predicates
    {
        public static bool IsNotNullOrEmpty([NotNullWhen(true)] string? value)
            =>
            string.IsNullOrEmpty(value) is false;

        public static bool IsNullOrEmpty([NotNullWhen(false)] string? value)
            =>
            string.IsNullOrEmpty(value);
    }
}
