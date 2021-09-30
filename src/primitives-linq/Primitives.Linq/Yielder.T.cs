#nullable enable

using System.Collections.Generic;

namespace System.Linq;

public static class Yielder<T>
{
    public static IEnumerable<T> YieldSingle(T value)
    {
        yield return value;
    }

    public static IEnumerable<T> YieldEmpty()
    {
        yield break;
    }
}
