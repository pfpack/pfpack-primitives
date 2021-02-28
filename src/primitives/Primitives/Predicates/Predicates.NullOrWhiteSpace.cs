#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace System
{
    partial class Predicates
    {
        public static bool IsNullOrWhiteSpace([NotNullWhen(false)] string? value)
            =>
            string.IsNullOrWhiteSpace(value);
    }
}
