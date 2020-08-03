﻿#nullable enable

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System
{
    partial class Box<T>
    {
        private static IEqualityComparer<T> ValueEqualityComparer => EqualityComparer<T>.Default;

        public static bool Equals([AllowNull] in Box<T> boxA, [AllowNull] in Box<T> boxB)
            =>
            ReferenceEquals(boxA, boxB) ||
            boxA is object &&
            boxB is object &&
            ValueEqualityComparer.Equals(boxA, boxB);

        public static bool operator ==([AllowNull] in Box<T> boxA, [AllowNull] in Box<T> boxB)
            =>
            Equals(boxA, boxB);

        public static bool operator !=([AllowNull] in Box<T> boxA, [AllowNull] in Box<T> boxB)
            =>
            Equals(boxA, boxB) is false;

        public bool Equals([AllowNull] Box<T> other)
            =>
            Equals(this, other);

        public override bool Equals(object? obj)
            =>
            obj is Box<T> other &&
            Equals(this, other);

        public override int GetHashCode()
            =>
            Value switch { null => default, var present => ValueEqualityComparer.GetHashCode(present) };
    }
}
