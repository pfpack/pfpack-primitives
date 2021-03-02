#nullable enable

namespace System
{
    public static class StringExtensions
    {
        public static string OrEmpty(this string? value)
            =>
            Strings.OrEmpty(value);

        public static string? OrNullIfEmpty(this string? value)
            =>
            Strings.OrNullIfEmpty(value);

        public static string? OrNullIfWhiteSpace(this string? value)
            =>
            Strings.OrNullIfWhiteSpace(value);

        public static string ToStringOrEmpty<T>(this T value)
            =>
            Strings.ToStringOrEmpty(value);
    }
}
