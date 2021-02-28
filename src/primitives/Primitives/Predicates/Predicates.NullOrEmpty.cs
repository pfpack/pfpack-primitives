#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace System
{
    partial class Predicates
    {
        public static bool IsNullOrEmpty([NotNullWhen(false)] string? value)
            =>
            string.IsNullOrEmpty(value);
    }
}
