#nullable enable

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static partial class YieldExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> YieldSingle<T>(this T value) => Yielder.YieldSingle(value);
    }
}
