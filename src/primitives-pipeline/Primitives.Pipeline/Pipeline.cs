#nullable enable

using System.Runtime.CompilerServices;

namespace System
{
    public static class Pipeline
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Pipe<T>(T value) => value;
    }
}
