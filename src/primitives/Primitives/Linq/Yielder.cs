#nullable enable

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static class Yielder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> YieldSingle<T>(T value)
            =>
            Yielder<T>.YieldSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> YieldEmpty<T>()
            =>
            Yielder<T>.YieldEmpty();
    }
}
