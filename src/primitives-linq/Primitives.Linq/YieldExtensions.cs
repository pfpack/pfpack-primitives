#nullable enable

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq;

public static class YieldExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IEnumerable<T> YieldSingle<T>(this T value)
        =>
        Yielder<T>.YieldSingle(value);
}
