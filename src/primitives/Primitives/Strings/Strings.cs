#nullable enable

namespace System
{
    public static class Strings
    {
        public const string Empty = "";

        public static string GetEmpty() => Empty;

        public static string OrEmpty(string? value)
            =>
            value ?? Empty;

        public static string? OrNullIfEmpty(string? value)
            =>
            string.IsNullOrEmpty(value)
                ? null
                : value;

        public static string? OrNullIfWhiteSpace(string? value)
            =>
            string.IsNullOrWhiteSpace(value)
                ? null
                : value;

        public static string ToStringOrEmpty<T>(T value)
            =>
            value?.ToString() ?? Empty;
    }
}
