﻿#nullable enable

namespace System
{
    partial struct Optional<T>
    {
        public T OrThrow() => OrThrow(CreateExpectedPresentException);

        public T OrThrow(Func<Exception> exceptionFactory)
        {
            _ = exceptionFactory ?? throw new ArgumentNullException(nameof(exceptionFactory));

            var theExceptionFactory = exceptionFactory;

            return ImplFold(Do.Pass, () => throw theExceptionFactory.Invoke());
        }
    }
}
