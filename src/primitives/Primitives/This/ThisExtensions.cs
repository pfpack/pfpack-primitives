#nullable enable

using System.Threading.Tasks;

namespace System
{
    public static class ThisExtensions
    {
        public static T This<T>(this T value)
            =>
            value;

        public static Task<T> ThisAsync<T>(this T value)
            =>
            Task.FromResult(value);

        public static ValueTask<T> ThisValueAsync<T>(this T value)
            =>
            ValueTask.FromResult(value);
    }
}
