﻿using System.Collections.Generic;

namespace System.Linq;

// TODO: Remove this class in v4.0
[Obsolete("This class is obsolete. Use Yielder class instead.", error: true)]
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
