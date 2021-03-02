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
            string.IsNullOrEmpty(value) switch
            {
                true => null,
                _ => value
            };

        public static string? OrNullIfWhiteSpace(string? value)
            =>
            string.IsNullOrWhiteSpace(value) switch
            {
                true => null,
                _ => value
            };

        public static string ToStringOrEmpty<T>(T value)
            =>
            value switch
            {
                 not null => value.ToString() ?? Empty,
                 _ => Empty
            };
    }
}
